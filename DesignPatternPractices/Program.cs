using System;
using DesignPatternPractices.CreationalPatterns;
using DesignPatternPractices.CreationalPatterns.Builder;

namespace DesignPatternPractices
{
  class Program
  {
    static void Main(string[] args)
    {
      IProgramRun program = new BuilderRun();
      program.Run();
    }
  }
}
