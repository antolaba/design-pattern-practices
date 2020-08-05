namespace DesignPatternPractices.CreationalPatterns.Builder
{
  public class CheeseQuiche
  {
    public int OuncesMozzarrella;
    public Dough Dough;

    public CheeseQuiche()
    {

    }
    public override string ToString()
    {
      return $"CheeseQuiche: Ounces Mozzarrella {this.OuncesMozzarrella}, Dough {this.Dough.Name}";
    }
  }
}