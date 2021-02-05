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
      // int can be written in hexadecimal notation, indicated by the 0x prefix.
      // To write as a long add an L to the end.
      int hexInt = 0xfee;
      // doubles or floats can be written in exponential notation indicated by
      // e or E. To write as a float add a F to the end.
      double expDouble = 3.14159e-5;

      // Lets the user input a value.
      // uninitialized = Convert.ToInt32(Console.ReadLine());

      // uninitialized variables, cannot be printed.
      // Console.WriteLine("uninitialized: " + uninitialized);
      Console.WriteLine("initialized: " + initialized);
      Console.WriteLine("var1: " + m1 + ", var2: " + m2);
      // Hexadecimal is base 16.
      Console.WriteLine("hexInt: {0} -> {1}", Convert.ToString(hexInt, 16), hexInt);
      Console.WriteLine("expdouble: {0} -> {1}", expDouble.ToString("e"), expDouble);
    }
  }
}

// C# supports special escape (\) characters as defined below:
// \n	new line
// \r	carriage return
// \f	form feed
// \b	backspace
// \t	horizontal tab
// \v	vertical tab
// \"	double quote
// \'	single quote
// \? question mark
// \a alert or bell
// \\	backslash
// \xhh	hexadecimal character
