using System;

namespace DesignPatternPractices.CreationalPatterns.Singleton
{
  public class SingletonRun : IProgramRun
  {
    public void Run()
    {
      Console.WriteLine("Singleton pattern");
      Database db = Database.GetInstance();
      db.runSQl("SELECT * FROM DESIGN_PATTERNS");
      //...
      //...
      //...
      Database newDb = Database.GetInstance();
      newDb.runSQl("INSERT INTO DESIGN_PATTERNS('SINGLETON')");
    }
  }
}