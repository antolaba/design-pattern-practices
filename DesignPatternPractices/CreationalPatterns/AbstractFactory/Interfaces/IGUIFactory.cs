namespace DesignPatternPractices.CreationalPatterns.AbstractFactory
{
  public interface IGUIFactory
  {
    public IButton CreateButton();

    public ICheckbox CreateCheckbox();
  }
}