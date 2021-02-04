// Demonstrates a basic C# program.
// The naming convention in C# is PascalCase in most cases.
// Private variables use _camelCase, note the underscore at the start.
// Public, local variables and method arguments (called parameters in C#) use
// camelCase.
// Interfaces use IPascalCase, note the I at the start.

// using is the C# version of import.
using System;

// A namespace is a collection of classes.
namespace BasicTestApp {

  // A class can be thought as a collection of methods.
  // By convention, the file name takes the name of the main class.
  class BasicTest {
    static void Main(string[] args) {
      // C# is case sensitive. Identifiers cannot start with a number and
      // cannot contain special characters except for _ and @.
      // Java has a list of keywords that cannot be used as identifiers The
      // list can be found here:
      // https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm
      // You can append @ to the start of a keyword if you insist on using it
      // as an identifer.
      string text = "Hello";
      // Console comes from System. .WriteLine() writes to the console While
      // automatically adding \n to the end. .Write() does the same thing
      // Without this behavior. In C#, .WriteLine() can be used to format
      // strings in a manner similar to python f strings, and not just
      // String.Format(). A string format cheatsheet can be found here:
      // http://independent-software.com/net-string-formatting-in-csharp-cheat-sheet.html
      Console.WriteLine("{0} World", text);
      // This line causes the program to require a key press to close in
      // Visual Studio .NET. This is so that we can see the result instead of
      // the window closing automatically.
      // Console.ReadKey();
    }
  }
}
