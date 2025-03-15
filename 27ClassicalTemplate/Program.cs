using System.Runtime.Serialization;

namespace _27ClassicalTemplate;
/*
This is the old style of Writing a C# program
i.e the Classical template of a C# program
in This way we are using Top Level Statement therefore everything is defined by statements

Namespace: namespace in C# is used to organize code,
and is primarily a way to bundle related classes or other types under a unique name.
Think of it as a folder on your computer that helps you organize files here.
_27ClassicalTemplate is the name of the namespace.
All code that is part of this namespace will be enclosed within curly brackets.
*/

public class Program
/*
Program is just the name of our class.
class keyword here tells C# that you are defining a
class.
class is like a blueprint from which objects are created.It holds Data and Methods
*/
{  public int myResult;
    static void Main(string[] args)
    {
    /* 
    This is a Main Method that has string[] args as the parameter
    static means that this method belongs to the class itself and not to any instance of the class.
    So you don't need to create an object of the class to use this method.
    This just means that we can run this main method without having to manually call it, and without having
    to create an object of our class program. 
    The main method is just the entry point into our software.
    So it's really when you start running your application, it's going to search for the main method,
    and then it will execute whatever is inside of the main method.
    So if you have code that is outside of the main method, but never is called inside of the main method,
    it will not be executed.
    */
    int myResult;
    System.Console.WriteLine("Enter a Value");
    int num1 = int.Parse(Console.ReadLine());
    myResult = AddValue(num1, 10);
    System.Console.WriteLine($"We are adding 10 to the entered value resulting {myResult}");
    }
    static int AddValue(int value1, int value2){
    /*So the static keyword allows us to define this method and use the method without
    having to create an object of the program CSfile.
    */
    int sum = value1 + value2;
    return sum; 
    }
}
