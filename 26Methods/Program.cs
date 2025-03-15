/*
Methods: A method is a code block that contains a series of statements
a program causes the statement to be executed by calling the method and specifying any required
method argument.
In C# every executed instruction is performed in the Context of a method.
The main method is the entry point for every C# application and it is called by the common language
runtime CLR when the program is started



<Access Specifier> <Return Type> <Method name>(Parameter List){
Method Body
}


Access Specifier: The access Specifier Determines the visibility of the variable or a method from
another Class public private etc

Return type: A method may return a value. Return type is the date type of the value being return.
If the Method isn't returning any value then the return type is void

Method name: Method name is a unique identifier and it is case sensetive. It cannot be same as the
other identifier names declared in that specific class

Parameter List: Enclosed between parenthesis. The parameter are used to pass and recieve data from
a method. the Prameter list refers to the type, Order and number of the the parameters of the method.
Parameter are optional therefore a method may contain no Parameter

Method Body: Contains the set of instruction needed to complete the required activity


12PM Wake up
12-3 study
3-8 Music
8-3 GO OUT
*/


//This is a void method that returns nothing
//And this is how we Declare it

void MyFirstMethod(){
    System.Console.WriteLine("MyFirstMethod was Called");
}

MyFirstMethod(); //This is how we Call a Method
System.Console.WriteLine("This is outside Method");


//string is the parameter of this method
void WriteSomethingSpecific(string myString){
    System.Console.WriteLine($"Your Argument is {myString}");
}

string myUsername = "apurvaisnotcool";

WriteSomethingSpecific(myUsername);//myUsername is being passed as the argument
WriteSomethingSpecific("Hello");// string hello is the argument here

System.Console.WriteLine("Method to add two Numbers");

void AddNumber(int num1, int num2){
    int sum = num1 + num2;
    System.Console.WriteLine($"The sum is {sum}");
}

System.Console.WriteLine("Enter Number 1");
int i = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter Number 2");
int j = int.Parse(Console.ReadLine());

AddNumber(i, j);


//Another way to Add

int AddValue(int value1, int value2){
    int sum = value1 + value2;
    /*
        since the Return type of this Method is an int we cannot put any other DATATYPE for the values
    */
    return sum; 
    /* This is a return statement it Returns the value in this case sum outside of the method
        since we are returning a value the return type cannot be a void method
    */
}
System.Console.WriteLine("Enter Values for Another Method");
System.Console.WriteLine("Enter Value 1");
int k = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter Value 2");
int l = int.Parse(Console.ReadLine());
System.Console.WriteLine(AddValue(k,l));
