using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LovelyLib
{
  public partial class AdminBaseForm : Form
  {
    List<Book> allBooks = new List<Book>();
    List<User> allUsers = new List<User>();
    public static string bookName;
    public static string userName;

    public AdminBaseForm()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;

      SetLists();
    }

    private void SetLists()
    {
      allBooks = new List<Book>();
      allUsers = new List<User>();
      allBooks = BooksBase.getBooksBase().getAllBooks();
      allUsers = UsersBase.getUserBase().getAllUsers();

      BooksList.Rows.Clear();
      if (allBooks.Count != 0)
      {
        BooksList.RowCount = allBooks.Count + 1;
        for (int i = 0; i < BooksList.RowCount - 1; i++)
        {
          BooksList[0, i].Value = allBooks[i].name;
          BooksList[1, i].Value = allBooks[i].author;
          BooksList[2, i].Value = allBooks[i].genre;
          BooksList[3, i].Value = allBooks[i].cost;
        }
      }

      UsersList.Rows.Clear();
      if (allUsers.Count != 0)
      {
        UsersList.RowCount = allUsers.Count + 1;
        for (int i = 0; i < UsersList.RowCount - 1; i++)
        {
          UsersList[0, i].Value = allUsers[i].login;
          UsersList[1, i].Value = allUsers[i].type;
        }
      }
    }

    private void BooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      BooksList.ClearSelection();
    }

    private void usersList_SelectionChanged(object sender, EventArgs e)
    {
      UsersList.ClearSelection();
    }

    private void addUser_Click(object sender, EventArgs e)
    {
      userName = "";
      AddUserToBaseForm addUserToBaseForm = new AddUserToBaseForm();
      addUserToBaseForm.ShowDialog();
    }

    private void addBook_Click(object sender, EventArgs e)
    {
      bookName = "";
      AddBookToBaseForm addBookToBaseForm = new AddBookToBaseForm();
      addBookToBaseForm.ShowDialog();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void bookFindText_Enter(object sender, EventArgs e)
    {
      bookFindText.Text = "";
    }

    private void userFindText_Enter(object sender, EventArgs e)
    {
      userFindText.Text = "";
    }

    private void bookFindText_TextChanged(object sender, EventArgs e)
    {
      List<Book> currentBooks = new List<Book>();
      string space_check = bookFindText.Text.Replace(" ", "");

      if (bookFindText.Text.Length != 0 && space_check.Length != 0)
      {
        foreach (var i in allBooks)
        {
          Regex regex = new Regex(bookFindText.Text);
          if (regex.Matches(i.name).Count > 0 || regex.Matches(i.author).Count > 0 || 
            regex.Matches(i.genre).Count > 0 || regex.Matches(i.cost.ToString()).Count > 0)
          {
            currentBooks.Add(i);
          }
        }

        BooksList.Rows.Clear();
        if (currentBooks.Count != 0)
        {
          BooksList.RowCount = currentBooks.Count + 1;
          for (int i = 0; i < BooksList.RowCount - 1; i++)
          {
            BooksList[0, i].Value = currentBooks[i].name;
            BooksList[1, i].Value = currentBooks[i].author;
            BooksList[2, i].Value = currentBooks[i].genre;
            BooksList[3, i].Value = currentBooks[i].cost;
          }
        }
      }
      else if (BooksList.RowCount != allBooks.Count)
      {
        BooksList.Rows.Clear();
        if (allBooks.Count != 0)
        {
          BooksList.RowCount = allBooks.Count + 1;
          for (int i = 0; i < BooksList.RowCount - 1; i++)
          {
            BooksList[0, i].Value = allBooks[i].name;
            BooksList[1, i].Value = allBooks[i].author;
            BooksList[2, i].Value = allBooks[i].genre;
            BooksList[3, i].Value = allBooks[i].cost;
          }
        }
      }
    }

    private void userFindText_TextChanged_1(object sender, EventArgs e)
    {
      List<User> currentUsers = new List<User>();
      string space_check = userFindText.Text.Replace(" ", "");

      if (userFindText.Text.Length != 0 && space_check.Length != 0)
      {
        foreach (var i in allUsers)
        {
          Regex regex = new Regex(userFindText.Text);
          if (regex.Matches(i.login).Count > 0 || regex.Matches(i.type).Count > 0)
          {
            currentUsers.Add(i);
          }
        }

        UsersList.Rows.Clear();
        if (currentUsers.Count != 0)
        {
          UsersList.RowCount = currentUsers.Count + 1;
          for (int i = 0; i < UsersList.RowCount - 1; i++)
          {
            UsersList[0, i].Value = currentUsers[i].login;
            UsersList[1, i].Value = currentUsers[i].type;
          }
        }
      }
      else if (UsersList.RowCount != allUsers.Count)
      {
        UsersList.Rows.Clear();
        if (allUsers.Count != 0)
        {
          UsersList.RowCount = allUsers.Count + 1;
          for (int i = 0; i < UsersList.RowCount - 1; i++)
          {
            UsersList[0, i].Value = allUsers[i].login;
            UsersList[1, i].Value = allUsers[i].type;
          }
        }
      }
    }

    private void BooksList_SelectionChanged_1(object sender, EventArgs e)
    {
      BooksList.ClearSelection();
    }

    private void UsersList_SelectionChanged_1(object sender, EventArgs e)
    {
      UsersList.ClearSelection();
    }

    private void BooksList_MouseDown(object sender, MouseEventArgs e)
    {
      BooksList.CurrentCell.Selected = true;
      if (e.Button == MouseButtons.Right)
      {
        BooksList.CurrentCell.ContextMenuStrip = changeData;
      }
    }

    private void UsersList_MouseDown(object sender, MouseEventArgs e)
    {
      UsersList.CurrentCell.Selected = true;
      if (e.Button == MouseButtons.Right)
      {
        UsersList.CurrentCell.ContextMenuStrip = changeData;
      }
    }

    private void AdminBaseForm_Activated(object sender, EventArgs e)
    {
      SetLists();
    }

    private void editData_Click(object sender, EventArgs e)
    {
      bookName = "";
      userName = "";

      if (BooksList.CurrentCell.ContextMenuStrip == changeData)
      {
        if (BooksList[0, BooksList.CurrentCell.RowIndex].Value == null)
        {
          return;
        }

        bookName = BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString();
        AddBookToBaseForm addBookToBaseForm = new AddBookToBaseForm();
        addBookToBaseForm.ShowDialog();
      }
      if (UsersList.CurrentCell.ContextMenuStrip == changeData)
      {
        if (UsersList[0, UsersList.CurrentCell.RowIndex].Value == null)
        {
          return;
        }

        userName = UsersList[0, UsersList.CurrentCell.RowIndex].Value.ToString();
        AddUserToBaseForm addUserToBaseForm = new AddUserToBaseForm();
        addUserToBaseForm.ShowDialog();
      }
    }

    private void deleteData_Click(object sender, EventArgs e)
    {
      if (BooksList.CurrentCell.ContextMenuStrip == changeData)
      {
        if (BooksList[0, BooksList.CurrentCell.RowIndex].Value == null)
        {
          return;
        }

        bookName = BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString();
        BooksList.Rows.Remove(BooksList.CurrentRow);
        BooksBase.getBooksBase().deleteBook(bookName);
        BooksList.SelectionChanged += BooksList_SelectionChanged_1;
      }
      if (UsersList.CurrentCell.ContextMenuStrip == changeData)
      {
        if (UsersList[0, UsersList.CurrentCell.RowIndex].Value == null)
        {
          return;
        }

        userName = UsersList[0, UsersList.CurrentCell.RowIndex].Value.ToString();
        UsersList.Rows.Remove(UsersList.CurrentRow);
        UsersBase.getUserBase().deleteUser(userName);
        UsersList.SelectionChanged += UsersList_SelectionChanged_1;
      }
    }

    private void AdminBaseForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
