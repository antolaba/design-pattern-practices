using System;

namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class LinuxButton : IButton
  {
    public void OnClick()
    {
      Console.WriteLine("Click LinuxButton!");
    }

    public void Render()
    {
      Console.WriteLine("Render a LinuxButton!");
    }
  }
}