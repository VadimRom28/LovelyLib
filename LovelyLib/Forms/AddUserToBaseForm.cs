using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum AccessType
{
  unknown,
  admin,
  user
}

namespace LovelyLib
{
  public partial class AddUserToBaseForm : Form
  {
    AccessType accessType;

    public AddUserToBaseForm()
    {
      accessType = AccessType.unknown;
      InitializeComponent();
      setData();
    }

    private void setData()
    {
      if (AdminBaseForm.userName.Length != 0)
      {
        loginText.Enabled = false;
        passwordText.Enabled = false;

        User currentUser = new User();
        currentUser = UsersBase.getUserBase().getUser(AdminBaseForm.userName);

        loginText.Text = currentUser.login;
        passwordText.Text = currentUser.password;
        if (currentUser.type == "admin")
        {
          accessType = AccessType.admin;
          adminType.Checked = true;
        }
        else if (currentUser.type == "user")
        {
          accessType = AccessType.user;
          userType.Checked = true;
        }
      }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      if (accessType == AccessType.unknown)
      {
        unregUserCheck();
      }
      else if (accessType == AccessType.admin || accessType == AccessType.user)
      {
        regUserCheck();
      }
    }

    private void unregUserCheck()
    {
      if (loginText.Text.Length == 0 || loginText.Text.Replace(" ", "").Length == 0 ||
        passwordText.Text.Length == 0 || passwordText.Text.Replace(" ", "").Length == 0 ||
        (adminType.Checked == false && userType.Checked == false))
      {
        uncorrectDataText.Text = "Необходимо заполнить каждое поле";
      }
      else if (UsersBase.getUserBase().findUser(loginText.Text, passwordText.Text))
      {
        uncorrectDataText.Text = "Пользователь с таким именем уже существует";
        return;
      }
      else
      {
        User currentUser = new User();
        currentUser.login = loginText.Text;
        currentUser.password = passwordText.Text;

        if (userType.Checked == true)
        {
          currentUser.type = "user";
        }
        else if (adminType.Checked == true)
        {
          currentUser.type = "admin";
        }

        UsersBase.getUserBase().addUser(currentUser.login, currentUser.password, currentUser.type);
        MessageBox.Show("Добавлен пользователь " + currentUser.login + " с уровнем доступа " + currentUser.type);
        this.Close();
      }
    }

    private void regUserCheck()
    {
      if (accessType == AccessType.admin && adminType.Checked == false ||
  accessType == AccessType.user && userType.Checked == false)
      {
        UsersBase.getUserBase().changeUserType(loginText.Text);
        MessageBox.Show("Пользователь " + loginText.Text + " теперь имеет уровень доступа " +
          UsersBase.getUserBase().getUser(loginText.Text).type);
      }

      this.Close();
    }
  }
}
