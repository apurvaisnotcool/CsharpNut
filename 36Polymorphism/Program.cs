namespace _36Polymorphism;

/*
---------------------------Polymorphism--------------------------
Polymorphism derives from the greek word meaning many shapes.
The ability in programming where single interface or method can operate in multiple ways based on
the object it interacts with.
Think of it this way. One universal remote can press 'play' on TV, DVD and an stereo differently.
play button can start a channel on the TV
play button can start a movie on the DVD
play button can start a song on a stereo
the same play button
The same method works uniquely depending on the object it controls.

This means One Interface many Implimentation.
A single Function or Method can work on Objects or various types.
the Implimentation depends on the specific object being referenced.
for ex:
if you have different type of Animals Each animal makes a different sound
the Make sound function will make the appopriate sound for any given animal.

Reasons to Use Polymorphism:

Flexibilty: Write adaptable Reusable Code.
Methods can work with different object types without knowing the specific type in advance

Code Maintainance: New Object types can be added easily if they can conform to the expected interface
or base class.

Simplifies the Code: Enables treating different objects uniformly.
Reduces Complexity by handling diverse objects through common interface.
*/

public class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal Sounds");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Woof Woof");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Since Dog inherites from the Animal class we can create an 
        //Animal object dog that polymorphs from the Dog class
        //The Animal object dog hase the Properties and methods of Dog
        //but is an Animal Object
        Animal myDog = new Dog();
        //Dog dog2 = new Animal(); This code doesn't work because Dog inherits from Animal
        //not the other way around
        myDog.MakeSound();
    }
}
           
