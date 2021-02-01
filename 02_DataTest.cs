// Demonstrates the C# data types.
using System;

namespace DataTestApp {

  class DataTest {
    bool isFalse = false;
    // Bytes can only be positive.
    byte byteMax = 255;
    // sbytes extend in the -ve direction by the same number +1. (-128)
    // Other data types extend both ways unless stated otherwise in a similar
    // fashion.
    sbyte sbyteMax = 127;
    // Approx. A decimal is defined by a trailing M. The range of numbers
    // acceptable as decimals < float < double.
    decimal deciMax = 7.9228M * (decimal)Math.Pow(10, 28);
    // Numbers with decimal places are by default double in C#.
    // Similar to java, 1 / 3 will return 0 as both numbers are considered int.
    // Using a decimal place or a trailing D converts it to double.
    double doubleEx = 1 / 3.0;
    float floatEx = 1F / 3;
    // Integers are by default int.
    int intMax = 2147483647;
    // uint can be thought of as the +ve only version of int.
    uint uintMax = 4294967295;
    // long is defined by a trailing L. int can be converted to long.
    long longMax = 9223372036854775807;
    // ulong can be thought of as the +ve only version of long.
    ulong	ulongMax = 18446744073709551615;
    short	shortMax = 32767;
    // ushort can be thought of as the +ve only version of short.
    ushort ushortMax = 65535;

    // object is the base class of all datatypes in C#. An object type can be
    // converted to any other datatype and any other datatype can be converted
    // to the object ype. The former is called "boxing" and the latter
    // "unboxing".
    object obj = "object";
    // The dynamic type is like object, however, it is assumed to be of any
    // type when the code is compiled. For example, obj.ToUpper() will return
    // an error, because obj is not a string. However, dyn.ToUpper() will not.
    dynamic dyn = "dynamic";
    // A char is a single character. It can be a letter, number, or one of the
    // unicode escape sequences like '\u0000'. char is in single quotes '' while
    // string is in double quotes "". They are not interchangable. A list of
    // unicode chars can be found here:
    // https://www.rapidtables.com/code/text/unicode-characters.html
    char c = '\u0063';
    // string is an object in C#, and comes with several methods. Using @
    // before a tring code makes it the equivalent of a python raw string.
    string stringLiteral = @"c:\Program Files\Microsoft Visual Studio";

    // Pointers are a type of variable that point to addresses of other
    // variables. They can only be run in unsafe mode, which is dangerous
    // unless you are sure that the code is completely safe. The advantage of
    // using pointers is the performance advantage of not paying the cost for
    // safety features. However, it is not recommended that you use unsafe code
    // at all.
    // unsafe can be used in the method name instead of a block. When used as
    // a method, the method is capable of accepting pointers as arguments.
    void PointerTest() {
      // One way to write unsafe code is to use an unsafe block.

      // unsafe {
      //   int i = 1;
      //   // & here means the memory address of.
      //   int* iPtr = &i;
      //   // Displays the pointer value.
      //   Console.WriteLine(*iPtr);
      //   // Displays the pointer address.
      //   Console.WriteLine((int)iPtr);
      // }

      Console.WriteLine(@"unsafe code can only be run when compiling with /unsafe");
    }

    static void Main(string[] args) {
      DataTest dt = new DataTest();
      Console.WriteLine("boolean: " + dt.isFalse);
      Console.WriteLine("byte: " + dt.byteMax);
      Console.WriteLine("sbyte: " + dt.sbyteMax);
      Console.WriteLine("decimal: " + dt.deciMax);
      Console.WriteLine("double: " + dt.doubleEx);
      Console.WriteLine("float: " + dt.floatEx);
      Console.WriteLine("int: " + dt.intMax);
      Console.WriteLine("uint: " + dt.uintMax);
      Console.WriteLine("long: " + dt.longMax);
      Console.WriteLine("ulong: " + dt.ulongMax);
      Console.WriteLine("short: " + dt.shortMax);
      Console.WriteLine("ushort: " + dt.ushortMax);
      Console.WriteLine();

      Console.WriteLine("object: " + dt.obj);
      Console.WriteLine("dynamic: " + dt.dyn.ToUpper());
      // Like java, chars are treated as int when added, and can be converted
      // to int.
      Console.WriteLine("char: " + (int)dt.c);
      Console.WriteLine("string: " + dt.stringLiteral);
      Console.WriteLine();

      dt.PointerTest();
      // This line causes the program to require a key press to close in
      // Visual Studio .NET. This is so that we can see the result instead of
      // the window closing automatically.
      // Console.ReadKey();
    }
  }
}
