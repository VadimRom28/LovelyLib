namespace LovelyLib
{
  partial class InfoLibForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoLibForm));
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.backButton = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.genresButton = new System.Windows.Forms.RadioButton();
      this.authorsButton = new System.Windows.Forms.RadioButton();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.dataFilter = new System.Windows.Forms.CheckBox();
      this.dataBox = new System.Windows.Forms.DateTimePicker();
      this.booksButton = new System.Windows.Forms.RadioButton();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.currentSumText = new System.Windows.Forms.Label();
      this.booksList = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(793, 51);
      this.label1.TabIndex = 2;
      this.label1.Text = "Информация о библиотеке";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.backButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 296);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(793, 41);
      this.panel1.TabIndex = 3;
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
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 51);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(793, 245);
      this.splitContainer1.SplitterDistance = 202;
      this.splitContainer1.TabIndex = 4;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.genresButton, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.authorsButton, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.booksButton, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 243);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // genresButton
      // 
      this.genresButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.genresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.genresButton.Location = new System.Drawing.Point(4, 124);
      this.genresButton.Name = "genresButton";
      this.genresButton.Size = new System.Drawing.Size(192, 53);
      this.genresButton.TabIndex = 3;
      this.genresButton.TabStop = true;
      this.genresButton.Text = "Жанры";
      this.genresButton.UseVisualStyleBackColor = true;
      this.genresButton.CheckedChanged += new System.EventHandler(this.genresButton_CheckedChanged);
      // 
      // authorsButton
      // 
      this.authorsButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.authorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.authorsButton.Location = new System.Drawing.Point(4, 64);
      this.authorsButton.Name = "authorsButton";
      this.authorsButton.Size = new System.Drawing.Size(192, 53);
      this.authorsButton.TabIndex = 2;
      this.authorsButton.TabStop = true;
      this.authorsButton.Text = "Авторы";
      this.authorsButton.UseVisualStyleBackColor = true;
      this.authorsButton.CheckedChanged += new System.EventHandler(this.authorsButton_CheckedChanged);
      // 
      // splitContainer3
      // 
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.Location = new System.Drawing.Point(4, 184);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.dataFilter);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.dataBox);
      this.splitContainer3.Size = new System.Drawing.Size(192, 55);
      this.splitContainer3.SplitterDistance = 26;
      this.splitContainer3.TabIndex = 4;
      // 
      // dataFilter
      // 
      this.dataFilter.AutoSize = true;
      this.dataFilter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataFilter.Location = new System.Drawing.Point(0, 0);
      this.dataFilter.Name = "dataFilter";
      this.dataFilter.Size = new System.Drawing.Size(192, 26);
      this.dataFilter.TabIndex = 0;
      this.dataFilter.Text = "Фильтр по дате";
      this.dataFilter.UseVisualStyleBackColor = true;
      this.dataFilter.CheckedChanged += new System.EventHandler(this.dataFilter_CheckedChanged);
      // 
      // dataBox
      // 
      this.dataBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataBox.Location = new System.Drawing.Point(0, 0);
      this.dataBox.Name = "dataBox";
      this.dataBox.Size = new System.Drawing.Size(192, 24);
      this.dataBox.TabIndex = 0;
      this.dataBox.ValueChanged += new System.EventHandler(this.dataBox_ValueChanged);
      // 
      // booksButton
      // 
      this.booksButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.booksButton.Location = new System.Drawing.Point(4, 4);
      this.booksButton.Name = "booksButton";
      this.booksButton.Size = new System.Drawing.Size(192, 53);
      this.booksButton.TabIndex = 5;
      this.booksButton.TabStop = true;
      this.booksButton.Text = "Книги";
      this.booksButton.UseVisualStyleBackColor = true;
      this.booksButton.CheckedChanged += new System.EventHandler(this.booksButton_CheckedChanged_1);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.currentSumText);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.booksList);
      this.splitContainer2.Size = new System.Drawing.Size(585, 243);
      this.splitContainer2.SplitterDistance = 25;
      this.splitContainer2.TabIndex = 0;
      // 
      // currentSumText
      // 
      this.currentSumText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.currentSumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.currentSumText.Location = new System.Drawing.Point(0, 0);
      this.currentSumText.Name = "currentSumText";
      this.currentSumText.Size = new System.Drawing.Size(585, 25);
      this.currentSumText.TabIndex = 0;
      this.currentSumText.Text = "Всего: ";
      this.currentSumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // booksList
      // 
      this.booksList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.booksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.booksList.FormattingEnabled = true;
      this.booksList.ItemHeight = 18;
      this.booksList.Location = new System.Drawing.Point(0, 0);
      this.booksList.Name = "booksList";
      this.booksList.Size = new System.Drawing.Size(585, 214);
      this.booksList.TabIndex = 1;
      // 
      // InfoLibForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(793, 337);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "InfoLibForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel1.PerformLayout();
      this.splitContainer3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
      this.splitContainer3.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.RadioButton genresButton;
    private System.Windows.Forms.RadioButton authorsButton;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.CheckBox dataFilter;
    private System.Windows.Forms.DateTimePicker dataBox;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Label currentSumText;
    private System.Windows.Forms.ListBox booksList;
    private System.Windows.Forms.RadioButton booksButton;
  }
}