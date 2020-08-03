namespace LovelyLib
{
  partial class AdminBaseForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBaseForm));
      this.panel3 = new System.Windows.Forms.Panel();
      this.exitButton = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.bookFindText = new System.Windows.Forms.TextBox();
      this.BooksList = new System.Windows.Forms.DataGridView();
      this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.userFindText = new System.Windows.Forms.TextBox();
      this.UsersList = new System.Windows.Forms.DataGridView();
      this.userLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.addToBase = new System.Windows.Forms.MenuStrip();
      this.добавитьВБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addBook = new System.Windows.Forms.ToolStripMenuItem();
      this.addUser = new System.Windows.Forms.ToolStripMenuItem();
      this.changeData = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editData = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteData = new System.Windows.Forms.ToolStripMenuItem();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
      this.panel2.SuspendLayout();
      this.addToBase.SuspendLayout();
      this.changeData.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FloralWhite;
      this.panel3.Controls.Add(this.exitButton);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, 422);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(847, 41);
      this.panel3.TabIndex = 1;
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.BackColor = System.Drawing.Color.LightCoral;
      this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.exitButton.Location = new System.Drawing.Point(753, 6);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(82, 29);
      this.exitButton.TabIndex = 9;
      this.exitButton.Text = "Выход";
      this.exitButton.UseVisualStyleBackColor = false;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
      this.splitContainer1.Panel2.Controls.Add(this.panel2);
      this.splitContainer1.Size = new System.Drawing.Size(847, 398);
      this.splitContainer1.SplitterDistance = 555;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 2;
      // 
      // splitContainer2
      // 
      this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 41);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.bookFindText);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.BooksList);
      this.splitContainer2.Size = new System.Drawing.Size(551, 353);
      this.splitContainer2.SplitterDistance = 46;
      this.splitContainer2.SplitterWidth = 1;
      this.splitContainer2.TabIndex = 1;
      // 
      // bookFindText
      // 
      this.bookFindText.BackColor = System.Drawing.Color.White;
      this.bookFindText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bookFindText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.bookFindText.Location = new System.Drawing.Point(0, 0);
      this.bookFindText.Multiline = true;
      this.bookFindText.Name = "bookFindText";
      this.bookFindText.Size = new System.Drawing.Size(549, 44);
      this.bookFindText.TabIndex = 0;
      this.bookFindText.Text = "Поиск";
      this.bookFindText.TextChanged += new System.EventHandler(this.bookFindText_TextChanged);
      this.bookFindText.Enter += new System.EventHandler(this.bookFindText_Enter);
      // 
      // BooksList
      // 
      this.BooksList.AllowDrop = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
      this.BooksList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.BooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.BooksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.BooksList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
      this.BooksList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.BooksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.BooksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.BooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Author,
            this.Genre,
            this.Price});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.BooksList.DefaultCellStyle = dataGridViewCellStyle3;
      this.BooksList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BooksList.GridColor = System.Drawing.SystemColors.Desktop;
      this.BooksList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BooksList.Location = new System.Drawing.Point(0, 0);
      this.BooksList.Name = "BooksList";
      this.BooksList.ReadOnly = true;
      this.BooksList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.BooksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.BooksList.Size = new System.Drawing.Size(549, 304);
      this.BooksList.TabIndex = 11;
      this.BooksList.SelectionChanged += new System.EventHandler(this.BooksList_SelectionChanged_1);
      this.BooksList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BooksList_MouseDown);
      // 
      // Book
      // 
      this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Book.FillWeight = 197.9695F;
      this.Book.HeaderText = "Название";
      this.Book.Name = "Book";
      this.Book.ReadOnly = true;
      this.Book.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // Author
      // 
      this.Author.FillWeight = 126.8967F;
      this.Author.HeaderText = "Автор";
      this.Author.Name = "Author";
      this.Author.ReadOnly = true;
      // 
      // Genre
      // 
      this.Genre.FillWeight = 105.2135F;
      this.Genre.HeaderText = "Жанр";
      this.Genre.Name = "Genre";
      this.Genre.ReadOnly = true;
      // 
      // Price
      // 
      this.Price.FillWeight = 64.01565F;
      this.Price.HeaderText = "Цена (руб.)";
      this.Price.Name = "Price";
      this.Price.ReadOnly = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(551, 41);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(551, 41);
      this.label1.TabIndex = 0;
      this.label1.Text = "База книг";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // splitContainer3
      // 
      this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.Location = new System.Drawing.Point(0, 41);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.userFindText);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.UsersList);
      this.splitContainer3.Size = new System.Drawing.Size(287, 353);
      this.splitContainer3.SplitterDistance = 46;
      this.splitContainer3.SplitterWidth = 1;
      this.splitContainer3.TabIndex = 1;
      // 
      // userFindText
      // 
      this.userFindText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.userFindText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.userFindText.Location = new System.Drawing.Point(0, 0);
      this.userFindText.Multiline = true;
      this.userFindText.Name = "userFindText";
      this.userFindText.Size = new System.Drawing.Size(285, 44);
      this.userFindText.TabIndex = 0;
      this.userFindText.Text = "Поиск";
      this.userFindText.TextChanged += new System.EventHandler(this.userFindText_TextChanged_1);
      this.userFindText.Enter += new System.EventHandler(this.userFindText_Enter);
      // 
      // UsersList
      // 
      this.UsersList.AllowDrop = true;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
      this.UsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
      this.UsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.UsersList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
      this.UsersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.UsersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.UsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.UsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLogin,
            this.userType});
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.UsersList.DefaultCellStyle = dataGridViewCellStyle7;
      this.UsersList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsersList.GridColor = System.Drawing.SystemColors.Desktop;
      this.UsersList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.UsersList.Location = new System.Drawing.Point(0, 0);
      this.UsersList.Name = "UsersList";
      this.UsersList.ReadOnly = true;
      this.UsersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.UsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
      this.UsersList.Size = new System.Drawing.Size(285, 304);
      this.UsersList.TabIndex = 13;
      this.UsersList.SelectionChanged += new System.EventHandler(this.UsersList_SelectionChanged_1);
      this.UsersList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UsersList_MouseDown);
      // 
      // userLogin
      // 
      this.userLogin.FillWeight = 118.7817F;
      this.userLogin.HeaderText = "Логин пользователя";
      this.userLogin.Name = "userLogin";
      this.userLogin.ReadOnly = true;
      // 
      // userType
      // 
      this.userType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.userType.FillWeight = 81.21828F;
      this.userType.HeaderText = "Тип доступа";
      this.userType.Name = "userType";
      this.userType.ReadOnly = true;
      this.userType.Width = 78;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(287, 41);
      this.panel2.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(287, 41);
      this.label2.TabIndex = 1;
      this.label2.Text = "База пользователей";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // addToBase
      // 
      this.addToBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВБазуToolStripMenuItem});
      this.addToBase.Location = new System.Drawing.Point(0, 0);
      this.addToBase.Name = "addToBase";
      this.addToBase.Size = new System.Drawing.Size(847, 24);
      this.addToBase.TabIndex = 3;
      this.addToBase.Text = "Добавить в базу";
      // 
      // добавитьВБазуToolStripMenuItem
      // 
      this.добавитьВБазуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBook,
            this.addUser});
      this.добавитьВБазуToolStripMenuItem.Name = "добавитьВБазуToolStripMenuItem";
      this.добавитьВБазуToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
      this.добавитьВБазуToolStripMenuItem.Text = "Добавить в базу";
      // 
      // addBook
      // 
      this.addBook.Name = "addBook";
      this.addBook.Size = new System.Drawing.Size(151, 22);
      this.addBook.Text = "Книгу";
      this.addBook.Click += new System.EventHandler(this.addBook_Click);
      // 
      // addUser
      // 
      this.addUser.Name = "addUser";
      this.addUser.Size = new System.Drawing.Size(151, 22);
      this.addUser.Text = "Пользователя";
      this.addUser.Click += new System.EventHandler(this.addUser_Click);
      // 
      // changeData
      // 
      this.changeData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editData,
            this.deleteData});
      this.changeData.Name = "changeData";
      this.changeData.Size = new System.Drawing.Size(129, 48);
      // 
      // editData
      // 
      this.editData.Name = "editData";
      this.editData.Size = new System.Drawing.Size(128, 22);
      this.editData.Text = "Изменить";
      this.editData.Click += new System.EventHandler(this.editData_Click);
      // 
      // deleteData
      // 
      this.deleteData.Name = "deleteData";
      this.deleteData.Size = new System.Drawing.Size(128, 22);
      this.deleteData.Text = "Удалить";
      this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
      // 
      // AdminBaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(847, 463);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.addToBase);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(612, 232);
      this.Name = "AdminBaseForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.Activated += new System.EventHandler(this.AdminBaseForm_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminBaseForm_FormClosed);
      this.panel3.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).EndInit();
      this.panel1.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel1.PerformLayout();
      this.splitContainer3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
      this.splitContainer3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
      this.panel2.ResumeLayout(false);
      this.addToBase.ResumeLayout(false);
      this.addToBase.PerformLayout();
      this.changeData.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MenuStrip addToBase;
    private System.Windows.Forms.ToolStripMenuItem добавитьВБазуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addBook;
    private System.Windows.Forms.ToolStripMenuItem addUser;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.TextBox bookFindText;
    private System.Windows.Forms.DataGridView BooksList;
    private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.DataGridView UsersList;
    private System.Windows.Forms.DataGridViewTextBoxColumn userLogin;
    private System.Windows.Forms.DataGridViewTextBoxColumn userType;
    private System.Windows.Forms.TextBox userFindText;
    private System.Windows.Forms.ContextMenuStrip changeData;
    private System.Windows.Forms.ToolStripMenuItem editData;
    private System.Windows.Forms.ToolStripMenuItem deleteData;
  }
}