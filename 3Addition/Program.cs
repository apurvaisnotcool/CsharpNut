Console.WriteLine("This is the program to Add two int Numbers");

int myNumber1=0;
int myNumber2=0;


System.Console.WriteLine("Please Enter Number 1");

string userInput = Console.ReadLine();//userInput stores the int in string form

myNumber1 = int.Parse(userInput);//we parse the string into int

System.Console.WriteLine("Please Enter Number 2");

userInput = Console.ReadLine();//we Overwrite the userInput variable to store the second variable

myNumber2 = int.Parse(userInput);//we parse the second number into a int

int sum = myNumber1+myNumber2;//the new variable sum adds the two input numbers


System.Console.WriteLine("The sum of two number is "+sum);//output


//String Interpolation 

System.Console.WriteLine($"The Sum of {myNumber1} and {myNumber2} is {sum}");

//you see this sentence in shorter than the first one we wrote


int myInt1 =10;
int myInt2 =10;

double mySum = myInt1+myInt2; //double can store int but int cannot store double

System.Console.WriteLine($"The sum of two integer {myInt1} and {myInt2} stored in a double is {mySum}");



