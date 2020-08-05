using System;
namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class Director
  {
    private IBuilder builder;

    public IBuilder Builder
    {
      set { this.builder = value; }
    }

    public Director()
    {
    }

    public void buildMargheritaPizza()
    {
      this.builder.SetOuncesMozzarrella(4);
      this.builder.SetSauce(new Sauce()
      {
        Name = "Marinara sauce"
      });
      this.builder.SetCost(12.00);
      this.builder.SetDough(new Dough()
      {
        Name = "Neapolitan Pizza Dough"
      });
    }

    public void builCheeseQuiche()
    {
      this.builder.SetDough(new Dough()
      {
        Name = "Quiche dough"
      });
      this.builder.SetOuncesMozzarrella(2);
    }


  }
}
