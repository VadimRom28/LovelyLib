using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public struct User
{
  public string type;
  public string login;
  public string password;
}

namespace LovelyLib
{
  class UsersBase
  {
    private static UsersBase instance;
    private List<User> ourUsers = new List<User>();

    private UsersBase() { }

    public static UsersBase getUserBase()
    {
      if (instance == null)
      {
        instance = new UsersBase();
      }
      return instance;
    }

    public void setUsers()
    {
      ourUsers.Clear();
      string pathFile = "G:\\LovelyLibDataFiles\\Users.txt";

      if (!File.Exists(pathFile))
      {
        File.Create(pathFile).Close();
      }

      FileStream file = new FileStream(pathFile, FileMode.Open);
      StreamReader streamReader = new StreamReader(file);

      while (!streamReader.EndOfStream)
      {
        string[] userData = streamReader.ReadLine().Split(' ');
        User currentUser = new User();
        currentUser.type = userData[0];
        currentUser.login = userData[1];
        currentUser.password = userData[2];
        ourUsers.Add(currentUser);
      }

      streamReader.Close();
    }

    public bool findUser(string loginUser, string passwordUser)
    {
      foreach (var i in ourUsers)
      {
        if (i.login == loginUser && i.password == passwordUser)
        {
          return true;
        }
      }

      return false;
    }

    public bool addUser(string loginUser, string passwordUser, string typeUser)
    {
      setUsers();

      foreach (var i in ourUsers)
      {
        if (i.login == loginUser)
        {
          return false;
        }
      }

      string pathFile = "G:\\LovelyLibDataFiles\\Users.txt";
      User currentUser = new User();
      currentUser.type = typeUser;
      currentUser.login = loginUser;
      currentUser.password = passwordUser;
      ourUsers.Add(currentUser);
      File.AppendAllText(pathFile, currentUser.type + " " + currentUser.login + " " + currentUser.password + '\n');

      return true;
    }

    public void deleteUser(string loginUser)
    {
      setUsers();
      ourUsers = ourUsers.Where(s => s.login != loginUser).ToList();

      string pathFile = "G:\\LovelyLibDataFiles\\Users.txt";
      File.Create(pathFile).Close();
      foreach (var i in ourUsers)
      {
        File.AppendAllText(pathFile, i.type + " " + i.login + " " + i.password + '\n');
      }

      pathFile = "G:\\LovelyLibDataFiles\\UsersLib.txt";
      var sLib = File.ReadAllLines(pathFile).Where(str1 => !str1.Contains(loginUser));
      var dLib = File.ReadAllLines(pathFile).Where(str2 => str2.Contains(loginUser));
      File.WriteAllLines(pathFile, sLib);

      List<int> currentLibs = new List<int>();
      foreach (var i in dLib)
      {
        string[] s = i.Split(' ');
        currentLibs.Add(Convert.ToInt32(s[2]));
      }

      pathFile = "G:\\LovelyLibDataFiles\\LibsBooks.txt";
      List<string> delLibs = File.ReadAllLines(pathFile).ToList();

      foreach (var i in currentLibs)
      {
        delLibs = delLibs.Where(s => !s.Contains(i.ToString())).ToList();
      }

      File.WriteAllLines(pathFile, delLibs);
    }

    public string getUserType(string loginUser, string passwordUser)
    {
      setUsers();

      foreach (var i in ourUsers)
      {
        if (i.login == loginUser && i.password == passwordUser)
        {
          return i.type;
        }
      }

      return null;
    }

    public User getUser (string loginUser)
    {
      User currentUser = new User();
      setUsers();

      foreach (var i in ourUsers)
      {
        if (i.login == loginUser)
        {
          currentUser.login = i.login;
          currentUser.password = i.password;
          currentUser.type = i.type;
          break;
        }
      }

      return currentUser;
    }

    public List <User> getAllUsers()
    {
      setUsers();
      List<User> currentUsers = new List<User>();
      currentUsers.AddRange(ourUsers);

      return currentUsers;
    }

    public void changeUserType(string loginUser)
    {
      setUsers();

      List<User> delUser = ourUsers.Where(s => s.login == loginUser).ToList();
      foreach (var i in delUser)
      {
        ourUsers.Remove(i);

        User currentUser = new User();
        currentUser.login = i.login;
        currentUser.password = i.password;
        if (i.type == "admin")
        {
          currentUser.type = "user";
        }
        else if (i.type == "user")
        {
          currentUser.type = "admin";
        }

        ourUsers.Add(currentUser);
      }

      string pathFile = "G:\\LovelyLibDataFiles\\Users.txt";
      File.Create(pathFile).Close();
      foreach (var i in ourUsers)
      {
        File.AppendAllText(pathFile, i.type + " " + i.login + " " + i.password + '\n');
      }
    }
  }
}
