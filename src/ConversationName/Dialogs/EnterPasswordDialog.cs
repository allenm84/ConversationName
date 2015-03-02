using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversationName
{
  public partial class EnterPasswordDialog : BaseForm
  {
    public string Password { get { return txtPassword.Text; } }
    public bool SavePassword { get { return chkSavePassword.Checked; } }

    private bool buttonClick = false;
    private bool confirmPassword = true;
    public bool ConfirmPassword
    {
      set
      {
        confirmPassword = value;
        tblEnterPassword.SuspendLayout();
        lblCofirmPassword.Visible = confirmPassword;
        txtConfirmPassword.Visible = confirmPassword;
        tblEnterPassword.ResumeLayout(true);
      }
    }

    public EnterPasswordDialog()
    {
      InitializeComponent();
    }

    private bool ValidateInput(DialogResult result)
    {
      if (result == System.Windows.Forms.DialogResult.OK)
      {
        if (confirmPassword)
        {
          bool match = string.Equals(txtPassword.Text, txtConfirmPassword.Text);
          if (!match)
          {
            MessageBox.Show(this, "The two passwords do not match", "Confirm Password",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
          }
        }

        if (txtPassword.Text.Length < 6)
        {
          MessageBox.Show(this, "The password must be at least 6 characters long", "Password",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
          return false;
        }

        return true;
      }
      else if (result == System.Windows.Forms.DialogResult.Cancel)
      {
        result = MessageBox.Show(this, "If you cancel then the program will close. Are you sure you want to cancel?",
          Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // if the user clicks "Yes", then the Cancel is a valid input
        return (result == DialogResult.Yes);
      }

      return false;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing || buttonClick)
      {
        e.Cancel = !ValidateInput(DialogResult);
      }

      buttonClick = false;
      base.OnFormClosing(e);
    }

    private void btn_Click(object sender, EventArgs e)
    {
      buttonClick = true;
    }
  }
}
