namespace _33Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat("GreyHound");//We can access the Eat() Function from the Dog class because Dog Inherits 
                             // from Animals
        GoldenRetriver goldenRetriver = new GoldenRetriver();
        //This Object Inherits from Dog Class which in then Inherits from the Animal Class
        //Theirfore we can access the Dog Methods and properties as well as the Animal 
        // Methods and properties
        goldenRetriver.Name = "GolddenRetriver";
        goldenRetriver.Eat(goldenRetriver.Name);
        goldenRetriver.Bark();
        Cat cat = new Cat();
        cat.Meow();
        dog.Food();//Since we are calling the Food Function from the dog object we get Dog Food
        cat.Food();//Since we are calling the Food Function from the cat object we get Cat Food
        //This is an Example of Polymorphism
    }
}


//Base Class(parent class or Super Class)
class Animal
{
    public void Eat(string name)
    {
        Console.WriteLine($"{name} is Eating...");
    }

    //Virtual Keyword helps us override the Food Function in Other Derived classes
    public virtual void Food()
    {
        System.Console.WriteLine("Food for Animal");
    }
}

//This Dog Class Inherits from Animal Class
//Dog has all the capabilities that Animal Class has plus the properties and methods of its own
//Class

//Dog is a Derived Class(Sub class or Child Class)
class Dog : Animal
{
    public void Bark()
    {
        System.Console.WriteLine("Barking...");
    }

    public override void Food()
    {   //base keyword helps use call the base funtion food from the animal class
        base.Food();
        System.Console.WriteLine("Food for Dogs");
    }
}

//This is Hierical inheritance where we Derive multiple classes from the base class in this case
//Animal class
class Cat : Animal
{
    public void Meow()
    {
        System.Console.WriteLine("Cat is Meowing");
    }

    public override void Food()
    {
        System.Console.WriteLine("Food for Cats");
    }
}

class GoldenRetriver : Dog
{
    private string _name = "";
    public string Name { get => _name; set => _name = value; }

    public void Active()
    {
        System.Console.WriteLine("Active Dog");
    }
}