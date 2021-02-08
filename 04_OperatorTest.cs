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
      // .ToString(value, toBase). toBase = 2 is used to convert the int into
      // its binary representation.
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
    }

    void MiscellaneousOperatorTest() {
      bool z;
      string s = "hello";
      // sizeof only works on datatypes with fixed sizes. This includes all
      // numerical datatypes and char but not string. It only works on string
      // in an unsafe context.
      Console.WriteLine("sizeof: " + sizeof(char));
      // typeof returns the namespace and class of an object. It only works on
      // the class object and not any of its instances. For example, it works
      // on int but not an int variable. The Type variable is sometimes used
      // to store the return value of typeof.
      Dog milo = new Dog();
      Type t = typeof(Dog);
      Console.WriteLine("milo is typeof: " + t);
      // .GetType() can be used to determine the type of variable in
      // combination with typeof(). However, is is more often better suited for
      // this purpose.
      z = (milo.GetType() == t);
      Console.WriteLine("milo typeof Dog?: " + z);
      // A .GetType() and typeof combination returns false on a subclass.
      z = (milo.GetType() == typeof(Animal));
      Console.WriteLine("milo typeof Animal?: " + z);
      // Is works very much like a .GetType() and typeof combination, with one
      // key difference. It will return true if the target is a subclass.
      z = milo is Animal;
      Console.WriteLine("is milo an animal?: " + z);

      // In C# 7.0, is supports pattern matching. This means in if statements
      // such as, if (target is type var), one can assign a temp var for use
      // within the if statement if it returns true.
      // if (s is string v) {
      //   Console.WriteLine("s length = " + v.Length);
      // }
      // throw new ArgumentException("s is not a string.");

      // The alternative to is pattern matching is to use as. as is like is,
      // but it does not return an error if it fails.
      var v = s as string;
      if (s == null) {
        throw new ArgumentException("s is not a string.");
      }
      Console.WriteLine("s length = " + v.Length);
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

  class Animal {}

  // Dog is a subclass of Animal.
  class Dog : Animal {}
}
