# Common Interfaces Implementation
# C#6.0  .NET FRAMEWORK 4.6
----

### The Interfaces implementation

```C#
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
