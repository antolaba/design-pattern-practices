using System;

namespace DesignPatternPractices.CreationalPatterns.Singleton
{
  public class Database
  {
    private static Database _instance;
    private Database()
    {
      Console.WriteLine("Start a new database connection");
    }

    public static Database GetInstance()
    {
      if (_instance == null)
      {
        _instance = new Database();
      }
      return _instance;
    }

    public void runSQl(String query)
    {
      Console.WriteLine("Running:{0}", query);
    }
  }
}