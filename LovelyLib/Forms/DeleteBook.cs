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
  public partial class DeleteBook : Form
  {
    public DeleteBook()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
      delBookName.Text = "Удалить книгу \"" + MainWindow.delBook + "\" из вашей библиотеки?" ;
    }

    private void yesButton_Click(object sender, EventArgs e)
    {
      BooksBase.getBooksBase().deleteBookFromLib(MainWindow.delBook, ChooseLib.selectedLib.lib);
      FilterForm.filterBooks.Clear();
      this.Hide();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
