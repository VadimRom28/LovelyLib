namespace LovelyLib
{
  partial class FilterForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.applyButton = new System.Windows.Forms.Button();
      this.backButton = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.costBookUpper = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.costBookLower = new System.Windows.Forms.ComboBox();
      this.genresList = new System.Windows.Forms.CheckedListBox();
      this.authorsList = new System.Windows.Forms.CheckedListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.booksList = new System.Windows.Forms.CheckedListBox();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FloralWhite;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(758, 51);
      this.label1.TabIndex = 2;
      this.label1.Text = "Фильтр";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.applyButton);
      this.panel1.Controls.Add(this.backButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 302);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(758, 41);
      this.panel1.TabIndex = 3;
      // 
      // applyButton
      // 
      this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.applyButton.BackColor = System.Drawing.Color.White;
      this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.applyButton.Location = new System.Drawing.Point(664, 6);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(82, 29);
      this.applyButton.TabIndex = 11;
      this.applyButton.Text = "Применить";
      this.applyButton.UseVisualStyleBackColor = false;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
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
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.genresList, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.authorsList, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.booksList, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.31873F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.68127F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 251);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.costBookUpper, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.costBookLower, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(570, 58);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.278351F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.72165F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(182, 187);
      this.tableLayoutPanel2.TabIndex = 10;
      // 
      // costBookUpper
      // 
      this.costBookUpper.BackColor = System.Drawing.SystemColors.Control;
      this.costBookUpper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.costBookUpper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.costBookUpper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.costBookUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.costBookUpper.FormattingEnabled = true;
      this.costBookUpper.Location = new System.Drawing.Point(94, 22);
      this.costBookUpper.Name = "costBookUpper";
      this.costBookUpper.Size = new System.Drawing.Size(84, 26);
      this.costBookUpper.TabIndex = 3;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(94, 1);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(84, 17);
      this.label7.TabIndex = 1;
      this.label7.Text = "До:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(4, 1);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(83, 17);
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
      this.costBookLower.Location = new System.Drawing.Point(4, 22);
      this.costBookLower.Name = "costBookLower";
      this.costBookLower.Size = new System.Drawing.Size(83, 26);
      this.costBookLower.TabIndex = 2;
      // 
      // genresList
      // 
      this.genresList.CheckOnClick = true;
      this.genresList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.genresList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.genresList.FormattingEnabled = true;
      this.genresList.Location = new System.Drawing.Point(382, 58);
      this.genresList.Name = "genresList";
      this.genresList.Size = new System.Drawing.Size(179, 187);
      this.genresList.TabIndex = 8;
      this.genresList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.genresList_MouseUp);
      // 
      // authorsList
      // 
      this.authorsList.CheckOnClick = true;
      this.authorsList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.authorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.authorsList.FormattingEnabled = true;
      this.authorsList.Location = new System.Drawing.Point(194, 58);
      this.authorsList.Name = "authorsList";
      this.authorsList.Size = new System.Drawing.Size(179, 187);
      this.authorsList.TabIndex = 7;
      this.authorsList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.authorsList_MouseUp);
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(179, 49);
      this.label2.TabIndex = 2;
      this.label2.Text = "Книги:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(194, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(179, 49);
      this.label3.TabIndex = 3;
      this.label3.Text = "Авторы:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(382, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(179, 49);
      this.label4.TabIndex = 4;
      this.label4.Text = "Жанры:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(570, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(182, 49);
      this.label5.TabIndex = 5;
      this.label5.Text = "Ценовой диапазон:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // booksList
      // 
      this.booksList.CheckOnClick = true;
      this.booksList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.booksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.booksList.FormattingEnabled = true;
      this.booksList.Location = new System.Drawing.Point(6, 58);
      this.booksList.Name = "booksList";
      this.booksList.Size = new System.Drawing.Size(179, 187);
      this.booksList.TabIndex = 6;
      this.booksList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.booksList_MouseUp);
      // 
      // FilterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LemonChiffon;
      this.ClientSize = new System.Drawing.Size(758, 343);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FilterForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LovelyLib";
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button applyButton;
    private System.Windows.Forms.Button backButton;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.CheckedListBox genresList;
    private System.Windows.Forms.CheckedListBox authorsList;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckedListBox booksList;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.ComboBox costBookUpper;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox costBookLower;
  }
}