using System;
using DesignPatternPractices.CreationalPatterns;
using DesignPatternPractices.CreationalPatterns.Builder;
using DesignPatternPractices.CreationalPatterns.FactoryMethod;
using DesignPatternPractices.CreationalPatterns.AbstractFactory;
using DesignPatternPractices.CreationalPatterns.Singleton;

namespace DesignPatternPractices
{
  class Program
  {
    static void Main(string[] args)
    {
      // IProgramRun program = new BuilderRun();
      // IProgramRun program = new FactoryRun();
      //IProgramRun program = new AbstractFactoryRun();
      IProgramRun program = new SingletonRun();
      program.Run();
    }
  }
}
