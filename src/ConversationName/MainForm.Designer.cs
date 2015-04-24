namespace ConversationName
{
  partial class MainForm
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.txtName = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnPrevious = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnRegenerate = new System.Windows.Forms.Button();
      this.btnToday = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 77);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.BackColor = System.Drawing.SystemColors.Window;
      this.txtName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(3, 5);
      this.txtName.Name = "txtName";
      this.txtName.ReadOnly = true;
      this.txtName.Size = new System.Drawing.Size(380, 37);
      this.txtName.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 6;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnPrevious, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnNext, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnRegenerate, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnToday, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 30);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // btnPrevious
      // 
      this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPrevious.Location = new System.Drawing.Point(3, 3);
      this.btnPrevious.Name = "btnPrevious";
      this.btnPrevious.Size = new System.Drawing.Size(34, 24);
      this.btnPrevious.TabIndex = 0;
      this.btnPrevious.Text = "<";
      this.btnPrevious.UseVisualStyleBackColor = true;
      this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
      // 
      // btnNext
      // 
      this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnNext.Location = new System.Drawing.Point(43, 3);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(34, 24);
      this.btnNext.TabIndex = 1;
      this.btnNext.Text = ">";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRefresh.Location = new System.Drawing.Point(229, 3);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(74, 24);
      this.btnRefresh.TabIndex = 2;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnRegenerate
      // 
      this.btnRegenerate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRegenerate.Location = new System.Drawing.Point(309, 3);
      this.btnRegenerate.Name = "btnRegenerate";
      this.btnRegenerate.Size = new System.Drawing.Size(74, 24);
      this.btnRegenerate.TabIndex = 3;
      this.btnRegenerate.Text = "Regenerate";
      this.btnRegenerate.UseVisualStyleBackColor = true;
      this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
      // 
      // btnToday
      // 
      this.btnToday.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnToday.Location = new System.Drawing.Point(83, 3);
      this.btnToday.Name = "btnToday";
      this.btnToday.Size = new System.Drawing.Size(74, 24);
      this.btnToday.TabIndex = 4;
      this.btnToday.Text = "Today";
      this.btnToday.UseVisualStyleBackColor = true;
      this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 77);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ConversationName";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnRegenerate;
    private System.Windows.Forms.Button btnToday;
  }
}

