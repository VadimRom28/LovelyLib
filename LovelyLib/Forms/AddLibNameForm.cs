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
  public partial class AddLibNameForm : Form
  {
    LibBase ourUserLibBase = LibBase.getLibBase();

    public AddLibNameForm()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
      if (!ourUserLibBase.addLib(LoginForm.ourUserName, LibNameText.Text))
      {
        MessageBox.Show("Не удалось создать библиотеку с таким именем");
      }
      else
      {
        this.Hide();
      }
    }

    private void AddLibNameForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == (char)Keys.Enter)
      {
        CreateButton_Click(CreateButton, null);
      }
    }

    private void cancelButton_Click_1(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
