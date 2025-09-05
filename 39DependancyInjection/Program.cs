using System.Diagnostics.Contracts;

namespace _39DependancyInjection;
/*
Dependacies refer to objects or componenets that a class needs in order to function 
properly
Imagine you are a builder and in order to build a house you need saw hammer nails etc
to build the house these saw hammer nails they are the dependancies 
of your Application
*/

/* Dependancy injection is a programming technique that makes the class independant of its
Dependancies.
for ex: Insted of builder going to buy the tools needed for the job, Someone brings the tools
to the Builder.

Different Kinds of Dependancy Injection:
Constructor Injection: Dependacies are provided through the class constructor Ensuring the class
receives all the dependancies at the time of instantiation.

Setter Injection: Dependancies are assigned to the public setter methods (properties) allowing the 
injection of Dependancies after the object is created.

Interface Injection: Dependancies are provided through an interface requiring the class to impliment
an interface that exposes a method for injecting the dependancy. 
*/

//Constructor Dependancy Injection
public class Hammer
{
    public void Use()
    {
        System.Console.WriteLine("Hammer Nails");
    }
}

public class Saw
{
    public void Use()
    {
        System.Console.WriteLine("Using Saw");
    }
}
public class Builder
{
    private Hammer _hammer;

    private Saw _saw;
    public Builder(Hammer hammer, Saw saw)
    //Constructor dependacy injection //Constructor dependacy injection
    {
        _hammer = hammer;
        _saw = saw;
    }
    public void BuildingHouse()
    {
        _hammer.Use();
        _saw.Use();
        System.Console.WriteLine("House is Build");
    }
}

//Setter Dependancy Injection

public class Concrete
{
    public void Use()
    {
        System.Console.WriteLine("Putting Concrete");
    }
}

public class Steel
{
    public void Use()
    {
        System.Console.WriteLine("Putting Steel");
    }
}

public class Road
{
    public Concrete Concrete { get; set; }
    public Steel Steel { get; set; }

    public void BuildRoad()
    {
        Concrete.Use();
        Steel.Use();
        System.Console.WriteLine("Road is Build");
    }
}

//Interface Dependancy Injection

public class Engine
{
    public void Use()
    {
        System.Console.WriteLine("Start Engine");
    }
}

public class Ignition
{
    public void Use()
    {
        System.Console.WriteLine("Start Ignition");
    }
}

public interface ICar
{
    void SetEngine(Engine engine);
    void SetIgnition(Ignition ignition);
}

public class CarEngine : ICar
{
    private Engine _engine;
    private Ignition _ignition;

    public void SetEngine(Engine engine)
    {
        _engine = engine;
    }

    public void SetIgnition(Ignition ignition)
    {
        _ignition = ignition;
    }

    public void StartEngine()
    {
        _engine.Use();
        _ignition.Use();
        System.Console.WriteLine("Engine has Started");
    }


}




class Program
{
    static void Main(string[] args)
    {   //Constructor Dependancy Injection

        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        Builder builder = new Builder(hammer, saw);
        builder.BuildingHouse();

        //Setter Dependancy Injection

        Concrete concrete = new Concrete();
        Steel steel = new Steel();
        Road road = new Road();
        road.Concrete = concrete;//Calling the Property Concrete and setting it to the concrete object
        road.Steel = steel;//Calling the Property Steel and setting it to the steel object
        road.BuildRoad();

        //Interface Dependancy Injection

        Engine engine_ = new Engine();
        Ignition ignition_ = new Ignition();
        CarEngine carEngine = new CarEngine();
        carEngine.SetEngine(engine_);
        carEngine.SetIgnition(ignition_);
        carEngine.StartEngine();
    }
}



