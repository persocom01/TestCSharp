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
      string text = "Hello World";
      // Console comes from System.
      Console.WriteLine(text);
      // This line causes the program to require a key press to close in
      // Visual Studio .NET. This is so that we can see the result instead of
      // the window closing automatically.
      // Console.ReadKey();
    }
  }
}