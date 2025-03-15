
System.Console.WriteLine($"Please Enter the number of the Month");
int month = int.Parse(Console.ReadLine());

string monthName = "";

switch (month){
    case 1:
        monthName = "Janurary";
        System.Console.WriteLine(monthName);
        break;
    case 2:
        monthName = "February";
        System.Console.WriteLine(monthName);
        break;
    case 3:
        monthName = "March";
        System.Console.WriteLine(monthName);
        break;
    case 4:
        monthName = "April";
        System.Console.WriteLine(monthName);
        break;
    case 5:
        monthName = "May";
        System.Console.WriteLine(monthName);
        break;
    case 6:
        monthName = "June";
        System.Console.WriteLine(monthName);
        break;
    case 7:
        monthName = "July";
        System.Console.WriteLine(monthName);
        break;
    case 8:
        monthName = "August";
        System.Console.WriteLine(monthName);
        break;
    case 9:
        monthName = "September";
        System.Console.WriteLine(monthName);
        break;
    case 10:
        monthName = "October";
        System.Console.WriteLine(monthName);
        break;
    case 11:
        monthName = "November";
        System.Console.WriteLine(monthName);
        break;
    case 12:
        monthName = "December";
        System.Console.WriteLine(monthName);
        break;

}


string strName = Console.ReadLine();
string check = strName.Trim().ToLower();
//Trim() this trims the empty space in the start and end of a string
//ToLower Converts the string to LowerCase
System.Console.WriteLine(check);
