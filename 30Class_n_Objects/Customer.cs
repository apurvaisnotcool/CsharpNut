namespace _30Class_n_Objects;

public class Customer
{
    /* 
    You don't need to define a member variable all the time in order to set the property
    member variable is only necessory if we have to define the conditions for the 
    property
    */
    public string Name { get; set; }
    /*
    this is the same as 
    public string Name { get => _name; set => _name = value; }
    we cannot do that with the Brand Property since we have to define conditions for the
    Brand property

    */
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    // If we have All the info we use this one
    public Customer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;

    }
    //What if we only have the name of the customer and not the address or the contact
    public Customer(string name)
    {
        Name = name;
    }
    //Default Constructor
    public Customer()
    {
        Name = "Default Name";
        Address = "Default Address";
        ContactNumber = "Default Contact Number";
    }
    /* Default Constructor is called when we pass no parameter or the Default parameter*/

    //Optional Parameter
    public void SetDetails(string name, string address, string contactNumber = "NA")
    //contactNumber is an Optional parameter because we have set a default value of "NA" to it
    {
        Name = name;
        ContactNumber = contactNumber;
        Address = address;
    }

    /* 
    static is a method in which you don't need to create an Object to call it
    we can directly call the DoSomething() method in other Class without creating an Object 
    of that Class
    */
    public static void DoSomething()
    {
        System.Console.WriteLine("Static Method demo");
    }
}
/*
Ableton
izotope
stl tones
guitars
monitors
serum
omnisphere
supirior drummer 3


*/