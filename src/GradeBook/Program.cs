using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book();
          book.AddGrade(89.1);  

          var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
          grades.Add(56.1);

          var result = 0.0;
          var highGrade = double.MinValue;
          var lowGrade = double.MaxValue;

          foreach(var number in grades)
          {
            highGrade = Math.Max(number, highGrade);
            lowGrade = Math.Min(number, lowGrade);
            result += number;
              
          }
          result /= grades.Count;

          Console.WriteLine($"O valor da média é {result:N2}");
          Console.WriteLine($"Valor máximo: {highGrade}");
          Console.WriteLine($"Valor máximo: {lowGrade}");


          if(args.Length > 0)
          {
            Console.WriteLine($"Hello, {args[0]}!");
          }
          else
          {
            Console.WriteLine("Hello");
          }
        }
        
        
    }
}
