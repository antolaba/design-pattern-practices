namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class MargheritaPizzaBuilder : IBuilder
  {
    private MargheritaPizza pizza;

    public MargheritaPizzaBuilder()
    {
      this.Reset();
    }
    public void Reset()
    {
      this.pizza = new MargheritaPizza();
    }

    public MargheritaPizza GetProduct()
    {
      MargheritaPizza result = this.pizza;
      this.Reset();
      return result;
    }
    public void SetCost(double cost)
    {
      this.pizza.Cost = cost;
    }

    public void SetDough(Dough dough)
    {
      this.pizza.Dough = dough;
    }

    public void SetOuncesMozzarrella(int ounces)
    {
      this.pizza.OuncesMozzarrella = ounces;
    }

    public void SetSauce(Sauce sauce)
    {
      this.pizza.Sauce = sauce;
    }
  }
}