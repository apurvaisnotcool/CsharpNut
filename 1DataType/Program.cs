// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello,Please Enter Something");

string userInput = Console.ReadLine(); 
//ReadLine() Takes the input and stores it in a string datatype variable
//ReadLine() is a method(Function) being called from System That is used for input i.e cin>>

Console.WriteLine("You Stored " + userInput);
//In This line we are printing the userInput
//We are getting good at this i like vscode now

int IAmANumber = 666; 
float PointNumber= 1.52f;
string Name = "Kira";
bool Check = true;

System.Console.WriteLine("The Integer is " + IAmANumber);//prints integer
System.Console.WriteLine("The float is " + PointNumber);//prints float
System.Console.WriteLine("The string is " + Name);//prints string


System.Console.WriteLine("The Boolean is " + Check);//prints Boolean



/* Camel Case:

Camel Case is a nameing convention where the first letter of the first word is small and we 
capitalize the first letter of the second word.
It is used for variables and Methods

*/

int myNumber = 666; //Camel Case

System.Console.WriteLine(myNumber);
/* Pascal Case:

Pascal case is a naming convention where the first letter of each word is capitalized
This naming convention is used to name Classes and namespace

*/

/* Snake Case:
Snake case is a naming convention which is not typically used in C#.
In this naming convention we put an underscore between words.
commonly used in python
*/

int my_variable = 6;//snake case
System.Console.WriteLine(my_variable);


//reference Type
string myName = "Kira";
//Value Type
int myAge = 26;
float pi = 3.14f;

System.Console.WriteLine(myName + " " + myAge + " " + pi);



/*
Value Type:

stores actual data directly
typically stored in a stack
value types are int,float,long,double,char,bool,struct,enum,decimal
nullable versians are int?,float?, ... etc
typically value type is stored in a stack but it can also be stored in a heap if
it is connected to a reference type



Reference Type:

Reference type is a variable type in which insteadf of storing the value in the memory directly
it stores the memory location of the actual data.
Variable here stores the memory reference of the data and not the data directly.
Reference type are strings, class, Array, etc
When we copy the reference type of a data it will copy the memory address of the data so we will have
two reference pointing to the same data

*/

string petsName = "Tyson";
System.Console.WriteLine($"My dogs name is {petsName}");

