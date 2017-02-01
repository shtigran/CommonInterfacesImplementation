# Common Interfaces Implementation
# C#6.0  .NET FRAMEWORK 4.6
----

### Description of ReplaceArm class
This Project illustrate how You can implement the common interfaces (ICloneable, IComparable, IEnumerable) for Your own class.

----

### The Point class and  Interfaces implementation

```C#
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
```
