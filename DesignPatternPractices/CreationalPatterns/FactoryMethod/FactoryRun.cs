using System;

namespace DesignPatternPractices.CreationalPatterns.FactoryMethod
{
  public class FactoryRun : IProgramRun
  {
    public void Run()
    {
      Console.WriteLine("FactoryMethod pattern");
      Console.WriteLine("Abstract Creator");
      Creator creator;
      creator = new ConcreteCreatorA();
      Console.WriteLine(creator.SomeOperation());
      creator = new ConcreteCreatorB();
      Console.WriteLine(creator.SomeOperation());
      Console.WriteLine("Concrete Creator");
      IProduct product = ConcreteCreator.FactoryMethod(nameof(ProductB));
      Console.WriteLine(product.Operation());
    }
  }
}