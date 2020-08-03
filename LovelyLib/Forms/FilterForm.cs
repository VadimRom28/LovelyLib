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
  public partial class FilterForm : Form
  {
    List<Book> allBooks = new List<Book>();
    public static List<Book> filterBooks = new List<Book>();

    public FilterForm()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;

      SetFilter();
    }

    private void SetFilter()
    {
      allBooks.Clear();
      allBooks.AddRange(MainWindow.ourBooks);
      List<int> prices = new List<int>();

      booksList.Items.Add("Все");
      authorsList.Items.Add("Все");
      genresList.Items.Add("Все");
      costBookLower.Items.Add("Любая");
      costBookUpper.Items.Add("Любая");

      foreach (var i in allBooks)
      {
        if (!booksList.Items.Contains(i.name))
        {
          booksList.Items.Add(i.name);
        }

        if (!authorsList.Items.Contains(i.author))
        {
          authorsList.Items.Add(i.author);
        }

        if (!genresList.Items.Contains(i.genre))
        {
          genresList.Items.Add(i.genre);
        }

        if (!prices.Contains(i.cost))
        {
          prices.Add(i.cost);
        }
      }

      prices.Sort();

      foreach (var i in prices)
      {
        costBookLower.Items.Add(i.ToString());
        costBookUpper.Items.Add(i.ToString());
      }

      for (int i = 0; i < booksList.Items.Count; i++)
      {
        booksList.SetItemChecked(i, true);
      }

      for (int i = 0; i < authorsList.Items.Count; i++)
      {
        authorsList.SetItemChecked(i, true);
      }

      for (int i = 0; i < genresList.Items.Count; i++)
      {
        genresList.SetItemChecked(i, true);
      }

      costBookLower.SelectedIndex = 0;
      costBookUpper.SelectedIndex = 0;
    }

    private void applyButton_Click(object sender, EventArgs e)
    {
      filterBooks.Clear();
      filterBooks.AddRange(allBooks);

      var bList = booksList.CheckedItems;
      if (!bList.Contains("Все"))
      {
        filterBooks = filterBooks.Where(s => bList.Contains(s.name)).ToList();
      }

      var aList = authorsList.CheckedItems;
      if (!aList.Contains("Все"))
      {
        filterBooks = filterBooks.Where(s => aList.Contains(s.author)).ToList();
      }

      var gList = genresList.CheckedItems;
      if (!gList.Contains("Все"))
      {
        filterBooks = filterBooks.Where(s => gList.Contains(s.genre)).ToList();
      }

      if (costBookLower.SelectedIndex != -1 && costBookLower.SelectedIndex != 0)
      {
        filterBooks = filterBooks.Where(b => b.cost >= Convert.ToInt32(costBookLower.SelectedItem.ToString())).ToList();
      }

      if (costBookUpper.SelectedIndex != -1 && costBookUpper.SelectedIndex != 0)
      {
        filterBooks = filterBooks.Where(b => b.cost <= Convert.ToInt32(costBookUpper.SelectedItem.ToString())).ToList();
      }

      this.Hide();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void booksList_MouseUp(object sender, MouseEventArgs e)
    {
      var nList = booksList.CheckedIndices;

      if (nList.Contains(0) && booksList.SelectedIndex == 0)
      {
        for (int i = 0; i < booksList.Items.Count; i++)
        {
          booksList.SetItemChecked(i, true);
        }
      }

      if (!nList.Contains(0) && booksList.SelectedIndex == 0)
      {
        for (int i = 0; i < booksList.Items.Count; i++)
        {
          booksList.SetItemChecked(i, false);
        }
      }

      if (nList.Count < booksList.Items.Count && nList.Contains(0))
      {
        booksList.SetItemChecked(0, false);
      }

      if (!nList.Contains(0) && nList.Count == booksList.Items.Count - 1)
      {
        booksList.SetItemChecked(0, true);
      }
    }

    private void authorsList_MouseUp(object sender, MouseEventArgs e)
    {
      var nList = authorsList.CheckedIndices;

      if (nList.Contains(0) && authorsList.SelectedIndex == 0)
      {
        for (int i = 0; i < authorsList.Items.Count; i++)
        {
          authorsList.SetItemChecked(i, true);
        }
      }

      if (!nList.Contains(0) && authorsList.SelectedIndex == 0)
      {
        for (int i = 0; i < authorsList.Items.Count; i++)
        {
          authorsList.SetItemChecked(i, false);
        }
      }

      if (nList.Count < authorsList.Items.Count && nList.Contains(0))
      {
        authorsList.SetItemChecked(0, false);
      }

      if (!nList.Contains(0) && nList.Count == authorsList.Items.Count - 1)
      {
        authorsList.SetItemChecked(0, true);
      }
    }

    private void genresList_MouseUp(object sender, MouseEventArgs e)
    {
      var nList = genresList.CheckedIndices;

      if (nList.Contains(0) && genresList.SelectedIndex == 0)
      {
        for (int i = 0; i < genresList.Items.Count; i++)
        {
          genresList.SetItemChecked(i, true);
        }
      }

      if (!nList.Contains(0) && genresList.SelectedIndex == 0)
      {
        for (int i = 0; i < genresList.Items.Count; i++)
        {
          genresList.SetItemChecked(i, false);
        }
      }

      if (nList.Count < genresList.Items.Count && nList.Contains(0))
      {
        genresList.SetItemChecked(0, false);
      }

      if (!nList.Contains(0) && nList.Count == genresList.Items.Count - 1)
      {
        genresList.SetItemChecked(0, true);
      }
    }
  }
}
