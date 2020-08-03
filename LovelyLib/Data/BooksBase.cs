using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public struct Book
{
  public string name;
  public string author;
  public string genre;
  public int cost;
  public string date;
  public long size;
  public string description;
}

namespace LovelyLib
{
  class BooksBase
  {
    private static BooksBase instance;
    private Dictionary<string, Book> deterBook = new Dictionary<string, Book>();

    BooksBase() { }

    public static BooksBase getBooksBase()
    {
      if (instance == null)
      {
        instance = new BooksBase();
      }

      return instance;
    }

    public void setBooks()
    {
      DirectoryInfo directoryInfo = new DirectoryInfo("G:\\LovelyLibDataFiles\\books\\");
      deterBook.Clear();

      foreach(var item in directoryInfo.GetFiles())
      {
        FileStream file = new FileStream(item.FullName, FileMode.Open);
        StreamReader streamReader = new StreamReader(file);

        Book currentBook = new Book();
        currentBook.name = streamReader.ReadLine();
        currentBook.author = streamReader.ReadLine();
        currentBook.genre = streamReader.ReadLine();
        currentBook.cost = Convert.ToInt32(streamReader.ReadLine());
        currentBook.size = item.Length;

        while (!streamReader.EndOfStream)
        {
          currentBook.description += streamReader.ReadLine();
        }

        deterBook.Add(item.Name.Remove(item.Name.Length - 4), currentBook);
        streamReader.Close();
        file.Close();
      }

    }

    public void addBook(Book currentBook)
    {
      setBooks();
      string pathFile = "G:\\LovelyLibDataFiles\\books\\" + currentBook.name.Replace(" ", "") + ".txt";
      File.Create(pathFile).Close();
      File.AppendAllText(pathFile, currentBook.name + '\n');
      File.AppendAllText(pathFile, currentBook.author + '\n');
      File.AppendAllText(pathFile, currentBook.genre + '\n');
      File.AppendAllText(pathFile, currentBook.cost.ToString() + '\n');
      File.AppendAllText(pathFile, currentBook.description);
    }

    public List<Book> getUserBooks(int libId)
    {
      setBooks();

      string pathFile = "G:\\LovelyLibDataFiles\\LibsBooks.txt";

      if (!File.Exists(pathFile))
      {
        File.Create(pathFile).Close();
      }

      var ourBooks = File.ReadAllLines(pathFile).Where(s => s.Split(' ').Contains(libId.ToString()));
      List<Book> currentBooks = new List<Book>();
      foreach (var i in ourBooks)
      {
        string[] s = i.Split(' ');
        Book currentBook = new Book();
        currentBook = deterBook[s[1]];
        currentBook.date = s[2];
        currentBooks.Add(currentBook);
      }

      return currentBooks;
    }

    public bool addBookToLib(string bookName, Lib currentLib)
    {
      string pathFile = "G:\\LovelyLibDataFiles\\LibsBooks.txt";
      FileStream file = new FileStream(pathFile, FileMode.Open);
      StreamReader streamReader = new StreamReader(file);

      while (!streamReader.EndOfStream)
      {
        string[] currentData = streamReader.ReadLine().Split(' ');

        if (currentData[0] == currentLib.id.ToString() && currentData[1] == bookName.Replace(" ",""))
        {
          streamReader.Close();
          file.Close();

          return false;
        }
      }
      streamReader.Close();
      file.Close();

      File.AppendAllText(pathFile, currentLib.id + " " + bookName.Replace(" ", "") + " " + DateTime.Now.ToShortDateString() + '\n');
      return true;
    }

    public void deleteBookFromLib(string bookName, Lib currentLib)
    {
      string pathFileLib = "G:\\LovelyLibDataFiles\\LibsBooks.txt";
      File.WriteAllLines(pathFileLib, File.ReadAllLines(pathFileLib).Where(s => !(s.Contains(bookName.Replace(" ", "")) && s.Contains(currentLib.id.ToString()))));
    }

    public List<Book> getAllBooks()
    {
      setBooks();

      List<Book> currentBooks = new List<Book>();
      foreach (var i in deterBook)
      {
        currentBooks.Add(i.Value);
      }

      return currentBooks;
    }

    public Book getBook(string bookName)
    {
      setBooks();
      Book currentBook = new Book();

      foreach (var i in deterBook)
      {
        if (i.Value.name == bookName)
        {
          currentBook = i.Value;
          break;
        }
      }

      return currentBook;
    }

    public Book getBookFromLib(string bookName, Lib currentLib)
    {
      setBooks();
      Book currentBook = new Book();

      foreach (var i in deterBook)
      {
        if (i.Value.name == bookName)
        {
          currentBook = i.Value;
          break;
        }
      }

      string pathFileLib = "G:\\LovelyLibDataFiles\\LibsBooks.txt";
      List <string> q = File.ReadAllLines(pathFileLib).Where(s => (s.Contains(bookName.Replace(" ", "")) && s.Contains(currentLib.id.ToString()))).ToList();
      currentBook.date = q[0].Remove(0, q[0].Length - 10);

      return currentBook;
    }

    public void editBook(string bookName, Book currentBook)
    {
      setBooks();
      string oldPathFile = "G:\\LovelyLibDataFiles\\books\\" + bookName + ".txt";
      if (File.Exists(oldPathFile))
      {
        File.Delete(oldPathFile);
      }

      string newPathFile = "G:\\LovelyLibDataFiles\\books\\" + currentBook.name.Replace(" ", "") + ".txt";
      File.Create(newPathFile).Close();
      File.AppendAllText(newPathFile, currentBook.name + '\n');
      File.AppendAllText(newPathFile, currentBook.author + '\n');
      File.AppendAllText(newPathFile, currentBook.genre + '\n');
      File.AppendAllText(newPathFile, currentBook.cost.ToString() + '\n');
      File.AppendAllText(newPathFile, currentBook.description);
    }

    public void deleteBook(string bookName)
    {
      string pathFileTxt = "G:\\LovelyLibDataFiles\\books\\" + bookName.Replace(" ", "") + ".txt";

      FileInfo fileINfoText = new FileInfo(pathFileTxt);
      if (fileINfoText.Exists)
      {
        fileINfoText.Delete();
      }

      string pathFileJpg = "G:\\LovelyLibDataFiles\\booksImages\\" + bookName + ".jpg";

      FileInfo fileINfoJpg = new FileInfo(pathFileJpg);
      if (fileINfoJpg.Exists)
      {
        fileINfoJpg.Delete();
      }

      string pathFileLib = "G:\\LovelyLibDataFiles\\LibsBooks.txt";
      File.WriteAllLines(pathFileLib, File.ReadAllLines(pathFileLib).Where(s => !s.Contains(bookName.Replace(" ", ""))));
    }
  }
}
