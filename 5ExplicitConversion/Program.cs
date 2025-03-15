//explicit Conversion

long myLong = 12345;

int myInt = (int)myLong;

System.Console.WriteLine(myInt);


/*
keep in mind that long holds more value than int so if we put a large long number and explicitly convert
it into an int we might get a rubbish answer
ex:
*/
long myLong2 = 12345678901023485;
int i = (int)myLong2;
System.Console.WriteLine(i);//output is not the number stored in myLong2


int j;
double myDouble =13.5;

j=(int)myDouble;//Everything after the decimal point will be cutoff

System.Console.WriteLine($"J value will be {j} not '13.5' because we are casting double to an int");

