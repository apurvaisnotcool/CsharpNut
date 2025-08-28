using System.Data;
using System.Runtime.CompilerServices;

namespace _30Class_n_Objects;
/*
Class: a class is a blueprint of an object.
And that's where this object oriented programming comes from.
So pretty much you can create multiple objects of a specific class that you can create yourself.
And we even have used classes already, as you know, for example, the console class or the string
class and so forth.


It has properties so called member variables such as length.
We have seen the length property of one class.
And that was our string class where we checked how long is the string

Inheritance is possible with classes.

They can be used like a data type.
For example, a string is a class and we have used strings as data types.


Objects: you can create objects out of a class
For Example A car can be an Object. It has properties such as speed, Mileage etc
The abilities would be to drive, to break, to open a window, make light and so forth, plenty
of abilities.And then finally inheritance would work like that.
You have a car which inherits to Audi.
So an Audi is a car but has specifics.
Then an A5 is an Audi, but has its own specifics and so forth.
So this is just a very brief introduction into object oriented programming and into classes.

ex of inheritance: Car>Audi>r8 

*/
class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi", false);
        Car bmw = new Car("i7", "BMW", true);
        /*This is an Object Created from the Class Car 
        or We are creating an instance of the class car
        It is named audi and it has the properties of a Car
        basically what it does is it allocates space inside of the memory for our car object.
        */
        System.Console.WriteLine("Please enter the Brand name of the car");
        //SETTING Brand
        audi.Brand = Console.ReadLine();//Whatever you enter here is the value keyword used 
                                        // in the property
        System.Console.WriteLine("Please enter another Brand name");
        bmw.Brand = Console.ReadLine();
        //Getting Brand
        System.Console.WriteLine($"You Entered {audi.Brand} as the brand name");
        System.Console.WriteLine($"You Entered {bmw.Brand} as the brand name");

        Hello hello = new Hello();
        //This is an instance or an object of class Hello and we are calling the Fuction Add from 
        //Class hello that is stored in constructorValue variable
        int constructorValue = hello.Add(firstNum: 30, secondNum: 30);
        //this is how we access function from other class
        //firstNum: is a Named Parameter these are used in cases when their are lots of parameters
        Console.WriteLine(constructorValue);
        Customer earl = new Customer("Earl");
        System.Console.WriteLine($"Name of the Customer is {earl.Name}");
        //default customer
        Customer myCustomer = new Customer();
        System.Console.WriteLine("Info on the Customer " + myCustomer.Name);
        //Here We are Calling the SetDetails function in the customer class and setting values to it
        myCustomer.SetDetails("Kira", "DDU", "555");
        System.Console.WriteLine($"New Customer Name is {myCustomer.Name}");


        audi.Drive();
        bmw.Drive();
        //This called the Drive function in the Car class

        Rectangle r1 = new Rectangle();
        r1.Width = 5;
        r1.Height = 5;
        //r1.Area cannot be defined because it doesn't have a setter
        System.Console.WriteLine($"The Area of Rectangle is {r1.Area}");
        //Static Function
        Customer.DoSomething();
        //here we are calling the Static Function
        /*
        Console.WriteLine is a static method since we are directly calling it from
        Console class without creating the Console class object
        */
        System.Console.WriteLine($"Total Number of Cars is {Car.NumberOfCars}");
    }
}

class Hello
{
    public Hello()
    {
        Console.WriteLine("HELLO KIRA");
    }

    public int Add(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
}




