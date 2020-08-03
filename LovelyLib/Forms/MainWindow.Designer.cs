namespace LovelyLib
{
  partial class MainWindow
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.filterButton = new System.Windows.Forms.Button();
      this.basketButton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.infoButton = new System.Windows.Forms.Button();
      this.addButton = new System.Windows.Forms.Button();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.BooksList = new System.Windows.Forms.DataGridView();
      this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this._Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.exitButton = new System.Windows.Forms.Button();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.currentUserText = new System.Windows.Forms.Label();
      this.libNameText = new System.Windows.Forms.Label();
      this.BookInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.FileDialog = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveAsDialog = new System.Windows.Forms.ToolStripMenuItem();
      this.readCsvFile = new System.Windows.Forms.ToolStripMenuItem();
      this.saveCsvFile = new System.Windows.Forms.ToolStripMenuItem();
      this.PrintDialog = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      this.BookInfo.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Linen;
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.AutoScroll = true;
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(1017, 335);
      this.splitContainer1.SplitterDistance = 80;
      this.splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Controls.Add(this.filterButton, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.basketButton, 4, 0);
      this.tableLayoutPanel1.Controls.Add(this.deleteButton, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.infoButton, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 80);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // filterButton
      // 
      this.filterButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.filterButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.filterButton.Image = global::LovelyLib.Properties.Resources.filter;
      this.filterButton.Location = new System.Drawing.Point(206, 3);
      this.filterButton.Name = "filterButton";
      this.filterButton.Size = new System.Drawing.Size(197, 74);
      this.filterButton.TabIndex = 6;
      this.filterButton.Text = "Фильтр";
      this.filterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.filterButton.UseVisualStyleBackColor = true;
      this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
      // 
      // basketButton
      // 
      this.basketButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.basketButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.basketButton.Image = global::LovelyLib.Properties.Resources.basket;
      this.basketButton.Location = new System.Drawing.Point(815, 3);
      this.basketButton.Name = "basketButton";
      this.basketButton.Size = new System.Drawing.Size(199, 74);
      this.basketButton.TabIndex = 4;
      this.basketButton.Text = "Корзина";
      this.basketButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.basketButton.UseVisualStyleBackColor = true;
      this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.deleteButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.deleteButton.Image = global::LovelyLib.Properties.Resources.delete_book;
      this.deleteButton.Location = new System.Drawing.Point(612, 3);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(197, 74);
      this.deleteButton.TabIndex = 3;
      this.deleteButton.Text = "Удалить книгу";
      this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.delButton_Click);
      // 
      // infoButton
      // 
      this.infoButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.infoButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.infoButton.Image = global::LovelyLib.Properties.Resources.lupa;
      this.infoButton.Location = new System.Drawing.Point(409, 3);
      this.infoButton.Name = "infoButton";
      this.infoButton.Size = new System.Drawing.Size(197, 74);
      this.infoButton.TabIndex = 2;
      this.infoButton.Text = "Информация";
      this.infoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.infoButton.UseVisualStyleBackColor = true;
      this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
      // 
      // addButton
      // 
      this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.addButton.Image = global::LovelyLib.Properties.Resources.add_book;
      this.addButton.Location = new System.Drawing.Point(3, 3);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(197, 74);
      this.addButton.TabIndex = 0;
      this.addButton.Text = "Добавить книгу";
      this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.IsSplitterFixed = true;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.BooksList);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SeaShell;
      this.splitContainer2.Panel2.Controls.Add(this.exitButton);
      this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
      this.splitContainer2.Size = new System.Drawing.Size(1017, 251);
      this.splitContainer2.SplitterDistance = 208;
      this.splitContainer2.TabIndex = 0;
      // 
      // BooksList
      // 
      this.BooksList.AllowDrop = true;
      this.BooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.BooksList.BackgroundColor = System.Drawing.Color.LemonChiffon;
      this.BooksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.BooksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.BooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Author,
            this.Genre,
            this.Price,
            this.Date,
            this._Size});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.BooksList.DefaultCellStyle = dataGridViewCellStyle2;
      this.BooksList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BooksList.GridColor = System.Drawing.SystemColors.Desktop;
      this.BooksList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BooksList.Location = new System.Drawing.Point(0, 0);
      this.BooksList.Name = "BooksList";
      this.BooksList.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.BooksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.BooksList.Size = new System.Drawing.Size(1017, 208);
      this.BooksList.TabIndex = 6;
      this.BooksList.SelectionChanged += new System.EventHandler(this.BooksList_SelectionChanged);
      this.BooksList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BooksList_MouseDown);
      // 
      // Book
      // 
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
      // Date
      // 
      this.Date.FillWeight = 54.9104F;
      this.Date.HeaderText = "Дата";
      this.Date.Name = "Date";
      this.Date.ReadOnly = true;
      // 
      // _Size
      // 
      this._Size.FillWeight = 50.99411F;
      this._Size.HeaderText = "Размер (байт)";
      this._Size.Name = "_Size";
      this._Size.ReadOnly = true;
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.BackColor = System.Drawing.Color.LightCoral;
      this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.exitButton.Location = new System.Drawing.Point(923, 6);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(82, 27);
      this.exitButton.TabIndex = 9;
      this.exitButton.Text = "Выход";
      this.exitButton.UseVisualStyleBackColor = false;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // splitContainer3
      // 
      this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Left;
      this.splitContainer3.Location = new System.Drawing.Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.currentUserText);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.libNameText);
      this.splitContainer3.Size = new System.Drawing.Size(492, 39);
      this.splitContainer3.SplitterDistance = 239;
      this.splitContainer3.TabIndex = 0;
      // 
      // currentUserText
      // 
      this.currentUserText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.currentUserText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.currentUserText.Location = new System.Drawing.Point(0, 0);
      this.currentUserText.Name = "currentUserText";
      this.currentUserText.Size = new System.Drawing.Size(237, 37);
      this.currentUserText.TabIndex = 2;
      this.currentUserText.Text = "UserType";
      this.currentUserText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // libNameText
      // 
      this.libNameText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.libNameText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.libNameText.Location = new System.Drawing.Point(0, 0);
      this.libNameText.Name = "libNameText";
      this.libNameText.Size = new System.Drawing.Size(247, 37);
      this.libNameText.TabIndex = 0;
      this.libNameText.Text = "LibName";
      this.libNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // BookInfo
      // 
      this.BookInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.BookInfo.Name = "BookInfo";
      this.BookInfo.Size = new System.Drawing.Size(137, 26);
      this.BookInfo.Click += new System.EventHandler(this.BookInfo_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
      this.toolStripMenuItem1.Text = "Подробнее";
      // 
      // FileDialog
      // 
      this.FileDialog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsDialog,
            this.readCsvFile,
            this.saveCsvFile,
            this.PrintDialog});
      this.FileDialog.Name = "FileDialog";
      this.FileDialog.Size = new System.Drawing.Size(48, 20);
      this.FileDialog.Text = "Файл";
      // 
      // SaveAsDialog
      // 
      this.SaveAsDialog.Name = "SaveAsDialog";
      this.SaveAsDialog.Size = new System.Drawing.Size(180, 22);
      this.SaveAsDialog.Text = "Сохранить";
      this.SaveAsDialog.Click += new System.EventHandler(this.SaveAsDialog_Click);
      // 
      // readCsvFile
      // 
      this.readCsvFile.Name = "readCsvFile";
      this.readCsvFile.Size = new System.Drawing.Size(180, 22);
      this.readCsvFile.Text = "Открыть CSV";
      this.readCsvFile.Click += new System.EventHandler(this.readCsvFile_Click);
      // 
      // saveCsvFile
      // 
      this.saveCsvFile.Name = "saveCsvFile";
      this.saveCsvFile.Size = new System.Drawing.Size(180, 22);
      this.saveCsvFile.Text = "Сохранить CSV";
      this.saveCsvFile.Click += new System.EventHandler(this.saveCsvFile_Click);
      // 
      // PrintDialog
      // 
      this.PrintDialog.Name = "PrintDialog";
      this.PrintDialog.Size = new System.Drawing.Size(180, 22);
      this.PrintDialog.Text = "Печать";
      this.PrintDialog.Click += new System.EventHandler(this.PrintDialog_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDialog});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(221)))), ((int)(((byte)(149)))));
      this.ClientSize = new System.Drawing.Size(1017, 359);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(614, 358);
      this.Name = "MainWindow";
      this.Text = "LovelyLib";
      this.Activated += new System.EventHandler(this.MainWindow_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).EndInit();
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
      this.splitContainer3.ResumeLayout(false);
      this.BookInfo.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Label currentUserText;
    private System.Windows.Forms.Label libNameText;
    private System.Windows.Forms.DataGridView BooksList;
    private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    private System.Windows.Forms.DataGridViewTextBoxColumn _Size;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button basketButton;
    private System.Windows.Forms.Button infoButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button filterButton;
    private System.Windows.Forms.ContextMenuStrip BookInfo;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.ToolStripMenuItem FileDialog;
    private System.Windows.Forms.ToolStripMenuItem SaveAsDialog;
    private System.Windows.Forms.ToolStripMenuItem PrintDialog;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem readCsvFile;
    private System.Windows.Forms.ToolStripMenuItem saveCsvFile;
  }
}