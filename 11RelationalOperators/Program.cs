/*
Relational Operators are the Operators that compares two Values
Relational Operators are < > == <= >=
*/
System.Console.WriteLine("Enter a Number");
int Num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter another Number");
int Num2 = int.Parse(Console.ReadLine());

if (Num1 < Num2){
    System.Console.WriteLine($"{Num2} is greater than {Num1} ");

}
else if (Num1 > Num2){
    System.Console.WriteLine($"{Num1} is Greater than {Num2}");
}
else {
    System.Console.WriteLine($"{Num1} and {Num2} are Equal to Each Other");
}