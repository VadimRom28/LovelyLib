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

namespace LovelyLib
{
  public partial class AddBookToBaseForm : Form
  {
    public AddBookToBaseForm()
    {
      InitializeComponent();

      setInfo();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      if (pictureBook.Image != null)
      {
        pictureBook.Image.Dispose();
        pictureBook.InitialImage = null;
      }

      this.Close();
    }

    private void setInfo()
    {
      if (AdminBaseForm.bookName.Length != 0)
      {
        Book currentBook = new Book();
        currentBook = BooksBase.getBooksBase().getBook(AdminBaseForm.bookName);

        authorInfo.Text = currentBook.author;
        nameInfo.Text = currentBook.name;
        genreInfo.Text = currentBook.genre;
        costInfo.Text = currentBook.cost.ToString();
        bookDescription.Text = currentBook.description;

        DirectoryInfo directoryInfo = new DirectoryInfo("G:\\LovelyLibDataFiles\\booksImages\\");
        foreach (var item in directoryInfo.GetFiles())
        {
          if (item.Name == currentBook.name + ".jpg")
          {
            pictureBook.Image = Image.FromFile("G:\\LovelyLibDataFiles\\booksImages\\" + currentBook.name + ".jpg");
            
            break;
          }
        }      
      }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      if (authorInfo.Text.Length != 0 && authorInfo.Text.Replace(" ", "").Length != 0 &&
        nameInfo.Text.Length != 0 && nameInfo.Text.Replace(" ", "").Length != 0 &&
        genreInfo.Text.Length != 0 && genreInfo.Text.Replace(" ", "").Length != 0 &&
        costInfo.Text.Length != 0 && costInfo.Text.Replace(" ", "").Length != 0 &&
        bookDescription.Text.Length != 0 && bookDescription.Text.Replace(" ", "").Length != 0)
      {
        for (int i = 0; i < costInfo.Text.Length; i++)
        {
          if (!Char.IsDigit(costInfo.Text[i]))
          {
            MessageBox.Show("Цена задана некорректно!");
            return;
          }
        }

        Book currentBook = new Book();
        currentBook.author = authorInfo.Text;
        currentBook.name = nameInfo.Text;
        currentBook.genre = genreInfo.Text;
        currentBook.cost = Convert.ToInt32(costInfo.Text);
        currentBook.description = bookDescription.Text;

        if (AdminBaseForm.bookName.Length != 0)
        {
          BooksBase.getBooksBase().editBook(AdminBaseForm.bookName, currentBook);
        }
        else
        {
          BooksBase.getBooksBase().addBook(currentBook);
        }

        if (pictureBook.Image != null)
        {
          pictureBook.Image.Dispose();
          pictureBook.InitialImage = null;

          string sourceDir = openPictureFile.FileName;
          string destDir = "G:\\LovelyLibDataFiles\\booksImages\\" + nameInfo.Text + ".jpg";

          if (!File.Exists(destDir))
          {
            File.Copy(sourceDir, destDir, true);
          }
        }

        this.Close();
      }
      else
      {
        MessageBox.Show("Необходимо заполнить каждое поле");
      }
    }

    private void loadPictureBook_Click(object sender, EventArgs e)
    {
      if (openPictureFile.ShowDialog() == DialogResult.Cancel)
      {
        return;
      }

      string sourceDir = openPictureFile.FileName;
      string destinationDir = "G:\\LovelyLibDataFiles\\booksImages\\" + Path.GetFileName(sourceDir);

      if (pictureBook.Image != null)
      {
        string prevPath = "G:\\LovelyLibDataFiles\\booksImages\\" + nameInfo.Text + ".jpg";

        if (File.Exists(prevPath))
        {
          pictureBook.Image.Dispose();
          pictureBook.Image = null;
          File.Delete(prevPath);
        }
      }

      pictureBook.Image = Image.FromFile(openPictureFile.FileName);
      openPictureFile.Dispose();
    }
  }
}
