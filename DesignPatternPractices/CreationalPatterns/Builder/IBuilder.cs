using System;
namespace DesignPatternPractices.CreationalPatterns.Builder
{
    public interface IBuilder
    {
        void Reset();

        void SetCost(double cost);

        void SetOuncesMozzarrella(int ounces);

        void SetSauce(Sauce sauce);

        void SetDough(Dough dough);

    }
}
