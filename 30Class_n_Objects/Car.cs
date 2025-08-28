namespace _30Class_n_Objects;

public class Car
{

    /*
    this class is internal which just means that it can only be accessed from within the same assembly
    and an assembly to really simplify it within the same program.
    A class Usually has the same Namespace Therefore it is in the same folder as 
    the Program.cs
    
    Other programs cannot access this class.*/
    private string _model = "";// this can also be called as the Backing Field of the Model Property
    /*
    This is a Member variable
    Member variable is a field that is inside the class but outside the fuction(Constructor)
    _model is member variable of the class car
    */
    private string _brand = "";
    private bool _isLuxary;

    //this is a static field variable meaning it can be public and can be called outside the class
    public static int NumberOfCars;



    /*
    A property is a member that provides a flexible mechanism to read, write, 
    or compute the value of a data field. Properties appear as public data members, 
    but they're implemented as special methods called accessors. 
    This feature enables callers to access data easily and still helps promote data safety and 
    flexibility. 
    properties are a way of encapsulation
    */

    /*
    Right now the member variable _model and _brand cannot be accessed outside of this class
    without making it a public variable
    that would be bad coding practice and leave the variable vunerable to bugs
    */

    //Property
    /*
    public string Model { get => _model; set => _model = value;}
    public string Brand { get => _brand; set => _brand = value; }
    I had to comment out this code as we are going to define property of the Member variable
    */

    /*
    This here means that 
    whenever you want to get the _model here, you can access it.
    I will give you the model whenever you want to set the model, whatever value you give me, I'm going
    to set that as the _model.
    this means that only the the property Model has the access to the member variable _model
    No other code in this class or this program has the access to the member variable _model
    */

    // We will now is property by defining some logic to the property
    public string Model { get => _model; set => _model = value; }
    // => is a Lambda Expression
    /*
    public string Model { get => _model; set => _model = value; }
    is the same as
    
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            _model = value;
        }
    }
    */
    public string Brand
    {
        get
        {
            if (_isLuxary)
            {
                return _brand + " - Luxary Edition";
            }
            else
            {
                return _brand;
            }
            /* Here we are getting the Brand name and checking if it is a Luxary Edition or not
            */
        }
        set
        {
            if (string.IsNullOrEmpty(value))//if the value entered for _brand is nothing this code
            //is executed
            {
                System.Console.WriteLine("You have Entered NOTHING");
                _brand = "DEFAULT VALUE";
            }
            else
            {
                _brand = value;
            }
        }

    }
    public bool IsLuxary { get => _isLuxary; set => _isLuxary = value; }

    public Car(string model, string brand, bool isLuxary)
    /*This is a Constructor
    Constructor: A constructor is very similar to a method, but it's different in that it has the same 
    name, exact same name as the class itself, and it does not have a return type.
    So this constructor is called/executed whenever a new object of car is created.: 
    */


    {
        Model = model;
        Brand = brand;
        IsLuxary = isLuxary;
        System.Console.WriteLine($"An Object of Car of Brand {_brand} and Model {_model} has been created");
        NumberOfCars++;
    }
    public void Drive()
    {
        System.Console.WriteLine($"I'm an {Model} and i'm Driving");
    }
}


// dotnet new class -n "classname"




/* 
c#
unity udemy
unity data structures
unity code monkey
*/