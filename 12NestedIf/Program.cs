/*
Nested If statements means when an IF statement is Inside of Another IF statement
*/
System.Console.WriteLine($"Enter a Number");
int Num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Enter Another Number");
int Num2 = int.Parse(Console.ReadLine());
int Num3;

if(Num1 < Num2){
    Console.WriteLine($"{Num1} is Lesser than {Num2}");
    if(Num1 > 10){
        Num3 = Num1+Num2;
        System.Console.WriteLine($"Since {Num1} is Greator than 10 we Add {Num1} and {Num2}");
        System.Console.WriteLine($"So the Added Numbers = {Num3}");
    }
}

else{
    System.Console.WriteLine($"{Num1} is not greator than {Num2}");
    if(Num2 > 10){
        Num3 = Num2 - Num1;
        System.Console.WriteLine($"Since {Num2} is Greator than 10 we Subtract {Num2} and {Num1} ");
        System.Console.WriteLine($"So the Subtracted Number = {Num3}");
    }
}