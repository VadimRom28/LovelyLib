namespace LovelyLib
{
  partial class OrderForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.orderButton = new System.Windows.Forms.Button();
      this.backButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.phoneNumberText = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.dateBox = new System.Windows.Forms.DateTimePicker();
      this.firstNameText = new System.Windows.Forms.TextBox();
      this.secondNameText = new System.Windows.Forms.TextBox();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.splitContainer4 = new System.Windows.Forms.SplitContainer();
      this.label7 = new System.Windows.Forms.Label();
      this.BooksList = new System.Windows.Forms.DataGridView();
      this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.totalPriceText = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
      this.splitContainer4.Panel1.SuspendLayout();
      this.splitContainer4.Panel2.SuspendLayout();
      this.splitContainer4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.orderButton);
      this.panel1.Controls.Add(this.backButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 353);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(720, 41);
      this.panel1.TabIndex = 1;
      // 
      // orderButton
      // 
      this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.orderButton.BackColor = System.Drawing.Color.LightSteelBlue;
      this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.orderButton.Location = new System.Drawing.Point(626, 6);
      this.orderButton.Name = "orderButton";
      this.orderButton.Size = new System.Drawing.Size(82, 29);
      this.orderButton.TabIndex = 11;
      this.orderButton.Text = "Заказать";
      this.orderButton.UseVisualStyleBackColor = false;
      this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
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
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(720, 51);
      this.label1.TabIndex = 2;
      this.label1.Text = "Оформление заказа";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 51);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
      this.splitContainer1.Size = new System.Drawing.Size(720, 302);
      this.splitContainer1.SplitterDistance = 87;
      this.splitContainer1.TabIndex = 3;
      // 
      // splitContainer2
      // 
      this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.IsSplitterFixed = true;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.label2);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
      this.splitContainer2.Size = new System.Drawing.Size(720, 87);
      this.splitContainer2.SplitterDistance = 25;
      this.splitContainer2.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Beige;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(718, 23);
      this.label2.TabIndex = 0;
      this.label2.Text = "Детали оплаты";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label2.UseMnemonic = false;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.Beige;
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.phoneNumberText, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.dateBox, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.firstNameText, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.secondNameText, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 56);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // phoneNumberText
      // 
      this.phoneNumberText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.phoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.phoneNumberText.Location = new System.Drawing.Point(541, 4);
      this.phoneNumberText.Mask = "+7 (999) 000-0000";
      this.phoneNumberText.Name = "phoneNumberText";
      this.phoneNumberText.Size = new System.Drawing.Size(173, 22);
      this.phoneNumberText.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(4, 1);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(172, 26);
      this.label3.TabIndex = 0;
      this.label3.Text = "Имя:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(4, 28);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(172, 27);
      this.label4.TabIndex = 1;
      this.label4.Text = "Фамилия:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(362, 1);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(172, 26);
      this.label5.TabIndex = 2;
      this.label5.Text = "Моб. телефон:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label6
      // 
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(362, 28);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(172, 27);
      this.label6.TabIndex = 3;
      this.label6.Text = "Дата:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dateBox
      // 
      this.dateBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dateBox.Location = new System.Drawing.Point(541, 31);
      this.dateBox.Name = "dateBox";
      this.dateBox.Size = new System.Drawing.Size(173, 22);
      this.dateBox.TabIndex = 5;
      // 
      // firstNameText
      // 
      this.firstNameText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.firstNameText.Location = new System.Drawing.Point(183, 4);
      this.firstNameText.Name = "firstNameText";
      this.firstNameText.Size = new System.Drawing.Size(172, 22);
      this.firstNameText.TabIndex = 8;
      // 
      // secondNameText
      // 
      this.secondNameText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.secondNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.secondNameText.Location = new System.Drawing.Point(183, 31);
      this.secondNameText.Name = "secondNameText";
      this.secondNameText.Size = new System.Drawing.Size(172, 22);
      this.secondNameText.TabIndex = 9;
      // 
      // splitContainer3
      // 
      this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.IsSplitterFixed = true;
      this.splitContainer3.Location = new System.Drawing.Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Beige;
      this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel2);
      this.splitContainer3.Size = new System.Drawing.Size(720, 211);
      this.splitContainer3.SplitterDistance = 175;
      this.splitContainer3.TabIndex = 0;
      // 
      // splitContainer4
      // 
      this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer4.IsSplitterFixed = true;
      this.splitContainer4.Location = new System.Drawing.Point(0, 0);
      this.splitContainer4.Name = "splitContainer4";
      this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer4.Panel1
      // 
      this.splitContainer4.Panel1.Controls.Add(this.label7);
      // 
      // splitContainer4.Panel2
      // 
      this.splitContainer4.Panel2.Controls.Add(this.BooksList);
      this.splitContainer4.Size = new System.Drawing.Size(720, 175);
      this.splitContainer4.SplitterDistance = 25;
      this.splitContainer4.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.Color.Beige;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(0, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(718, 23);
      this.label7.TabIndex = 0;
      this.label7.Text = "Ваш заказ";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label7.UseMnemonic = false;
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
      this.BooksList.BackgroundColor = System.Drawing.Color.Beige;
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
      this.BooksList.Size = new System.Drawing.Size(718, 144);
      this.BooksList.TabIndex = 7;
      this.BooksList.SelectionChanged += new System.EventHandler(this.BooksList_SelectionChanged);
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
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.totalPriceText, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(530, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 30);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // label8
      // 
      this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(4, 1);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(86, 28);
      this.label8.TabIndex = 0;
      this.label8.Text = "Итого: ";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // totalPriceText
      // 
      this.totalPriceText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.totalPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.totalPriceText.Location = new System.Drawing.Point(97, 4);
      this.totalPriceText.Multiline = true;
      this.totalPriceText.Name = "totalPriceText";
      this.totalPriceText.ReadOnly = true;
      this.totalPriceText.Size = new System.Drawing.Size(87, 22);
      this.totalPriceText.TabIndex = 1;
      this.totalPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // OrderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(720, 394);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(1002, 466);
      this.MinimumSize = new System.Drawing.Size(458, 433);
      this.Name = "OrderForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
      this.splitContainer3.ResumeLayout(false);
      this.splitContainer4.Panel1.ResumeLayout(false);
      this.splitContainer4.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
      this.splitContainer4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksList)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.SplitContainer splitContainer4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView BooksList;
    private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox totalPriceText;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.MaskedTextBox phoneNumberText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker dateBox;
    private System.Windows.Forms.TextBox firstNameText;
    private System.Windows.Forms.TextBox secondNameText;
    private System.Windows.Forms.Button orderButton;
  }
}