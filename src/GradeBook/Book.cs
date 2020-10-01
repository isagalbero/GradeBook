using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void Showstatistics()
    {
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

          /*
          if(args.Length > 0)
          {
            Console.WriteLine($"Hello, {args[0]}!");
          }
          else
          {
            Console.WriteLine("Hello");
          }
          */
    }
    
    //Aqui temos "field"
    private List<double> grades;
    private string name;

        
  }
}