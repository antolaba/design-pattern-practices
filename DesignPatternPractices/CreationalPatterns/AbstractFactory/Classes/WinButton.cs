using System;

namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class WinButton : IButton
  {
    public void OnClick()
    {
      Console.WriteLine("Click WinButton!");
    }

    public void Render()
    {
      Console.WriteLine("Render a WinButton!");
    }
  }
}