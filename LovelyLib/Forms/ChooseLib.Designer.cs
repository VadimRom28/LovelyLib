namespace LovelyLib
{
  partial class ChooseLib
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLib));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.deleteLib = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.libUserBase = new System.Windows.Forms.ListBox();
      this.selectLibButton = new System.Windows.Forms.Button();
      this.backButton = new System.Windows.Forms.Button();
      this.createLibButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Beige;
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.splitContainer1.Size = new System.Drawing.Size(535, 279);
      this.splitContainer1.SplitterDistance = 57;
      this.splitContainer1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(535, 57);
      this.label1.TabIndex = 0;
      this.label1.Text = "Выберите библиотеку";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.IsSplitterFixed = true;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.deleteLib);
      this.splitContainer2.Panel1.Controls.Add(this.panel1);
      this.splitContainer2.Panel1.Controls.Add(this.selectLibButton);
      this.splitContainer2.Panel1.Controls.Add(this.backButton);
      this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.splitContainer2.Panel2.Controls.Add(this.createLibButton);
      this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.splitContainer2.Size = new System.Drawing.Size(535, 218);
      this.splitContainer2.SplitterDistance = 401;
      this.splitContainer2.SplitterWidth = 1;
      this.splitContainer2.TabIndex = 0;
      // 
      // deleteLib
      // 
      this.deleteLib.BackColor = System.Drawing.Color.White;
      this.deleteLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteLib.Location = new System.Drawing.Point(100, 185);
      this.deleteLib.Name = "deleteLib";
      this.deleteLib.Size = new System.Drawing.Size(82, 29);
      this.deleteLib.TabIndex = 8;
      this.deleteLib.Text = "Удалить";
      this.deleteLib.UseVisualStyleBackColor = false;
      this.deleteLib.Click += new System.EventHandler(this.deleteLib_Click);
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Controls.Add(this.libUserBase);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(401, 179);
      this.panel1.TabIndex = 7;
      // 
      // libUserBase
      // 
      this.libUserBase.Dock = System.Windows.Forms.DockStyle.Fill;
      this.libUserBase.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.libUserBase.FormattingEnabled = true;
      this.libUserBase.ItemHeight = 19;
      this.libUserBase.Location = new System.Drawing.Point(0, 0);
      this.libUserBase.Name = "libUserBase";
      this.libUserBase.Size = new System.Drawing.Size(401, 179);
      this.libUserBase.TabIndex = 1;
      // 
      // selectLibButton
      // 
      this.selectLibButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.selectLibButton.BackColor = System.Drawing.Color.White;
      this.selectLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.selectLibButton.Location = new System.Drawing.Point(307, 185);
      this.selectLibButton.Name = "selectLibButton";
      this.selectLibButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.selectLibButton.Size = new System.Drawing.Size(82, 29);
      this.selectLibButton.TabIndex = 4;
      this.selectLibButton.Text = "ОK";
      this.selectLibButton.UseVisualStyleBackColor = false;
      this.selectLibButton.Click += new System.EventHandler(this.selectLibButton_Click);
      // 
      // backButton
      // 
      this.backButton.BackColor = System.Drawing.Color.White;
      this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.backButton.Location = new System.Drawing.Point(12, 185);
      this.backButton.Name = "backButton";
      this.backButton.Size = new System.Drawing.Size(82, 29);
      this.backButton.TabIndex = 3;
      this.backButton.Text = "Назад";
      this.backButton.UseVisualStyleBackColor = false;
      this.backButton.Click += new System.EventHandler(this.backButton_Click);
      // 
      // createLibButton
      // 
      this.createLibButton.BackColor = System.Drawing.Color.White;
      this.createLibButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.createLibButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createLibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createLibButton.Location = new System.Drawing.Point(0, 0);
      this.createLibButton.Name = "createLibButton";
      this.createLibButton.Size = new System.Drawing.Size(133, 64);
      this.createLibButton.TabIndex = 2;
      this.createLibButton.Text = "Создать новую библиотеку";
      this.createLibButton.UseVisualStyleBackColor = false;
      this.createLibButton.Click += new System.EventHandler(this.createLibButton_Click);
      // 
      // ChooseLib
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(535, 279);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(637, 327);
      this.MinimumSize = new System.Drawing.Size(273, 318);
      this.Name = "ChooseLib";
      this.Text = "LovelyLib";
      this.Activated += new System.EventHandler(this.ChooseLib_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseLib_FormClosed);
      this.Shown += new System.EventHandler(this.ChooseLib_Shown);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Button createLibButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Button selectLibButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListBox libUserBase;
    private System.Windows.Forms.Button deleteLib;
  }
}