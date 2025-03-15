/*
Convert

Convert is a class that can convert one datatype to another

*/



string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);//ToBoolean converts string myBoolString into Boolean which
//holds true value
System.Console.WriteLine(myBool);
// Console.WriteLine is always a string even if we Add numbers in it
int totalVids = 500;
int perDay = 25;
int totalDays = totalVids/perDay;
System.Console.WriteLine($"The number of days to complete this course is {totalDays}");