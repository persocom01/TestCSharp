// Demonstrates the C# data types.
using System;
// Required to use CultureInfo. Alternatively, append System.Globalization. in
// front of CultureInfo.
using System.Globalization;

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

    // Lists all cultures available in CultureInfo.
    void ListCultures() {
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      // {index, padding} is used to add padding to the printed string. A +ve
      // padding value adds padding to the left, a -ve adds it to the right.
      Console.WriteLine("{0,-15}{1,-5}{2,-45}{3,-40}", "Culture", "ISO",
                "Display name", "English Name");

      foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
      {
        Console.Write("{0,-15}", ci.Name);
        Console.Write("{0,-5}", ci.TwoLetterISOLanguageName);
        Console.Write("{0,-45}", ci.DisplayName);
        Console.WriteLine("{0,-40}", ci.EnglishName);
      }
    }

    void DateTimeTest(string[] s, string code, string format) {
      CultureInfo c = new CultureInfo(code);

      Console.WriteLine("date conversions");

      for (int i = 0; i < s.Length; i++) {
        DateTime d = Convert.ToDateTime(s[i], c);
        // A DateTime object can be printed on its own, or one can use an exact
        // format.
        // Console.WriteLine(d);
        string custom = d.ToString(format);
        Console.WriteLine(custom);
      }
    }

    void DateTimeParseExactTest(string date, string format) {
      DateTime d = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
      Console.WriteLine("ParseExact: " + d);
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
      Console.WriteLine("char: " + dt.c);
      Console.WriteLine("string: " + dt.stringLiteral);
      Console.WriteLine();

      dt.PointerTest();
      // This line causes the program to require a key press to close in
      // Visual Studio .NET. This is so that we can see the result instead of
      // the window closing automatically.
      // Console.ReadKey();
      Console.WriteLine();

      // C# supports data type conversion in a manner similar to java.
      // All types will be conerted to string when using the + operator with a
      // string. Note that C# does not support , in Console.WriteLine(). To
      // write multiple things at once + is used.
      Console.WriteLine("int rounds down: " + (int)1.9);
      // Like in java, chars are automatically converted to string and int.
      Console.WriteLine("char to string: " + dt.c);
      Console.WriteLine("char to int: " + (int)dt.c);
      // C# also has a number of builtin conversion methods:
      // https://www.tutorialspoint.com/csharp/csharp_type_conversion.htm
      // Most basic types can be converted to string using the .ToString()
      // method. Note that (string)dataType does not work.
      Console.WriteLine("bool to string: " + dt.isFalse.ToString());
      // To use the other type conversion methods, you need
      // Convert.ToType(targetData). .ToBoolean() is notable for returning true
      // so long as the number is not 0, even if it is -ve.
      // Covert.ToString(type, radix) has a few advantages over its
      // type.ToString counterpart. For one, Covert.ToString would not return
      // an error if the type, such as if it were a user input. In addition,
      // Convert.ToString(value, toBase) is able to convert numbers to
      // different bases. Only the bases 2, 8, 10, and 16 are supported.
      Console.WriteLine("num to boolean: " + Convert.ToBoolean(-1));
      Console.WriteLine("num to string binary representation: " + Convert.ToString(60, 2));
      // .ToBoolean() only works on the strings "true" or "false" regardless of
      // caps, and does not work on char.
      Console.WriteLine("string to boolean: " + Convert.ToBoolean("FALSE"));
      Console.WriteLine();

      string[] date1 = {
        "01/02/09",
        "2009-02-03",
        "01.2009.03",
        "01 02 2009",
        "01/02/23"
      };
      string date2 = "1 dec 2020";
      string cultureCode = "en-US";
      // Find the date format string here:
      // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings?redirectedfrom=MSDN
      string customFormat = "d MMM yyyy";
      // dt.ListCultures();
      dt.DateTimeTest(date1, cultureCode, customFormat);
      dt.DateTimeParseExactTest(date2, customFormat);
    }
  }
}
