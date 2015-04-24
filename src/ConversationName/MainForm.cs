using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversationName
{
  public partial class MainForm : BaseForm
  {
    private ConversationNames convoNames;
    private ConversationNamesSerializer cns;

    private string filepath;
    private DateTime currentKey = DateTime.Today;
    private bool shutDownRequested = false;

    public MainForm()
    {
      InitializeComponent();
      InitializeDatabase();
    }

    private async void InitializeDatabase()
    {
      cns = new ConversationNamesSerializer();
      await Task.Yield();

      if (!EnsureDatabaseIsCreated())
      {
        Shutdown();
        return;
      }

      if (!LoadConvoNames())
      {
        Shutdown();
        return;
      }
      else
      {
        DoRefresh();
      }
    }

    private async void Shutdown()
    {
      shutDownRequested = true;
      Enabled = false;
      await Task.Yield();
      Close();
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
          cns.Write(stream, convoNames);
        }
        catch
        {
          // swallow it
        }
      }
    }

    private bool EnsureDatabaseIsCreated()
    {
      filepath = Path.Combine(Application.StartupPath, "dbase.bin");
      if (!File.Exists(filepath))
      {
        convoNames = new ConversationNames();
        SaveConversationNames();
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
          convoNames = cns.Read(stream);
        }
        catch (Exception ex)
        {
          string message = string.Format("Unable to load because {0}", ex.Message);
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

    private void btnToday_Click(object sender, EventArgs e)
    {
      currentKey = DateTime.Today;
      DoRefresh();
    }
  }
}
