namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class MargheritaPizza
  {
    public int OuncesMozzarrella;
    public Sauce Sauce;
    public double Cost;
    public Dough Dough;

    public MargheritaPizza()
    {
    }
    public override string ToString()
    {
      return $"Margherita Pizza: Cost {this.Cost}, Sauce {this.Sauce.Name}, Ounces Mozzarrella {this.OuncesMozzarrella}, Dough {this.Dough.Name}";
    }
  }
}