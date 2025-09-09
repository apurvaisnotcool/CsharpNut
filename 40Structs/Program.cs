namespace _40Structs;
/*
Structs: structs are value type that are typically used to encapsulate small groups of related 
variables.
Structs are used for small data structures that have value semantics and will not be modified
after creation. Examples like complex numbers, points in a coordinate system, and rgb colors.
if you need inheritance, polymorphism and large data structures classes are typically 
appropriate.
Structs are similar to classes but they differ from the fact that structs are value type whereas
Classes are referenace type. Meaning structs are stored on a stack while classes are stored 
on a heap.
*/

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }


    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        System.Console.WriteLine($"Point: ({X},{Y})");
    }

}

public struct Number
{
    public int A;
    public int B;
    public Number(int a, int b)
    {
        A = a;
        B = b;
    }
    public void Display()
    {
        System.Console.WriteLine($"Numbers: {A}, {B}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        p1.Display();
        //We can assign values in the struct without the new keyword
        Number n1;
        n1.A = 10;
        n1.B = 20;

        n1.Display();
        
    }
}

public class Hello
{
    
}
