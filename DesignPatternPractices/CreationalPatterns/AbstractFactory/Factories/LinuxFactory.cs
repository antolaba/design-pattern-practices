namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public class LinuxFactory : IGUIFactory
  {
    public IButton CreateButton()
    {
      return new LinuxButton();
    }

    public ICheckbox CreateCheckbox()
    {
      return new LinuxCheckbox();
    }
  }
}