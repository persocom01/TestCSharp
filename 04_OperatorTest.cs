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

    void RelationalOperatorTest() {
      int x;
      double y;
      bool z;
      x = 1;
      y = 1.0;
      // == works between int and double.
      z = y == x;
      Console.WriteLine("==: " + z);
      z = y != x;
      Console.WriteLine("!=: " + z);
      z = y > x;
      Console.WriteLine(">: " + z);
      z = y <= x;
      Console.WriteLine("<=: " + z);
    }

    void LogicalOperatorTest() {
      // Logical operators only work between bool variables in testing.
      bool x = true;
      bool y = false;
      bool z;
      // && == and
      z = y && x;
      Console.WriteLine("&&: " + z);
      // || == or
      z = y || x;
      Console.WriteLine("||: " + z);
      // ! == not
      z = !(y && x);
      Console.WriteLine("!: " + z);
      // While not a logical operator, instanceof is used to check if a variable
      // belongs to a particular class. It generally does not work on primitive
      // data types except strings.
      string s = "word";
      z = s is string;
      Console.WriteLine("is: " + z);
    }

    void BitwiseOperatorTest() {
      // Bitwise operators can only be applied to the integer datatypes:
      // byte, short, int, long, char.
      // It works on bits, which can be seen if the numbers are converted to
      // binary.
      // Assignment operators exist for all bitwise operators except ~ and >>>.
      // This means statements like:
      // y = y&x
      // can be written as:
      // y &= x
      int x = 60;
      int y = 13;
      int z;
      string s;
      s = String.Format("{0, 7}", Convert.ToString(x, 2)).Replace(' ', '0');
      Console.WriteLine("binary 60: " + s);
      s = String.Format("{0, 7}", Convert.ToString(y, 2)).Replace(' ', '0');
      Console.WriteLine("binary 13: " + s);
      // & copies bits that are the same in both.
      z = x&y;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine("&: " + s);
      // & copies bits as long as they occur in one.
      z = x|y;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine("|: " + s);
      // ^ copies bits that occur in one or the other but not both.
      z = x^y;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine("^: " + s);
      // ~ gives the compliment of the int, which is in this case -61.
      z = ~x;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine("~: " + s);
      // Shifts the bits left.
      z = x<<1;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine("<<: " + s);
      // Shifts the bits right.
      z = x>>1;
      s = String.Format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      Console.WriteLine(">>: " + s);
      // Shifts the bits right and replaces the empty spaces with 0.
      // z = x>>>1;
      // s = String.format("{0, 7}", Convert.ToString(z, 2)).Replace(' ', '0');
      // Console.WriteLine(">>>: " + s);
    }

    void MiscellaneousOperatorTest() {
      // While not a logical operator, instanceof is used to check if a variable
      // belongs to a particular class. It generally does not work on primitive
      // data types except strings.
      // string s = "word";
      // z = s is string;
      // Console.WriteLine("is: " + z);
    }

    static void Main(string[] args) {
      OperatorTest ot = new OperatorTest();
      ot.ArithmeticOperatorTest();
      Console.WriteLine();
      ot.RelationalOperatorTest();
      Console.WriteLine();
      ot.LogicalOperatorTest();
      Console.WriteLine();
      ot.BitwiseOperatorTest();
      Console.WriteLine();
      ot.MiscellaneousOperatorTest();
    }
  }
}
