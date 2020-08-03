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
  public partial class OrderForm : Form
  {
    public int totalCost = 0;

    public OrderForm()
    {
      InitializeComponent();

      dateBox.Value.AddDays(2);
      SetBooks();
    }

    private void SetBooks()
    {
      totalCost = 0;
      BooksList.Rows.Clear();
      BooksList.RowCount = MainWindow.ourBooks.Count + 1;
      for (int i = 0; i < BooksList.RowCount - 1; i++)
      {
        BooksList[0, i].Value = MainWindow.ourBooks[i].name;
        BooksList[1, i].Value = MainWindow.ourBooks[i].author;
        BooksList[2, i].Value = MainWindow.ourBooks[i].genre;
        BooksList[3, i].Value = MainWindow.ourBooks[i].cost;

        totalCost += Convert.ToInt32(MainWindow.ourBooks[i].cost);
      }

      totalPriceText.Text = totalCost.ToString() + '₽';
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void orderButton_Click(object sender, EventArgs e)
    {
      if (!isInputCorrect())
      {
        MessageBox.Show("Данные заполнены некорректно!");
        return;
      }

      MessageBox.Show("Заказ оформлен успешно");
      this.Hide();
    }

    private bool isInputCorrect()
    {
      foreach (char i in firstNameText.Text)
      {
        if (!((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z') || (i >= 'А' && i <= 'я')))
        {
          return false;
        }
      }

      foreach (char i in secondNameText.Text)
      {
        if (!((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z') || (i >= 'А' && i <= 'я')))
        {
          return false;
        }
      }

      if (!phoneNumberText.MaskFull)
      {
        return false;
      }

      if (dateBox.Value < DateTime.Now)
      {
        return false;
      }

      return true;
    }

    private void BooksList_SelectionChanged(object sender, EventArgs e)
    {
      BooksList.ClearSelection();
    }
  }
}
