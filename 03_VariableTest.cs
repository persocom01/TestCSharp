// Demonstrates variables in C#.
using System;

namespace VariableTestApp {

  class VariableTest {

    static void Main(string[] args) {
      // Variables can be declared with or without initialization.
      int uninitialized;
      int initialized = 0;
      // Multiple variables can be declared in the same line.
      int m1 = 1, m2 = m1 * 2;

      // uninitialized = Convert.ToInt32(Console.ReadLine());

      // uninitialized variables, cannot be printed.
      // Console.WriteLine("uninitialized: " + uninitialized);
      Console.WriteLine("initialized: " + initialized);
      Console.WriteLine("var1: " + m1 + ", var2: " + m2);
    }
  }
}
