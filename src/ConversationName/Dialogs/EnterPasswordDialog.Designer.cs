namespace ConversationName
{
  partial class EnterPasswordDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tblEnterPassword = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblCofirmPassword = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtConfirmPassword = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.chkSavePassword = new System.Windows.Forms.CheckBox();
      this.tblEnterPassword.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tblEnterPassword
      // 
      this.tblEnterPassword.ColumnCount = 2;
      this.tblEnterPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tblEnterPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tblEnterPassword.Controls.Add(this.label1, 0, 1);
      this.tblEnterPassword.Controls.Add(this.lblCofirmPassword, 0, 2);
      this.tblEnterPassword.Controls.Add(this.txtPassword, 1, 1);
      this.tblEnterPassword.Controls.Add(this.txtConfirmPassword, 1, 2);
      this.tblEnterPassword.Controls.Add(this.tableLayoutPanel2, 0, 5);
      this.tblEnterPassword.Controls.Add(this.chkSavePassword, 0, 3);
      this.tblEnterPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblEnterPassword.Location = new System.Drawing.Point(0, 0);
      this.tblEnterPassword.Name = "tblEnterPassword";
      this.tblEnterPassword.RowCount = 6;
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tblEnterPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tblEnterPassword.Size = new System.Drawing.Size(398, 107);
      this.tblEnterPassword.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Password:";
      // 
      // lblCofirmPassword
      // 
      this.lblCofirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblCofirmPassword.AutoSize = true;
      this.lblCofirmPassword.Location = new System.Drawing.Point(3, 34);
      this.lblCofirmPassword.Name = "lblCofirmPassword";
      this.lblCofirmPassword.Size = new System.Drawing.Size(103, 13);
      this.lblCofirmPassword.TabIndex = 1;
      this.lblCofirmPassword.Text = "Re-enter Password:";
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(112, 3);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(283, 21);
      this.txtPassword.TabIndex = 2;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // txtConfirmPassword
      // 
      this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConfirmPassword.Location = new System.Drawing.Point(112, 30);
      this.txtConfirmPassword.Name = "txtConfirmPassword";
      this.txtConfirmPassword.Size = new System.Drawing.Size(283, 21);
      this.txtConfirmPassword.TabIndex = 3;
      this.txtConfirmPassword.UseSystemPasswordChar = true;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tblEnterPassword.SetColumnSpan(this.tableLayoutPanel2, 2);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 77);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 30);
      this.tableLayoutPanel2.TabIndex = 4;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(241, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(321, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btn_Click);
      // 
      // chkSavePassword
      // 
      this.chkSavePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.chkSavePassword.AutoSize = true;
      this.chkSavePassword.Checked = true;
      this.chkSavePassword.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tblEnterPassword.SetColumnSpan(this.chkSavePassword, 2);
      this.chkSavePassword.Location = new System.Drawing.Point(149, 57);
      this.chkSavePassword.Name = "chkSavePassword";
      this.chkSavePassword.Size = new System.Drawing.Size(99, 17);
      this.chkSavePassword.TabIndex = 5;
      this.chkSavePassword.Text = "Save Password";
      this.chkSavePassword.UseVisualStyleBackColor = true;
      // 
      // EnterPasswordDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(398, 107);
      this.Controls.Add(this.tblEnterPassword);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EnterPasswordDialog";
      this.Text = "EnterPasswordDialog";
      this.tblEnterPassword.ResumeLayout(false);
      this.tblEnterPassword.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tblEnterPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblCofirmPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.CheckBox chkSavePassword;
  }
}