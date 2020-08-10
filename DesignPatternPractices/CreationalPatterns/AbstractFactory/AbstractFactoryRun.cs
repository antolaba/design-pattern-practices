using System;

namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class AbstractFactoryRun : IProgramRun
  {
    public void Run()
    {
      IGUIFactory factory;
      Console.WriteLine("Absctract Factory");
      factory = new WinFactory();
      factory.CreateButton().Render();
      factory.CreateCheckbox().Render();
      factory = new LinuxFactory();
      factory.CreateButton().Render();
      factory.CreateCheckbox().Render();
    }
  }
}