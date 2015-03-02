using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversationNames = System.Collections.Generic.Dictionary<System.DateTime, string>;

namespace ConversationName
{
  public partial class MainForm : BaseForm
  {
    private ConversationNames convoNames;
    private string filepath;
    private SymmetricAlgorithm encryption;
    private DataContractSerializer dcs;
    private Lazy<string> appFile;
    private DateTime currentKey = DateTime.Today;
    private bool shutDownRequested = false;

    public MainForm()
    {
      InitializeComponent();
      dcs = new DataContractSerializer(typeof(ConversationNames));
      appFile = new Lazy<string>(GetAppFile, true);
    }

    private string GetAppFile()
    {
      var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      var appDir = Path.Combine(appData, "ConversationName");
      if (!Directory.Exists(appDir))
      {
        Directory.CreateDirectory(appDir);
      }

      return Path.Combine(appDir, "data.bin");
    }

    private void Shutdown()
    {
      shutDownRequested = true;
      Enabled = false;
      BeginInvoke(new Action(Close));
    }

    private void ProcessEnterPasswordInput(EnterPasswordDialog dlg)
    {
      string password = dlg.Password;
      InitializeEncryption(password);

      if (dlg.SavePassword)
      {
        SavePassword(password);
      }
    }

    private Stream AttemptToCreate(string filepath)
    {
      int attempts = 0;
      Stream stream = null;
      bool error = false;

      do
      {
        try
        {
          stream = File.Create(filepath);
          error = false;
        }
        catch (Exception ex)
        {
          error = true;
          stream = null;
          Thread.Sleep(100);

          ++attempts;
          if (attempts >= 300)
          {
            var message = string.Format("Unable to create the file because {0}. Please try again later.", ex.Message);
            MessageBox.Show(this, message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Shutdown();
          }
        }
      }
      while (error);
      return stream;
    }

    private void SaveConversationNames()
    {
      using (var stream = AttemptToCreate(filepath))
      {
        try
        {
          using (var crypto = new CryptoStream(stream, encryption.CreateEncryptor(), CryptoStreamMode.Write))
          {
            dcs.WriteObject(crypto, convoNames);
          }
        }
        catch
        {
          // swallow it
        }
      }
    }

    private void SavePassword(string password)
    {
      var bytes = Encoding.UTF8.GetBytes(password);
      var data = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
      File.WriteAllBytes(appFile.Value, data);
    }

    private static char[] CreateSalt(string password)
    {
      return Enumerable.Repeat(password, password.Length).SelectMany(c => c).ToArray();
    }

    private void InitializeEncryption(string password)
    {
      encryption = new RijndaelManaged();
      var salt = CreateSalt(password);
      var key = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(salt));
      encryption.Key = key.GetBytes(encryption.KeySize / 8);
      encryption.IV = key.GetBytes(encryption.BlockSize / 8);
      encryption.Padding = PaddingMode.PKCS7;
    }

    private bool EnsureDatabaseIsCreated()
    {
      filepath = Path.Combine(Application.StartupPath, "dbase.bin");
      if (!File.Exists(filepath))
      {
        using (var dlg = new EnterPasswordDialog())
        {
          dlg.Text = "Create Database";
          dlg.ConfirmPassword = true;

          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            ProcessEnterPasswordInput(dlg);
            convoNames = new ConversationNames();
            SaveConversationNames();
          }
          else
          {
            // the user did not click "OK", so the database will not be created
            return false;
          }
        }
      }

      return true;
    }

    private bool EnsureEncryptionIsCreated()
    {
      if (encryption == null)
      {
        // has the password been saved?
        var path = appFile.Value;
        if (File.Exists(path))
        {
          try
          {
            var cipher = File.ReadAllBytes(path);
            var bytes = ProtectedData.Unprotect(cipher, null, DataProtectionScope.CurrentUser);
            InitializeEncryption(Encoding.UTF8.GetString(bytes));

            // the encryption has been initialized, so return
            return true;
          }
          catch(Exception ex)
          {
            // delete the file and fall through
            MessageBox.Show(this, "Unable to read the saved password because " + ex.Message, "Error", 
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            File.Delete(path);
          }
        }

        // if we get here, we need the password so we can initialize the encryption
        using (var dlg = new EnterPasswordDialog())
        {
          dlg.Text = "Enter Password";
          dlg.ConfirmPassword = false;

          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            ProcessEnterPasswordInput(dlg);
          }
          else
          {
            return false;
          }
        }
      }
      return true;
    }

    private bool LoadConvoNames()
    {
      Enabled = false;

      using (var stream = File.OpenRead(filepath))
      {
        try
        {
          using (var crypto = new CryptoStream(stream, encryption.CreateDecryptor(), CryptoStreamMode.Read))
          {
            convoNames = dcs.ReadObject(crypto) as ConversationNames;
          }
        }
        catch (Exception ex)
        {
          string message = string.Format("Unable to load because {0}. Make sure you entered the right password", ex.Message);
          MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }

      Enabled = true;
      return true;
    }

    private void DisplayName(string name)
    {
      txtName.Text = name;
      Text = string.Format("ConverastionName for {0:d}", currentKey);
    }

    private void DoRegenerate()
    {
      var name = Tools.GenerateRandomName();
      convoNames[currentKey] = name;
      DisplayName(name);
      SaveConversationNames();
    }

    private void DoRefresh()
    {
      string name;
      if (!convoNames.TryGetValue(currentKey, out name))
      {
        DoRegenerate();
      }
      else
      {
        DisplayName(name);
      }
    }

    private void MoveToKey(int delta, string message, string caption)
    {
      var keys = convoNames.Keys.ToArray();

      var index = Array.IndexOf(keys, currentKey);
      index += delta;

      if (-1 < index && index < keys.Length)
      {
        currentKey = keys[index];
        DoRefresh();
      }
      else
      {
        MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      if (!EnsureDatabaseIsCreated())
      {
        Shutdown();
        return;
      }

      if (!EnsureEncryptionIsCreated())
      {
        Shutdown();
        return;
      }

      if (!LoadConvoNames())
      {
        string saved = appFile.Value;
        if (File.Exists(saved))
        {
          // don't try the wrong password next time
          File.Delete(appFile.Value);
        }

        Shutdown();
        return;
      }
      else
      {
        DoRefresh();
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      if (!shutDownRequested)
      {
        SaveConversationNames();
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      var message = string.Format("Would you like to re-read the conversation name for {0:d}?", currentKey);
      var result = MessageBox.Show(this, message, "Refresh", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      DoRefresh();
    }

    private void btnRegenerate_Click(object sender, EventArgs e)
    {
      var message = string.Format("Would you like to create a new conversation name for {0:d}?", currentKey);
      var result = MessageBox.Show(this, message, "Regenerate", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      DoRegenerate();
    }

    private void btnPrevious_Click(object sender, EventArgs e)
    {
      MoveToKey(-1, "There aren't any previous entries", "Previous");
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      MoveToKey(1, "There aren't any later entries", "Next");
    }
  }
}
