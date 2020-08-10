namespace DesignPatternPractices.CreationalPatterns.FactoryMethod
{
  public abstract class Creator
  {
    public abstract IProduct FactoryMethod();

    // Some core business logic
    public string SomeOperation()
    {
      IProduct product = this.FactoryMethod();
      return product.Operation();
    }
  }
}