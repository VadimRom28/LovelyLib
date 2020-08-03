namespace LovelyLib
{
  partial class LoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.guestButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.exitButton = new System.Windows.Forms.Button();
      this.registrationButton = new System.Windows.Forms.Button();
      this.loginButton = new System.Windows.Forms.Button();
      this.passwordText = new System.Windows.Forms.TextBox();
      this.uncorrectDataText = new System.Windows.Forms.TextBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.loginText = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.Color.LemonChiffon;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LemonChiffon;
      this.splitContainer1.Panel2.Controls.Add(this.guestButton);
      this.splitContainer1.Panel2.Controls.Add(this.label3);
      this.splitContainer1.Panel2.Controls.Add(this.label2);
      this.splitContainer1.Panel2.Controls.Add(this.exitButton);
      this.splitContainer1.Panel2.Controls.Add(this.registrationButton);
      this.splitContainer1.Panel2.Controls.Add(this.loginButton);
      this.splitContainer1.Panel2.Controls.Add(this.passwordText);
      this.splitContainer1.Panel2.Controls.Add(this.uncorrectDataText);
      this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
      this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
      this.splitContainer1.Panel2.Controls.Add(this.loginText);
      this.splitContainer1.Size = new System.Drawing.Size(452, 211);
      this.splitContainer1.SplitterDistance = 35;
      this.splitContainer1.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(452, 35);
      this.label1.TabIndex = 6;
      this.label1.Text = "Авторизация";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // guestButton
      // 
      this.guestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.guestButton.BackColor = System.Drawing.Color.White;
      this.guestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.guestButton.Location = new System.Drawing.Point(234, 139);
      this.guestButton.Name = "guestButton";
      this.guestButton.Size = new System.Drawing.Size(82, 26);
      this.guestButton.TabIndex = 11;
      this.guestButton.Text = "Гость";
      this.guestButton.UseVisualStyleBackColor = false;
      this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.label3.Location = new System.Drawing.Point(66, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(306, 15);
      this.label3.TabIndex = 10;
      this.label3.Text = "Пароль:";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(66, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(306, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Логин:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.exitButton.BackColor = System.Drawing.Color.LightCoral;
      this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.exitButton.Location = new System.Drawing.Point(12, 139);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(82, 26);
      this.exitButton.TabIndex = 8;
      this.exitButton.Text = "Выход";
      this.exitButton.UseVisualStyleBackColor = false;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // registrationButton
      // 
      this.registrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.registrationButton.BackColor = System.Drawing.Color.White;
      this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.registrationButton.Location = new System.Drawing.Point(322, 139);
      this.registrationButton.Name = "registrationButton";
      this.registrationButton.Size = new System.Drawing.Size(118, 26);
      this.registrationButton.TabIndex = 7;
      this.registrationButton.Text = "Регистрация";
      this.registrationButton.UseVisualStyleBackColor = false;
      this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
      // 
      // loginButton
      // 
      this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.loginButton.BackColor = System.Drawing.Color.White;
      this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loginButton.Location = new System.Drawing.Point(100, 139);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(82, 26);
      this.loginButton.TabIndex = 3;
      this.loginButton.Text = "Войти";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // passwordText
      // 
      this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.passwordText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.passwordText.Location = new System.Drawing.Point(66, 75);
      this.passwordText.Name = "passwordText";
      this.passwordText.Size = new System.Drawing.Size(374, 32);
      this.passwordText.TabIndex = 2;
      this.passwordText.UseSystemPasswordChar = true;
      // 
      // uncorrectDataText
      // 
      this.uncorrectDataText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.uncorrectDataText.BackColor = System.Drawing.Color.White;
      this.uncorrectDataText.Enabled = false;
      this.uncorrectDataText.ForeColor = System.Drawing.Color.Red;
      this.uncorrectDataText.Location = new System.Drawing.Point(12, 113);
      this.uncorrectDataText.Name = "uncorrectDataText";
      this.uncorrectDataText.ReadOnly = true;
      this.uncorrectDataText.Size = new System.Drawing.Size(428, 20);
      this.uncorrectDataText.TabIndex = 5;
      this.uncorrectDataText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::LovelyLib.Properties.Resources._lock;
      this.pictureBox2.Location = new System.Drawing.Point(12, 57);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(48, 50);
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::LovelyLib.Properties.Resources.user1;
      this.pictureBox1.Location = new System.Drawing.Point(12, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(48, 48);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // loginText
      // 
      this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.loginText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loginText.Location = new System.Drawing.Point(66, 19);
      this.loginText.Name = "loginText";
      this.loginText.Size = new System.Drawing.Size(374, 32);
      this.loginText.TabIndex = 1;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(221)))), ((int)(((byte)(149)))));
      this.ClientSize = new System.Drawing.Size(452, 211);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximumSize = new System.Drawing.Size(525, 250);
      this.MinimumSize = new System.Drawing.Size(422, 250);
      this.Name = "LoginForm";
      this.Text = "LovelyLib";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox loginText;
    private System.Windows.Forms.TextBox uncorrectDataText;
    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.TextBox passwordText;
    private System.Windows.Forms.Button registrationButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button guestButton;
  }
}