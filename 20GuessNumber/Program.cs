Random random = new Random();
int secretNumber =random.Next(1, 101);
int userGuess =0;
int i=0;
while(secretNumber != userGuess){
    i++;

    userGuess = int.Parse(Console.ReadLine());
    if(userGuess < secretNumber){
        System.Console.WriteLine("Too Low");
    }
    else if(userGuess > secretNumber){
        System.Console.WriteLine("Too High");

    }
    else{
        Console.WriteLine($"Secret Number is {userGuess} it took you {i} tries");
    }

    
}