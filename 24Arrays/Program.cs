/*
Arrays:  a Data structure that stores a fixed set of Elements of the same data type
these are accessed using indicies starting from 0
*/



// Declare an Array

int[] myInt = new int[5]; //This is an Array that stores 5 values
int sum = 0;
for(int i = 0; i <5;i++){
    System.Console.WriteLine($"Please Enter an Integer");
    myInt[i] = int.Parse(System.Console.ReadLine());
    sum = myInt[i] + sum;
}
System.Console.WriteLine(sum);


// A different method to input Arrays
int[] newInt = [1,2,3];
System.Console.WriteLine(newInt.Length);//this gives the amount of length of an array
for(int i =0; i < 3; i++){
    System.Console.WriteLine(newInt[i]);
}


string[] weekDays = ["Mon","Tue","Wed","Thr","Fri","Sat","Sun"];
System.Console.WriteLine(weekDays.Length);
foreach(string day in weekDays){//ForEach loop Each item in weekDays
    System.Console.WriteLine(day);
}