using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovelyLib
{
  public partial class InfoLibForm : Form
  {
    public InfoLibForm()
    {
      InitializeComponent();

      UpdateListBooks();
    }

    private void UpdateListBooks()
    {
      if (booksButton.Checked == true)
      {
        booksList.Items.Clear();
        List<Book> currentBooks = new List<Book>();
        currentBooks.AddRange(BooksBase.getBooksBase().getUserBooks(MainWindow.selectedUserLib.lib.id));

        foreach (var i in currentBooks)
        {
          if (!booksList.Items.Contains(i.name) && (dataFilter.Checked == true && i.date == dataBox.Value.ToShortDateString()
            || dataFilter.Checked == false))
          {
            booksList.Items.Add(i.name);
          }
        }

        currentSumText.Text = "Всего: " + booksList.Items.Count.ToString();
      }

      if (authorsButton.Checked == true)
      {
        booksList.Items.Clear();
        List<Book> currentBooks = new List<Book>();
        currentBooks.AddRange(BooksBase.getBooksBase().getUserBooks(MainWindow.selectedUserLib.lib.id));

        foreach (var i in currentBooks)
        {
          if (!booksList.Items.Contains(i.author) && (dataFilter.Checked == true && i.date == dataBox.Value.ToShortDateString()
            || dataFilter.Checked == false))
          {
            booksList.Items.Add(i.author);
          }
        }

        currentSumText.Text = "Всего: " + booksList.Items.Count.ToString();
      }

      if (genresButton.Checked == true)
      {
        booksList.Items.Clear();
        List<Book> currentBooks = new List<Book>();
        currentBooks.AddRange(BooksBase.getBooksBase().getUserBooks(MainWindow.selectedUserLib.lib.id));

        foreach (var i in currentBooks)
        {
          if (!booksList.Items.Contains(i.genre) && (dataFilter.Checked == true && i.date == dataBox.Value.ToShortDateString()
            || dataFilter.Checked == false))
          {
            booksList.Items.Add(i.genre);
          }
        }

        currentSumText.Text = "Всего: " + booksList.Items.Count.ToString();
      }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void authorsButton_CheckedChanged(object sender, EventArgs e)
    {
      UpdateListBooks();
    }

    private void genresButton_CheckedChanged(object sender, EventArgs e)
    {
      UpdateListBooks();
    }

    private void booksButton_CheckedChanged_1(object sender, EventArgs e)
    {
      UpdateListBooks();
    }

    private void dataFilter_CheckedChanged(object sender, EventArgs e)
    {
      UpdateListBooks();
    }

    private void dataBox_ValueChanged(object sender, EventArgs e)
    {
      if (dataFilter.Checked == true)
      {
        UpdateListBooks();
      }
    }
  }
}
