using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct SelectedUserAndLib
{
  public User user;
  public Lib lib;
}

namespace LovelyLib
{
  public partial class ChooseLib : Form
  {
    LibBase ourUserLibBase = LibBase.getLibBase();
    public List<Lib> ourLibList = new List<Lib>();
    public static SelectedUserAndLib selectedLib;

    public ChooseLib()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;

      ourUserLibBase.setLibBase();
      List<Lib> currentUserLibs = ourUserLibBase.getUserLibs(LoginForm.ourUserName);

      if (currentUserLibs != null)
      {
        ourLibList.Clear();
        libUserBase.Items.Clear();
        ourLibList.AddRange(currentUserLibs);

        foreach (var i in ourLibList)
        {
          libUserBase.Items.Add(i.name);
        }
      }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
      LoginForm loginForm = new LoginForm();
      loginForm.Show();
      this.Hide();
    }

    private void createLibButton_Click(object sender, EventArgs e)
    {
      AddLibNameForm addLibNameForm = new AddLibNameForm();
      addLibNameForm.Show();
    }

    private void ChooseLib_Activated(object sender, EventArgs e)
    {
      List<Lib> currentUserLibs = ourUserLibBase.getUserLibs(LoginForm.ourUserName);

      if (currentUserLibs != null)
      {
        ourLibList.Clear();
        libUserBase.Items.Clear();
        ourLibList.AddRange(currentUserLibs);

        foreach (var i in ourLibList)
        {
          libUserBase.Items.Add(i.name);
        }
      }
    }

    private void deleteLib_Click(object sender, EventArgs e)
    {
      if (libUserBase.SelectedIndex != -1)
      {
        ourUserLibBase.deleteLib(LoginForm.ourUserName, libUserBase.SelectedItem.ToString());

        List<Lib> currentUserLibs = ourUserLibBase.getUserLibs(LoginForm.ourUserName);

        if (currentUserLibs != null)
        {
          ourLibList.Clear();
          libUserBase.Items.Clear();
          ourLibList.AddRange(currentUserLibs);

          foreach (var i in ourLibList)
          {
            libUserBase.Items.Add(i.name);
          }
        }
      }
      else
      {
        MessageBox.Show("Вы не выбрали библиотеку");
      }
    }

    private void ChooseLib_Shown(object sender, EventArgs e)
    {
      List<Lib> currentUserLibs = ourUserLibBase.getUserLibs(LoginForm.ourUserName);

      if (currentUserLibs != null)
      {
        ourLibList.Clear();
        libUserBase.Items.Clear();
        ourLibList.AddRange(currentUserLibs);

        foreach (var i in ourLibList)
        {
          libUserBase.Items.Add(i.name);
        }
      }
    }

    private void selectLibButton_Click(object sender, EventArgs e)
    {
      if (libUserBase.SelectedIndex != -1)
      {
        selectedLib.lib = LibBase.getLibBase().getLib(LoginForm.ourUserName, libUserBase.SelectedItem.ToString());
        selectedLib.user = UsersBase.getUserBase().getUser(LoginForm.ourUserName);

        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Hide();
      }
      else
      {
        MessageBox.Show("Вы не выбрали библиотеку");
      }
    }

    private void ChooseLib_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
