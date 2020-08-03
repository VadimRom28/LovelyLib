using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public struct Lib
{
  public string name;
  public int id;
}

namespace LovelyLib
{
  class LibBase
  {
    private static LibBase instance;
    Dictionary<string, List<Lib>> userLibs = new Dictionary<string, List<Lib>>();

    private LibBase() { }

    public static LibBase getLibBase()
    {
      if (instance == null)
      {
        instance = new LibBase();
      }

      return instance;
    }

    public void setLibBase()
    {
      string pathFile = "G:\\LovelyLibDataFiles\\UsersLib.txt";

      if (!File.Exists(pathFile))
      {
        File.Create(pathFile).Close();
      }

      FileStream file = new FileStream(pathFile, FileMode.Open);
      StreamReader streamReader = new StreamReader(file);
      userLibs.Clear();

      while (!streamReader.EndOfStream)
      {
        string[] userData = streamReader.ReadLine().Split(' ');
        Lib currentLib = new Lib();
        currentLib.name = userData[1];
        currentLib.id = Convert.ToInt32((userData[2]));
        if (userLibs.ContainsKey(userData[0]))
        {
          userLibs[userData[0]].Add(currentLib);
        }
        else
        {
          userLibs.Add(userData[0], null);
          userLibs[userData[0]] = new List<Lib>();
          userLibs[userData[0]].Add(currentLib);
        }
      }

      streamReader.Close();
    }

    public bool addLib(string loginUser, string libName)
    {
      if (libName.Length == 0)
      {
        return false;
      }

      if (userLibs.ContainsKey(loginUser))
      {
        foreach (var i in userLibs[loginUser])
        {
          if (i.name == libName)
          {
            return false;
          }
        }
      }

      string pathFile = "G:\\LovelyLibDataFiles\\UsersLib.txt";
      Lib currentLib = new Lib();
      currentLib.id = getFreeId();
      currentLib.name = libName;

      File.AppendAllText(pathFile, loginUser + " " + currentLib.name + " " + currentLib.id + '\n');

      if (userLibs.ContainsKey(loginUser))
      {
        userLibs[loginUser].Add(currentLib);
      }
      else
      {
        userLibs.Add(loginUser, null);
        userLibs[loginUser] = new List<Lib>();
        userLibs[loginUser].Add(currentLib);
      }

      return true;
    }

    public void deleteLib(string loginUser, string libName)
    {
      Lib deleteLib = new Lib();
      foreach (var i in userLibs[loginUser])
      {
        if (i.name == libName)
        {
          deleteLib = i;
          break;
        }
      }

      userLibs[loginUser].Remove(deleteLib);

      string pathFile = "G:\\LovelyLibDataFiles\\UsersLib.txt";
      var rewriteData = File.ReadAllLines(pathFile, Encoding.Default).Where(s => !s.Contains(libName));
      File.WriteAllLines(pathFile, rewriteData);
    }

    private int getFreeId()
    {
      List<int> availableIdList = new List<int>();

      for (int i = 0; i < 100; i++)
      {
        availableIdList.Add(i);
      }

      string pathFile = "G:\\LovelyLibDataFiles\\UsersLib.txt";
      FileStream file = new FileStream(pathFile, FileMode.Open);
      StreamReader streamReader = new StreamReader(file);

      while (!streamReader.EndOfStream)
      {
        string[] userData = streamReader.ReadLine().Split(' ');
        int currentId = Convert.ToInt32((userData[2]));
        availableIdList.Remove(currentId);
      }

      streamReader.Close();

      return availableIdList[new Random().Next(availableIdList.Count)];
    }

    public List<Lib> getUserLibs(string userName)
    {
      if (userLibs.ContainsKey(userName))
      {
        return userLibs[userName];
      }
      else
      {
        return null;
      }
    }

    public Lib getLib(string userName, string libName)
    {
      Lib currentLib = new Lib();

      foreach(var i in userLibs[userName])
      {
        if (i.name == libName)
        {
          currentLib = i;
          break;
        }
      }

      return currentLib;
    }
  }
}