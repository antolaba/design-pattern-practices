namespace DesignPatternPractices.CreationalPatterns.FactoryMethod
{
  public class ConcreteCreator
  {
    public static IProduct FactoryMethod(string productName)
    {
      switch (productName)
      {
        case nameof(ProductA):
          return new ProductA();
        case nameof(ProductB):
          return new ProductB();
        default:
          return null;
      }
    }

  }
}