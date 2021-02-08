// Demonstrates loops in C#.
using System;
// Needed to use lists.
using System.Collections.Generic;

namespace LoopTestApp {

  class LoopTest {

    void whileLoop(int n) {
      int i = 2;
      int maxRange = (int)Math.Sqrt(n) + 1;
      bool f = true;
      // while(condition) {code}
      while(i <= maxRange) {
        if(n%i == 0) {
          f = false;
          // Break causes the loop to terminate.
          break;
        }
        i++;
      }
      if(f) {
        Console.WriteLine(n + " is a prime number");
      } else {
        Console.WriteLine(n + " is not a prime number");
      }
    }

    // Demonstrates a for loop, the continue statement, and how to implement
    // lists in C#.
    void forLoop(int n) {
      int f = 3;
      List<int> factors = new List<int>();
      // for(dataType var = value; condition; increment) {code}
      // for loops include in their implementation the count variable as well as
      // the stop condition, making them safer than while loops.
      for(int i = 1; i < n; i++) {
        if(i%f == 0) {
          factors.Add(i);
          // Continue ignores the rest of the code in the loop and restarts it.
          // In a while loop, care must be taken to ensure that it doesn't result
          // in an infinite loop due to not incrementing the stop condition.
          continue;
        }
      }
      // Unnecessary, but here's how to convert to array.
      int[] factorsArr = factors.ToArray();
      // Arrays and lists are not automatically converted to string, so .Join()
      // has to be used.
      Console.WriteLine("the multiples of {0} below {1} are {2}.", f, n, string.Join(", ", factorsArr));
    }

    void doWhileLoop(int n) {
      int i = 0;
      // do... while loops are while loops that execute at least once, as the
      // condition whether to repeat the loop is evaluated at the end of the
      // first iteration instead of the beginning.
      do {
        Console.WriteLine(i);
        i++;
      } while(i <= n);
    }

    static void Main(string[] args) {
      LoopTest lt = new LoopTest();
      lt.whileLoop(10);
      lt.forLoop(10);
      lt.doWhileLoop(3);
    }
  }
}
