using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Microsoft.VisualBasic.FileIO;

namespace LovelyLib
{
  public partial class MainWindow : Form
  {
    public static string delBook;
    private bool isOpenCSV = false;
    private string printText;
    public static List<Book> ourBooks = new List<Book>();
    public static SelectedUserAndLib selectedUserLib;
    BooksBase booksBase = BooksBase.getBooksBase();

    public MainWindow()
    { 
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
      selectedUserLib.user = ChooseLib.selectedLib.user;
      selectedUserLib.lib = ChooseLib.selectedLib.lib;

      libNameText.Text = "Библиотека: " + selectedUserLib.lib.name;
      currentUserText.Text = "Пользователь: " + selectedUserLib.user.login;

      UpdateBooksList();
    }

    private void UpdateBooksList()
    {
      if (isOpenCSV)
      {
        return;
      }

      ourBooks.Clear();
      ourBooks.AddRange(booksBase.getUserBooks(selectedUserLib.lib.id));
      BooksList.Rows.Clear();
      BooksList.RowCount = ourBooks.Count + 1;
      for (int i = 0; i < BooksList.RowCount - 1; i++)
      {
        BooksList[0, i].Value = ourBooks[i].name;
        BooksList[1, i].Value = ourBooks[i].author;
        BooksList[2, i].Value = ourBooks[i].genre;
        BooksList[3, i].Value = ourBooks[i].cost;
        BooksList[4, i].Value = ourBooks[i].date;
        BooksList[5, i].Value = ourBooks[i].size;
      }

      if (FilterForm.filterBooks.Count != 0)
      {
        BooksList.Rows.Clear();
        BooksList.RowCount = FilterForm.filterBooks.Count + 1;
        for (int i = 0; i < BooksList.RowCount - 1; i++)
        {
          BooksList[0, i].Value = FilterForm.filterBooks[i].name;
          BooksList[1, i].Value = FilterForm.filterBooks[i].author;
          BooksList[2, i].Value = FilterForm.filterBooks[i].genre;
          BooksList[3, i].Value = FilterForm.filterBooks[i].cost;
          BooksList[4, i].Value = FilterForm.filterBooks[i].date;
          BooksList[5, i].Value = FilterForm.filterBooks[i].size;
        }
      }
    }

    private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void BooksList_SelectionChanged(object sender, EventArgs e)
    {
      BooksList.ClearSelection();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      CatalogForm catalogForm = new CatalogForm();
      catalogForm.ShowDialog();

    }

    private void MainWindow_Activated(object sender, EventArgs e)
    {
      UpdateBooksList();
    }

    private void basketButton_Click(object sender, EventArgs e)
    {
      OrderForm orderForm = new OrderForm();
      orderForm.ShowDialog();
    }

    private void infoButton_Click(object sender, EventArgs e)
    {
      InfoLibForm infoLibForm = new InfoLibForm();
      infoLibForm.ShowDialog();
    }

    private void delButton_Click(object sender, EventArgs e)
    {
      if (BooksList.CurrentCell == null || BooksList.RowCount == 0 || BooksList[0, BooksList.CurrentCell.RowIndex].Value == null)
      {
        return;
      }

      delBook = BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString();
      DeleteBook deleteBook = new DeleteBook();
      deleteBook.ShowDialog();
    }

    private void filterButton_Click(object sender, EventArgs e)
    {
      FilterForm filterForm = new FilterForm();
      filterForm.ShowDialog();
    }

    private void BooksList_MouseDown(object sender, MouseEventArgs e)
    {
      if (BooksList.CurrentCell != null)
      {
        BooksList.CurrentCell.Selected = true;
        if (e.Button == MouseButtons.Right)
        {
          BooksList.CurrentCell.ContextMenuStrip = BookInfo;
        }
      }
    }

    private void BookInfo_Click(object sender, EventArgs e)
    {
      CatalogForm.bookName = BooksList[0, BooksList.CurrentCell.RowIndex].Value.ToString();
      InfoBookFromLib infoBookFromLib = new InfoBookFromLib();
      infoBookFromLib.ShowDialog();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void SaveAsDialog_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Text files(*.txt)|*.txt";

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
      {
        return;
      }

      string fileName = saveFileDialog.FileName;
      File.AppendAllText(fileName, "Пользователь: " + selectedUserLib.user.login + '\n');
      File.AppendAllText(fileName, "Библиотека: " + selectedUserLib.lib.name + '\n');    
      foreach (var i in ourBooks)
      {
        File.AppendAllText(fileName, i.name + " " + i.author + " " + i.genre + 
          " " + i.cost + " " + i.date + " " + i.size + '\n');
      }
    }

    private void PrintDialog_Click(object sender, EventArgs e)
    {
      PrintDocument printDocument = new PrintDocument();

      printText = "Пользователь: " + selectedUserLib.user.login + '\n';
      printText += "Библиотека: " + selectedUserLib.lib.name + '\n';
      foreach (var i in ourBooks)
      {
        printText += i.name + " " + i.author + " " + i.genre +
          " " + i.cost + " " + i.date + " " + i.size + '\n';
      }

      printDocument.PrintPage += PrintSettings;
      PrintDialog printDialog = new PrintDialog();
      printDialog.Document = printDocument;

      if (printDialog.ShowDialog() == DialogResult.OK)
      {
        printDialog.Document.Print();
      }
    }

    void PrintSettings(object sender, PrintPageEventArgs e)
    {
      e.Graphics.DrawString(printText, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
    }

    private void readCsvFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "CSV files (*.csv)|*.csv";

      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
      {
        return;
      }
      else
      {
        BooksList.Rows.Clear();

        using (TextFieldParser tfp = new TextFieldParser(openFileDialog.FileName))
        {
          tfp.TextFieldType = FieldType.Delimited;
          tfp.SetDelimiters(",");

          List<string[]> strList = new List<string[]>();
          while (!tfp.EndOfData)
          {
            strList.Add(tfp.ReadFields());
          }

          BooksList.RowCount = strList.Count + 1;
          for (int i = 0; i < strList.Count; i++)
          {
            BooksList[0, i].Value = strList[i][0].Replace("-", " ");
            BooksList[1, i].Value = strList[i][1].Replace("-", " ");
            BooksList[2, i].Value = strList[i][2].Replace("-", " ");
            BooksList[3, i].Value = strList[i][3].Replace("-", " ");
            BooksList[4, i].Value = strList[i][4].Replace("-", " ");
            BooksList[5, i].Value = strList[i][5].Replace("-", " ");
          }
        }

        isOpenCSV = true;
      }
    }

    private void saveCsvFile_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
      {
        return;
      }
      else
      {
        string pathFile = saveFileDialog.FileName;
        List<string> currentLines = new List<string>();
        
        for (int i = 0; i < BooksList.RowCount - 1; i++)
        {
          var nameBook = BooksList[0, i].Value.ToString().Replace(" ", "-");
          var authorBook = BooksList[1, i].Value.ToString().Replace(" ", "-");
          var genreBook = BooksList[2, i].Value.ToString().Replace(" ", "-");
          var costBook = BooksList[3, i].Value.ToString().Replace(" ", "-");
          var dateBook = BooksList[4, i].Value.ToString().Replace(" ", "-");
          var sizeBook = BooksList[5, i].Value.ToString().Replace(" ", "-");
          currentLines.Add(nameBook + ',' + authorBook + ',' + genreBook + ',' +
            costBook + ',' + dateBook + ',');
        }

        File.WriteAllLines(pathFile, currentLines);
      }
    }
  }
}
