namespace LovelyLib
{
  partial class AddUserToBaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserToBaseForm));
      this.loginText = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.passwordText = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.userType = new System.Windows.Forms.RadioButton();
      this.adminType = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.uncorrectDataText = new System.Windows.Forms.TextBox();
      this.cancelButton = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // loginText
      // 
      this.loginText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loginText.Location = new System.Drawing.Point(66, 28);
      this.loginText.Name = "loginText";
      this.loginText.Size = new System.Drawing.Size(306, 32);
      this.loginText.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.label3.Location = new System.Drawing.Point(66, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(306, 15);
      this.label3.TabIndex = 12;
      this.label3.Text = "Пароль:";
      // 
      // passwordText
      // 
      this.passwordText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.passwordText.ForeColor = System.Drawing.SystemColors.WindowText;
      this.passwordText.Location = new System.Drawing.Point(66, 84);
      this.passwordText.Name = "passwordText";
      this.passwordText.Size = new System.Drawing.Size(306, 32);
      this.passwordText.TabIndex = 13;
      this.passwordText.UseSystemPasswordChar = true;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(66, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(306, 13);
      this.label2.TabIndex = 14;
      this.label2.Text = "Логин:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.userType);
      this.panel1.Controls.Add(this.adminType);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 122);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(360, 42);
      this.panel1.TabIndex = 15;
      // 
      // userType
      // 
      this.userType.AutoSize = true;
      this.userType.Location = new System.Drawing.Point(109, 20);
      this.userType.Name = "userType";
      this.userType.Size = new System.Drawing.Size(61, 17);
      this.userType.TabIndex = 2;
      this.userType.TabStop = true;
      this.userType.Text = "Клиент";
      this.userType.UseVisualStyleBackColor = true;
      // 
      // adminType
      // 
      this.adminType.AutoSize = true;
      this.adminType.Location = new System.Drawing.Point(109, 3);
      this.adminType.Name = "adminType";
      this.adminType.Size = new System.Drawing.Size(104, 17);
      this.adminType.TabIndex = 1;
      this.adminType.TabStop = true;
      this.adminType.Text = "Администратор";
      this.adminType.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Тип пользователя:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // uncorrectDataText
      // 
      this.uncorrectDataText.BackColor = System.Drawing.Color.White;
      this.uncorrectDataText.Enabled = false;
      this.uncorrectDataText.ForeColor = System.Drawing.Color.Red;
      this.uncorrectDataText.Location = new System.Drawing.Point(12, 170);
      this.uncorrectDataText.Name = "uncorrectDataText";
      this.uncorrectDataText.ReadOnly = true;
      this.uncorrectDataText.Size = new System.Drawing.Size(360, 20);
      this.uncorrectDataText.TabIndex = 16;
      this.uncorrectDataText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.White;
      this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelButton.Location = new System.Drawing.Point(12, 196);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(82, 27);
      this.cancelButton.TabIndex = 17;
      this.cancelButton.Text = "Отмена";
      this.cancelButton.UseVisualStyleBackColor = false;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // createButton
      // 
      this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.createButton.BackColor = System.Drawing.Color.White;
      this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createButton.Location = new System.Drawing.Point(290, 196);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(82, 27);
      this.createButton.TabIndex = 18;
      this.createButton.Text = "ОК";
      this.createButton.UseVisualStyleBackColor = false;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::LovelyLib.Properties.Resources._lock;
      this.pictureBox2.Location = new System.Drawing.Point(12, 66);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(48, 50);
      this.pictureBox2.TabIndex = 11;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::LovelyLib.Properties.Resources.user1;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(48, 48);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // AddUserToBaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(384, 228);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.uncorrectDataText);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.passwordText);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.loginText);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(400, 280);
      this.MinimumSize = new System.Drawing.Size(400, 250);
      this.Name = "AddUserToBaseForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox loginText;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox passwordText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton userType;
    private System.Windows.Forms.RadioButton adminType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uncorrectDataText;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button createButton;
  }
}