

//Logical Operators are && || !
// && means AND
// || means OR
// ! means NOT
System.Console.WriteLine($"Enter if it is Raining or Not");
bool isRaining = bool.Parse(Console.ReadLine());
System.Console.WriteLine($"Enter if he/she has an Umbrella or Not");
bool hasUmbrella = bool.Parse(Console.ReadLine());

if(isRaining && hasUmbrella){//AND Operator
    System.Console.WriteLine($"he/she is safe");
}
else if(isRaining && !hasUmbrella){ // NOT Operator
    System.Console.WriteLine($"He/she is getting wet");
}
if (isRaining || hasUmbrella){ //OR operator
    System.Console.WriteLine($"I don't know why we will use OR operator here lol");
}