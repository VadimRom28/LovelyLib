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
  public partial class CatalogForm : Form
  {
    BooksBase booksBase = BooksBase.getBooksBase();
    List<Book> allBooks = new List<Book>();
    public static string bookName;

    public CatalogForm()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;

      if (LoginForm.userType == UserType.guest)
      {
        addButton.Visible = false;
      }
      else
      {
        addButton.Visible = true;
      }

      setBoxes();
    }

    private void setBoxes()
    {
      allBooks = booksBase.getAllBooks();
      List<int> prices = new List<int>();

      nameBookList.Items.Add("Все");
      authorBookList.Items.Add("Все");
      genreBookList.Items.Add("Все");
      costBookLower.Items.Add("Любая");
      costBookUpper.Items.Add("Любая");

      BooksList.RowCount = allBooks.Count + 1;
      for (int i = 0; i < BooksList.RowCount - 1; i++)
      {
        BooksList[0, i].Value = allBooks[i].name;
        if (!nameBookList.Items.Contains(allBooks[i].name))
        {
          nameBookList.Items.Add(allBooks[i].name);
        }

        BooksList[1, i].Value = allBooks[i].author;
        if (!authorBookList.Items.Contains(allBooks[i].author))
        {
          authorBookList.Items.Add(allBooks[i].author);
        }

        BooksList[2, i].Value = allBooks[i].genre;
        if (!genreBookList.Items.Contains(allBooks[i].genre))
        {
          genreBookList.Items.Add(allBooks[i].genre);
        }

        BooksList[3, i].Value = allBooks[i].cost;
        if (!prices.Contains(allBooks[i].cost))
        {
          prices.Add(allBooks[i].cost);
        }
      }

      prices.Sort();
      foreach(var i in prices)
      {
        costBookLower.Items.Add(i.ToString());
        costBookUpper.Items.Add(i.ToString());
      }

      nameBookList.SelectedIndex = 0;
      authorBookList.SelectedIndex = 0;
      genreBookList.SelectedIndex = 0;
      costBookLower.SelectedIndex = 0;
      costBookUpper.SelectedIndex = 0;

    }

    private void UpdatePanel()
    {
      List<Book> updateBooks = new List<Book>();
      updateBooks.AddRange(allBooks);

      if (nameBookList.SelectedIndex != -1 && nameBookList.SelectedIndex != 0)
      {
        updateBooks = updateBooks.Where(b => b.name.Contains(nameBookList.SelectedItem.ToString())).ToList();
      }

      if (authorBookList.SelectedIndex != -1 && authorBookList.SelectedIndex != 0)
      {
        updateBooks = updateBooks.Where(b => b.author.Contains(authorBookList.SelectedItem.ToString())).ToList();
      }

      if (genreBookList.SelectedIndex != -1 && genreBookList.SelectedIndex != 0)
      {
        updateBooks = updateBooks.Where(b => b.genre.Contains(genreBookList.SelectedItem.ToString())).ToList();
      }

      if (costBookLower.SelectedIndex != -1 && costBookLower.SelectedIndex != 0)
      {
        updateBooks = updateBooks.Where(b => b.cost >= Convert.ToInt32(costBookLower.SelectedItem.ToString())).ToList();
      }

      if (costBookUpper.SelectedIndex != -1 && costBookUpper.SelectedIndex != 0)
      {
        updateBooks = updateBooks.Where(b => b.cost <= Convert.ToInt32(costBookUpper.SelectedItem.ToString())).ToList();
      }

      BooksList.Rows.Clear();
      if (updateBooks.Count != 0)
      {
        BooksList.RowCount = updateBooks.Count;
        for (int i = 0; i < BooksList.RowCount; i++)
        {
          BooksList[0, i].Value = updateBooks[i].name;
          BooksList[1, i].Value = updateBooks[i].author;
          BooksList[2, i].Value = updateBooks[i].genre;
          BooksList[3, i].Value = updateBooks[i].cost;
        }
      }
    }

    private void nameBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdatePanel();
      BooksList.Focus();
    }

    private void authorBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdatePanel();
      BooksList.Focus();
    }

    private void genreBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdatePanel();
      BooksList.Focus();
    }

    private void costBookLower_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdatePanel();
      BooksList.Focus();
    }

    private void costBookUpper_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdatePanel();
      BooksList.Focus();
    }

    private void BooksList_SelectionChanged(object sender, EventArgs e)
    {
      BooksList.ClearSelection();
    }

    private void BooksList_MouseDown(object sender, MouseEventArgs e)
    {
      if (BooksList.CurrentCell == null)
      {
        return;
      }

      BooksList.CurrentCell.Selected = true;
      if (e.Button == MouseButtons.Right)
      {
        BooksList.CurrentCell.ContextMenuStrip = BookInfo;
      }
    }

    private void BookInfo_Click(object sender, EventArgs e)
    {
      if (BooksList.CurrentCell == null || BooksList[0, BooksList.CurrentCell.RowIndex].Value == null)
      {
        return;
      }

      bookName = BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString();
      CurrentBookInfoForm currentBookInfoForm = new CurrentBookInfoForm();
      currentBookInfoForm.ShowDialog();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void CatalogForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (!addButton.Visible)
      {
        Application.Exit();
      }
    }

    private void backButton_Click(object sender, EventArgs e)
    {      
      if (addButton.Visible == false)
      {
        LoginForm loginForm = new LoginForm();
        loginForm.Show();
      }

      this.Hide();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      if (BooksList.CurrentCell == null || BooksList[0, BooksList.CurrentCell.RowIndex].Value == null)
      {
        MessageBox.Show("Вы не выбрали книгу!");
        return;
      }

      if (BooksBase.getBooksBase().addBookToLib(BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString(), ChooseLib.selectedLib.lib))
      {
        FilterForm.filterBooks.Clear();
        MessageBox.Show("Книга \"" + BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString() + "\" добавлена в вашу библиотеку");
      }
      else
      {
        MessageBox.Show("Эта книга уже есть в вашей библиотеке");
      }
    }

    private void CatalogForm_Activated(object sender, EventArgs e)
    {
      if (LoginForm.userType == UserType.guest)
      {
        addButton.Visible = false;
      }
      else
      {
        addButton.Visible = true;
      }
    }
  }
}
