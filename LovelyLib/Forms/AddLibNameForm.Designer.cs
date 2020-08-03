namespace LovelyLib
{
  partial class AddLibNameForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLibNameForm));
      this.label1 = new System.Windows.Forms.Label();
      this.LibNameText = new System.Windows.Forms.TextBox();
      this.CreateButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Имя библиотеки:";
      // 
      // LibNameText
      // 
      this.LibNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LibNameText.Location = new System.Drawing.Point(12, 53);
      this.LibNameText.Name = "LibNameText";
      this.LibNameText.Size = new System.Drawing.Size(242, 20);
      this.LibNameText.TabIndex = 0;
      // 
      // CreateButton
      // 
      this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CreateButton.BackColor = System.Drawing.Color.White;
      this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CreateButton.Location = new System.Drawing.Point(181, 4);
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(75, 23);
      this.CreateButton.TabIndex = 1;
      this.CreateButton.Text = "Создать";
      this.CreateButton.UseVisualStyleBackColor = false;
      this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.CreateButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 165);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(268, 32);
      this.panel1.TabIndex = 0;
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.White;
      this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelButton.Location = new System.Drawing.Point(12, 4);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 3;
      this.cancelButton.Text = "Отмена";
      this.cancelButton.UseVisualStyleBackColor = false;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
      // 
      // AddLibNameForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(268, 197);
      this.Controls.Add(this.LibNameText);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximumSize = new System.Drawing.Size(550, 300);
      this.MinimumSize = new System.Drawing.Size(227, 147);
      this.Name = "AddLibNameForm";
      this.Text = "LovelyLib";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddLibNameForm_KeyDown);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox LibNameText;
    private System.Windows.Forms.Button CreateButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button cancelButton;
  }
}