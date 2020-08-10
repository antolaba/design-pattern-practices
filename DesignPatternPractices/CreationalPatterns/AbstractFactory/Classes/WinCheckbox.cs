using System;

namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class WinCheckbox : ICheckbox
  {
    public void OnCheck()
    {
      Console.WriteLine("Check WinCheckbox!");
    }

    public void Render()
    {
      Console.WriteLine("Render a WinCheckbox!");
    }
  }
}