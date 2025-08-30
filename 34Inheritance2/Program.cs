namespace _34Inheritance2;

class Program
{
    /* Constructor Inheritance:
    Constructors are special methods in a class that are called when an instance of the class is created.
    So how does that matter in the context of inheritance?
    constructors of the base class are called before the constructor of the derived class is called.
    This ensures that the base class is properly initialized before any additional initialization in the
    derived class takes place.*/

    /*
    Proper Initialization: This Ensures that all Fields and Properties of the base class are Correctly
    Setup before any Operation of the Derived class can take place
    This means that when creating an Object of the Derived class the constructor of the base class
    runs first to Initialize its Members
    */

    /*
    Consistent State: This helps maintain a consistent and valid state of the Object heirarchy
    This ensures that both the base and derived class remain in the valid state throughout the objects
    lifetime.By running the base class constructor first we ensure that any dependency and required 
    initial state are estabilished.
    */

    /*
    Reuse of Initialization code:
    This avoids the duplication of the Initialization code by Reusing the base class Constructor
    */
    static void Main(string[] args)
    {
        Employee kira = new Employee("Kira", 27, "Coder", 666);
        /*
        Here we are creating an Object named Kira
        when the object Employee kira is created we call the Person Constructor
        Than the Employee Constructor is Called 
        */
        kira.DisplayPersonInfo();
        //Here the Kira Employee calls the DisplayPersonInfo Function which has the Assigned Name 
        //and Age
        Manager carl = new Manager("carl", 36, "Manager", 123, 7);
        carl.DisplayManagerInfo();
    }

}
    public class Person
    {
        public string Name { get; private set; }//we can get the name but noone can set it
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Person Constructor called");
        }
        public void DisplayPersonInfo()
        {
        System.Console.WriteLine
            ($"Name: {Name} Age: {Age}");
        }

        
    }
public class Employee : Person
{
    public string JobTitle { get; private set; }
    public int EmployeeID { get; private set; }
    public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)

    {
        JobTitle = jobTitle;
        EmployeeID = employeeId;
        System.Console.WriteLine("Employee Constructor is called");
    }
    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();
        System.Console.WriteLine($"JobTitle: {JobTitle}, EmployeeId: {EmployeeID}");
    }
    
}

//Employee Class Inherits the Properties and Methods of the 
// Person Class(Name, Age, DisplayPersonInfo())
//we have to call the base properties from the parent class 
//This will assign the name and age taken from the Employee Constructor to the Base Constructor

//name and age in the Employee Constructor is passed on to the base
/*
When we create the Employee Object Kira we pass in the value from that object
to the Employee Constructor that gets passed on to the base constructor Person
that gets assigned to the Name and Age property
*/
public class Manager : Employee
{
    public int TeamSize { get; private set; }
    public Manager(string name, int age, string jobTitle, int employeeID, int teamSize)
    : base(name, age, jobTitle, employeeID)
    {
        TeamSize = teamSize;
        System.Console.WriteLine("Manager Constructor is called");
    }
    public void DisplayManagerInfo()
    {
        DisplayEmployeeInfo();
        System.Console.WriteLine($"TeamSize: {TeamSize}");
    }
}


