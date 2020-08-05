namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class CheeseQuicheBuilder : IBuilder
  {
    private CheeseQuiche quiche;

    public CheeseQuicheBuilder()
    {
      this.Reset();
    }
    public void Reset()
    {
      this.quiche = new CheeseQuiche();
    }

    public CheeseQuiche GetProduct()
    {
      CheeseQuiche result = this.quiche;
      this.Reset();
      return result;
    }
    public void SetCost(double cost)
    {
      throw new System.NotImplementedException();
    }

    public void SetDough(Dough dough)
    {
      this.quiche.Dough = dough;
    }

    public void SetOuncesMozzarrella(int ounces)
    {
      this.quiche.OuncesMozzarrella = ounces;
    }

    public void SetSauce(Sauce sauce)
    {
      throw new System.NotImplementedException();
    }
  }
}