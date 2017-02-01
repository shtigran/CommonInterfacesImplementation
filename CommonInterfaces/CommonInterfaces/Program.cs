using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommonInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Point p3 = new Point(100, 100);
      Point p4 = (Point)p3.Clone();
      p4.X = 0;
      Console.WriteLine(p3);
      Console.WriteLine(p4);
      Console.WriteLine(p3.CompareTo(p4));

      Point p1 = new Point();
      foreach (int i in p1)
      {

        Console.WriteLine(i);
      }

      Console.ReadKey();


    }

    public class Point : ICloneable, IComparable, IEnumerable
    {
      public int X { get; set; }
      public int Y { get; set; }
      int[] numbers = new int [3];
      public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
      public Point()
       {
        numbers[0] = 5;
        numbers[1] = 7;
        numbers[2] = 8;
      }

      // Implement the ICloneable Interface
      public object Clone()
      { return new Point(this.X, this.Y); } 
     
    
      // Override ToString()
      public override string ToString()
      { return string.Format("X = {0}; Y = {1}", X, Y); }

      // Implement the IComparable Interface
     
      public int CompareTo(object obj)
      {
        Point another = (Point)obj;
        if (this.X > another.X) return -1;
        if (this.X == another.X) return 0;
        return 1;
      }
      // Implement the IEnumerable Interface
      public IEnumerator GetEnumerator()
      {
        return numbers.GetEnumerator();
      }
    }


  }
}
