System.Console.WriteLine("Enter a Number");

string inputString = Console.ReadLine();
int Num=0;
bool isNumber = int.TryParse(inputString, out Num);


//TryParse is a method that checks and returns true or false if the Input is (in this case) an Int or Num

if(isNumber){
    Console.WriteLine($"{inputString} is a Number");
}
else{
    Console.WriteLine($"{inputString} is not number");
}

/*
Normal Parse will give an Error if we enter anything other than int in this case and the program
will crash
however TryParse will keep on running even if we enter whatever
*/
