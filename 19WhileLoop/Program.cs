int i =0;
while(i<10){
    System.Console.WriteLine(i);
    i++;
}

System.Console.WriteLine($"Enter Go or Stay");

string userInput = Console.ReadLine();
while(userInput == "Go"){
    System.Console.WriteLine("Life is good");
    userInput = Console.ReadLine();
}


