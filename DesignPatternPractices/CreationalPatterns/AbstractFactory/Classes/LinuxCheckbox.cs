using System;

namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class LinuxCheckbox : ICheckbox
  {
    public void OnCheck()
    {
      Console.WriteLine("Check LinuxCheckbox!");
    }

    public void Render()
    {
      Console.WriteLine("Render a LinuxCheckbox!");
    }
  }
}