using System;
using DesignPatternPractices.CreationalPatterns;

namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class BuilderRun : IProgramRun
  {

    public void Run()
    {
      Console.WriteLine("Builder Patterner");

      Director director = new Director();

      MargheritaPizzaBuilder margheritaPizzaBuilder = new MargheritaPizzaBuilder();

      CheeseQuicheBuilder cheeseQuicheBuilder = new CheeseQuicheBuilder();

      director.Builder = margheritaPizzaBuilder;

      Console.WriteLine("Build Margherita Pizza");

      director.buildMargheritaPizza();

      MargheritaPizza margheritaPizza = margheritaPizzaBuilder.GetProduct();

      Console.WriteLine(margheritaPizza.ToString());

      Console.WriteLine("Build Cheese Quiche");

      director.Builder = cheeseQuicheBuilder;

      director.builCheeseQuiche();

      CheeseQuiche cheeseQuiche = cheeseQuicheBuilder.GetProduct();

      Console.WriteLine(cheeseQuiche.ToString());

      Console.ReadLine();
    }
  }
}
