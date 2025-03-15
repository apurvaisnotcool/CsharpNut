int currentScore = 0;
int sum = 0;
int totalSubjects =0;

do{
    System.Console.WriteLine("Enter student score, Enter -1 to Finish");
    currentScore = int.Parse(Console.ReadLine());
    sum = sum + currentScore;
    totalSubjects++;
}while(currentScore != -1);
System.Console.WriteLine($"Total sum is {sum} So now we Calculate Average");
double average = sum/totalSubjects;

System.Console.WriteLine($"The Average of {totalSubjects} subjects is {average}");


