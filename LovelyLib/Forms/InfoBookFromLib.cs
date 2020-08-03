using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace LovelyLib
{
  public partial class InfoBookFromLib : Form
  {
    private string printText;
    private Image printImage;

    public InfoBookFromLib()
    {
      InitializeComponent();

      SetInfo();
    }

    private void SetInfo()
    {
      if (findImage())
      {
        pictureBook.Image = Image.FromFile("G:\\LovelyLibDataFiles\\booksImages\\" + CatalogForm.bookName + ".jpg");
      }

      Book currentBook = BooksBase.getBooksBase().getBookFromLib(CatalogForm.bookName, MainWindow.selectedUserLib.lib);
      nameInfo.Text = currentBook.name;
      authorInfo.Text = currentBook.author;
      genreInfo.Text = currentBook.genre;
      costInfo.Text = currentBook.cost.ToString();
      bookDescription.Text = currentBook.description;
      addCalendarBox.SetDate(DateTime.Parse(currentBook.date));
    }

    private bool findImage()
    {
      DirectoryInfo directoryInfo = new DirectoryInfo("G:\\LovelyLibDataFiles\\booksImages\\");

      foreach (var item in directoryInfo.GetFiles())
      {
        if (item.Name == CatalogForm.bookName + ".jpg")
        {
          return true;
        }
      }
     
      return false;
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    void PrintTextSettings(object sender, PrintPageEventArgs e)
    {
      e.Graphics.DrawString(printText, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
    }

    void PrintPictureSettings(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawImage(new Bitmap("G:\\LovelyLibDataFiles\\booksImages\\" + nameInfo.Text + ".jpg"), new Point(0, 0)); //Картинка на печать
    }

    private void printPicture_Click(object sender, EventArgs e)
    {
      PrintDocument printDocument = new PrintDocument();
      DirectoryInfo directoryInfo = new DirectoryInfo("G:\\LovelyLibDataFiles\\booksImages\\");
      foreach (var item in directoryInfo.GetFiles())
      {
        if (item.Name == nameInfo.Text + ".jpg")
        {
          printImage = Image.FromFile("G:\\LovelyLibDataFiles\\booksImages\\" + nameInfo.Text + ".jpg");

          break;
        }
      }

      if (printImage == null)
      {
        return;
      }

      printDocument.PrintPage += PrintPictureSettings;
      PrintDialog printDialog = new PrintDialog();
      printDialog.Document = printDocument;

      if (printDialog.ShowDialog() == DialogResult.OK)
      {
        printDialog.Document.Print();
      }
    }

    private void printInfo_Click(object sender, EventArgs e)
    {
      PrintDocument printDocument = new PrintDocument();
      printText = "Книга: " + nameInfo.Text + '\n';
      printText += "Автор: " + authorInfo.Text + '\n';
      printText += "Жанр: " + genreInfo.Text + '\n';
      printText += "Цена: " + costInfo.Text + " рублей \n";

      printDocument.PrintPage += PrintTextSettings;
      PrintDialog printDialog = new PrintDialog();
      printDialog.Document = printDocument;

      if (printDialog.ShowDialog() == DialogResult.OK)
      {
        printDialog.Document.Print();
      }
    }
  }
}
