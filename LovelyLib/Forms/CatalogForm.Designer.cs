namespace LovelyLib
{
  partial class CatalogForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.genreBookList = new System.Windows.Forms.ComboBox();
      this.authorBookList = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.nameBookList = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.costBookUpper = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.costBookLower = new System.Windows.Forms.ComboBox();
      this.BooksList = new System.Windows.Forms.DataGridView();
      this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.backButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.addButton = new System.Windows.Forms.Button();
      this.BookInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).BeginInit();
      this.panel1.SuspendLayout();
      this.BookInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(982, 51);
      this.label1.TabIndex = 1;
      this.label1.Text = "Каталог книг";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 51);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.BooksList);
      this.splitContainer1.Size = new System.Drawing.Size(982, 280);
      this.splitContainer1.SplitterDistance = 300;
      this.splitContainer1.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.73771F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.2623F));
      this.tableLayoutPanel1.Controls.Add(this.genreBookList, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.authorBookList, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.nameBookList, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 280);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // genreBookList
      // 
      this.genreBookList.BackColor = System.Drawing.SystemColors.Control;
      this.genreBookList.Dock = System.Windows.Forms.DockStyle.Top;
      this.genreBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.genreBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.genreBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.genreBookList.FormattingEnabled = true;
      this.genreBookList.Location = new System.Drawing.Point(98, 144);
      this.genreBookList.Name = "genreBookList";
      this.genreBookList.Size = new System.Drawing.Size(196, 26);
      this.genreBookList.TabIndex = 6;
      this.genreBookList.SelectedIndexChanged += new System.EventHandler(this.genreBookList_SelectedIndexChanged);
      // 
      // authorBookList
      // 
      this.authorBookList.BackColor = System.Drawing.SystemColors.Control;
      this.authorBookList.Dock = System.Windows.Forms.DockStyle.Top;
      this.authorBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.authorBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.authorBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.authorBookList.FormattingEnabled = true;
      this.authorBookList.Location = new System.Drawing.Point(98, 75);
      this.authorBookList.Name = "authorBookList";
      this.authorBookList.Size = new System.Drawing.Size(196, 26);
      this.authorBookList.TabIndex = 5;
      this.authorBookList.SelectedIndexChanged += new System.EventHandler(this.authorBookList_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 66);
      this.label3.TabIndex = 2;
      this.label3.Text = "Автор:";
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 66);
      this.label2.TabIndex = 1;
      this.label2.Text = "Название:";
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(6, 141);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 66);
      this.label4.TabIndex = 3;
      this.label4.Text = "Жанр:";
      // 
      // nameBookList
      // 
      this.nameBookList.BackColor = System.Drawing.SystemColors.Control;
      this.nameBookList.Dock = System.Windows.Forms.DockStyle.Top;
      this.nameBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.nameBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.nameBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.nameBookList.FormattingEnabled = true;
      this.nameBookList.Location = new System.Drawing.Point(98, 6);
      this.nameBookList.Name = "nameBookList";
      this.nameBookList.Size = new System.Drawing.Size(196, 26);
      this.nameBookList.TabIndex = 0;
      this.nameBookList.SelectedIndexChanged += new System.EventHandler(this.nameBookList_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label5);
      this.panel2.Location = new System.Drawing.Point(6, 213);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(61, 46);
      this.panel2.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(61, 46);
      this.label5.TabIndex = 1;
      this.label5.Text = "Цена:";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.costBookUpper, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.costBookLower, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(98, 213);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.86885F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.13115F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 61);
      this.tableLayoutPanel2.TabIndex = 9;
      // 
      // costBookUpper
      // 
      this.costBookUpper.BackColor = System.Drawing.SystemColors.Control;
      this.costBookUpper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.costBookUpper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.costBookUpper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.costBookUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.costBookUpper.FormattingEnabled = true;
      this.costBookUpper.Location = new System.Drawing.Point(101, 19);
      this.costBookUpper.Name = "costBookUpper";
      this.costBookUpper.Size = new System.Drawing.Size(92, 26);
      this.costBookUpper.TabIndex = 3;
      this.costBookUpper.SelectedIndexChanged += new System.EventHandler(this.costBookUpper_SelectedIndexChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(101, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(92, 16);
      this.label7.TabIndex = 1;
      this.label7.Text = "До:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(3, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(92, 16);
      this.label6.TabIndex = 0;
      this.label6.Text = "От:";
      // 
      // costBookLower
      // 
      this.costBookLower.BackColor = System.Drawing.SystemColors.Control;
      this.costBookLower.Dock = System.Windows.Forms.DockStyle.Fill;
      this.costBookLower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.costBookLower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.costBookLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.costBookLower.FormattingEnabled = true;
      this.costBookLower.Location = new System.Drawing.Point(3, 19);
      this.costBookLower.Name = "costBookLower";
      this.costBookLower.Size = new System.Drawing.Size(92, 26);
      this.costBookLower.TabIndex = 2;
      this.costBookLower.SelectedIndexChanged += new System.EventHandler(this.costBookLower_SelectedIndexChanged);
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
      this.BooksList.BackgroundColor = System.Drawing.Color.LemonChiffon;
      this.BooksList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.BooksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
      this.BooksList.Size = new System.Drawing.Size(678, 280);
      this.BooksList.TabIndex = 6;
      this.BooksList.SelectionChanged += new System.EventHandler(this.BooksList_SelectionChanged);
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
      // backButton
      // 
      this.backButton.BackColor = System.Drawing.Color.White;
      this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.backButton.Location = new System.Drawing.Point(12, 6);
      this.backButton.Name = "backButton";
      this.backButton.Size = new System.Drawing.Size(82, 29);
      this.backButton.TabIndex = 0;
      this.backButton.Text = "Назад";
      this.backButton.UseVisualStyleBackColor = false;
      this.backButton.Click += new System.EventHandler(this.backButton_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.backButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 331);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(982, 41);
      this.panel1.TabIndex = 0;
      // 
      // addButton
      // 
      this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.addButton.BackColor = System.Drawing.Color.White;
      this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addButton.Location = new System.Drawing.Point(888, 6);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(82, 29);
      this.addButton.TabIndex = 10;
      this.addButton.Text = "Добавить";
      this.addButton.UseVisualStyleBackColor = false;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // BookInfo
      // 
      this.BookInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.BookInfo.Name = "BookInfo";
      this.BookInfo.Size = new System.Drawing.Size(118, 26);
      this.BookInfo.Click += new System.EventHandler(this.BookInfo_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
      this.toolStripMenuItem1.Text = "О книге";
      // 
      // CatalogForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(982, 372);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(998, 411);
      this.Name = "CatalogForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.Activated += new System.EventHandler(this.CatalogForm_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatalogForm_FormClosed);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).EndInit();
      this.panel1.ResumeLayout(false);
      this.BookInfo.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ComboBox genreBookList;
    private System.Windows.Forms.ComboBox authorBookList;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox nameBookList;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.ComboBox costBookUpper;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox costBookLower;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ContextMenuStrip BookInfo;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.DataGridView BooksList;
    private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.Button addButton;
  }
}