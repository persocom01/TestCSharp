// Demonstrates variables in C#.
using System;

namespace OperatorTestApp {

  class OperatorTest {

    void ArithmeticOperatorTest() {
      int x;
      double y;
      // C# automatically converts int to double when an operation occurs
      // between mixed types but not the other way round, even if the double
      // is 1.0. However, unlike java, a 1.0 double will print as 1.
      // Assignment operators exist for all arithmetic operators except ++ and
      // --. This means statements like:
      // y = y + x
      // can be written as:
      // y += x
      y = 1.0 + 1 - 1;
      Console.WriteLine("addition/subtraction:\n" + y);
      // int is automatically rounded down during division.
      x = 9 * 10 / 100;
      // Even if the data type is double, if the operation where the decimal is
      // supposed to occur (90/100) is done between ints, the number is rounded
      // down before being converted to a decimal
      y = 9 * 10 / 100 * 2.0;
      Console.WriteLine("multiplication/division\n" + x + "\n" + y);
      // To prevent this, make the operations that go first all doubles, or make
      // all the numbers doubles.
      y = 9.0 * 10 / 100 * 2;
      Console.WriteLine(y);
      x = 10 % 4;
      Console.WriteLine("modulus:\n" + x);
      x = 1;
      // If ++ or -- is before the variable, 1 is added to the variable before
      // the statement is evaluated. This is why y == 2.0 and not y == 1.0, while
      // x == 2 is always true after the statement.
      y = ++x;
      Console.WriteLine("pre increment:\n" + y);
      x = 1;
      y = x++;
      Console.WriteLine("post increment:\n" + y);
      // Not an operator, but this is how to do power if it is needed.
      x = 2;
      y = Math.Pow(x, 8);
      Console.WriteLine("power:\n" + y);
    }

    static void Main(string[] args) {
      OperatorTest ot = new OperatorTest();
      ot.ArithmeticOperatorTest();
    }
  }
}
