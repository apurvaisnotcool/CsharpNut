//Break Statement is a statement that breaks out of the Loop


for(int i = 0; i < 10;i++){
    System.Console.WriteLine(i);
    if(i==3){
        System.Console.WriteLine("I've Had Enough Now Break");
        break;
    }
}
System.Console.WriteLine("\n");
//continue is the statement that Breaks out for that specific iteration


for(int i = 0; i < 10;i++){
    System.Console.WriteLine(i);
    if(i==3){
        System.Console.WriteLine("I've Had Enough now Continue");
        continue;
        //Here the loop Breaks and the next WriteLine will not be displayed since we broke out
        //of loop in this line
    }
    System.Console.WriteLine("Only if not Conitinued");
}

