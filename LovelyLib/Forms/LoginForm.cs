using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum UserType
{
  admin,
  client,
  guest
}

namespace LovelyLib
{
  public partial class LoginForm : Form
  {
    public TextBox loginUser;
    public TextBox passwordUser;
    public static string ourUserName;
    UsersBase ourUsers = UsersBase.getUserBase();
    public static UserType userType;

    public LoginForm()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
      ourUsers.setUsers();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      loginUser = loginText;
      passwordUser = passwordText;

      if (loginUser.Text.Length == 0 || passwordText.Text.Length == 0)
      {
        uncorrectDataText.Text = "Необходимо заполнить каждое поле";
        return;
      }

      if (loginText.Text.Contains(' ') || passwordText.Text.Contains(' '))
      {
        uncorrectDataText.Text = "Нельзя использовать пробел";
        return;
      }

      if (ourUsers.findUser(loginUser.Text, passwordText.Text))
      {
        if (UsersBase.getUserBase().getUserType(loginUser.Text, passwordText.Text) == "admin")
        {
          userType = UserType.admin;
          AdminBaseForm adminBaseForm = new AdminBaseForm();
          adminBaseForm.Show();
          this.Hide();
          return;
        }

        if (UsersBase.getUserBase().getUserType(loginUser.Text, passwordText.Text) == "user")
        {
          userType = UserType.client;
          ourUserName = loginText.Text;
          ChooseLib chooseLib = new ChooseLib();
          chooseLib.Show();
          this.Hide();
        }
      }
      else
      {
        uncorrectDataText.Text = "Неверное имя пользователя или пароль";
      }
    }

    private void LoginForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == (char)Keys.Enter)
      {
        loginButton_Click(loginButton, null);
      }
    }

    private void registrationButton_Click(object sender, EventArgs e)
    {
      loginUser = loginText;
      passwordUser = passwordText;

      if (loginText.Text.Length == 0 || loginText.Text.Replace(" ","").Length == 0 ||
        passwordText.Text.Length == 0 || passwordText.Text.Replace(" ","").Length == 0)
      {
        uncorrectDataText.Text = "Необходимо заполнить каждое поле";
      }
      else if (ourUsers.addUser(loginUser.Text, passwordUser.Text, "user"))
      {
        uncorrectDataText.Text = "Вы успешно зарегистрированы!";
      }
      else
      {
        uncorrectDataText.Text = "Пользователь с таким именем уже существует";
      }
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }


    private void guestButton_Click(object sender, EventArgs e)
    {
      userType = UserType.guest;
      CatalogForm catalogForm = new CatalogForm();
      catalogForm.Show();
      this.Hide();
    }
  }
}
