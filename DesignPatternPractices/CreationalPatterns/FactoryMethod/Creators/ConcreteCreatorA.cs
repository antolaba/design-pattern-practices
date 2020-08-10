namespace DesignPatternPractices.CreationalPatterns.FactoryMethod
{
  public class ConcreteCreatorA : Creator
  {
    public override IProduct FactoryMethod()
    {
      return new ProductA();
    }
  }
}