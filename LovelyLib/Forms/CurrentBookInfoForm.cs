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
  public partial class CurrentBookInfoForm : Form
  {
    public CurrentBookInfoForm()
    {
      InitializeComponent();
      if (findImage())
      {
        pictureBook.Image = Image.FromFile("G:\\LovelyLibDataFiles\\booksImages\\" + CatalogForm.bookName + ".jpg");
      }

      Book currentBook = BooksBase.getBooksBase().getBook(CatalogForm.bookName);
      bookDescription.Text = currentBook.description;
    }

    private bool findImage()
    {
      DirectoryInfo directoryInfo = new DirectoryInfo("G:\\LovelyLibDataFiles\\booksImages\\");

      foreach(var item in directoryInfo.GetFiles())
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
      if (pictureBook.Image != null)
      {
        pictureBook.Image.Dispose();
        pictureBook.InitialImage = null;
      }
      this.Close();
    }
  }
}
