namespace LovelyLib
{
  partial class DeleteBook
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBook));
      this.panel1 = new System.Windows.Forms.Panel();
      this.delBookName = new System.Windows.Forms.Label();
      this.yesButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.delBookName);
      this.panel1.Controls.Add(this.yesButton);
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(282, 146);
      this.panel1.TabIndex = 1;
      // 
      // delBookName
      // 
      this.delBookName.Dock = System.Windows.Forms.DockStyle.Top;
      this.delBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.delBookName.Location = new System.Drawing.Point(0, 0);
      this.delBookName.Name = "delBookName";
      this.delBookName.Size = new System.Drawing.Size(282, 111);
      this.delBookName.TabIndex = 12;
      this.delBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // yesButton
      // 
      this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.yesButton.BackColor = System.Drawing.Color.White;
      this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.yesButton.Location = new System.Drawing.Point(197, 114);
      this.yesButton.Name = "yesButton";
      this.yesButton.Size = new System.Drawing.Size(82, 29);
      this.yesButton.TabIndex = 11;
      this.yesButton.Text = "Да";
      this.yesButton.UseVisualStyleBackColor = false;
      this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cancelButton.BackColor = System.Drawing.Color.White;
      this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelButton.Location = new System.Drawing.Point(3, 114);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(82, 29);
      this.cancelButton.TabIndex = 0;
      this.cancelButton.Text = "Отмена";
      this.cancelButton.UseVisualStyleBackColor = false;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // DeleteBook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(306, 170);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DeleteBook";
      this.Text = "LovelyLib";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label delBookName;
    private System.Windows.Forms.Button yesButton;
    private System.Windows.Forms.Button cancelButton;
  }
}