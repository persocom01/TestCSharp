// Demonstrates if and switch statements in C#.
using System;

namespace IfTestApp {

  class IfTest {

    // enum is a special data type in C#, whose value falls within a pre
    // defined set of values. It is similar to a dictionary in python.
    enum Direction {
      north,
      south,
      east,
      west,
      home
    }

    void ifTest(int n) {
      // if(condition) {code}
      if(n >= 0) {
        Console.WriteLine(n + " is a positive number");
      }
    }

    void ifElseTest(int n) {
      // if(condition) {code} else {code}
      if(n%2 == 0) {
        Console.WriteLine(n + " is an even number");
      } else {
        Console.WriteLine(n + " is an odd number");
      }
    }

    void switchTest(Direction d) {
      // switch(var) {
      // case value:
      //  code;
      //  break;
      // default:
      //  code;
      //  break;
      // }
      // switch only accepts int types, char, String and enum as variables.
      switch(d) {
        // Unlike in java, enum case does not use their unqualified names. This
        // means Direction.north instead of north
        case Direction.north:
        // {} are optional. You need them if declaring a new variable within
        // the case statement though.
        {
          Console.WriteLine(d + " is where the polar bears live");
          break;
        }
        case Direction.south:
          Console.WriteLine(d + " is where a continent lies encased in ice.");
          break;
        case Direction.east:
          Console.WriteLine(d + " is where the sun rises.");
          break;
        case Direction.west:
          Console.WriteLine(d + " is where the sun sets.");
          break;
        default:
          Console.WriteLine(d + " is where your heart is.");
          // java does not need a break in the default statement, but C# will
          // return an error if it is not present.
          break;
      }

      // C# 8.0 introduces a shorter way to write switch statements. The
      // equivalent of the above is as follows:
      // d switch {
      //   Direction.north  => Console.WriteLine(d + " is where the polar bears live"),
      //   Direction.south  => Console.WriteLine(d + " is where a continent lies encased in ice."),
      //   Direction.east   => Console.WriteLine(d + " is where the sun rises."),
      //   Direction.west   => Console.WriteLine(d + " is where the sun sets."),
      //   _                => Console.WriteLine(d + " is where your heart is."),
      // }
    }

    static void Main(string[] args) {
      IfTest it = new IfTest();
      it.ifTest(10);
      it.ifElseTest(10);
      it.switchTest(Direction.north);
      it.switchTest(Direction.south);
      it.switchTest(Direction.east);
      it.switchTest(Direction.west);
      it.switchTest(Direction.home);
    }
  }
}
