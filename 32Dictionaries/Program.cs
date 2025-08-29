using System.ComponentModel;

namespace _32Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        /*
        Dictionaries allowes us to use Collections with Key Value Pairs
        */

        Dictionary<int, string> employees = new Dictionary<int, string>();//Dictionaries declaration
        //int is the Key and it holds strins as values
        employees.Add(1, "Kira");//This here means at the key 1 we store the value kira in the Employee
                                 //Dictionary
        employees.Add(2, "John");
        string name = employees[1];//Here we are getting the name Kira from the key of 1 from the 
                                   //Dictionary
        System.Console.WriteLine(name);
        System.Console.WriteLine(employees[2]);
        System.Console.WriteLine("We overwrote the 2nd employees name now we have ");
        employees[2] = "Jane";//We are updating the value of dictionary at key 2
        System.Console.WriteLine(employees[2]);
        employees.Add(3, "Manoj");//we are adding another value in the key of 3 in the dict
        System.Console.WriteLine(employees[3]);
        System.Console.WriteLine("We added the 3rd emoployee now we remove it");
        employees.Remove(3);
        System.Console.WriteLine("Print all the employees");
        foreach (KeyValuePair<int, string> employee in employees)
        {
            System.Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
        }

        //How to handle Duplicates 
        //This code checks if their is no employee at key 2 then we add Mike to that key
        if (!employees.ContainsKey(2))
        {
            employees.Add(2, "Mike");
        }

        //Using an object as a value for the dictionaries


        Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
        employeeDictionary.Add(1, new Employee("Madhu", 28, 150000));
        employeeDictionary.Add(2, new Employee("Tripti", 25, 250000));
        employeeDictionary.Add(3, new Employee("Abhi", 40, 450000));

        foreach (var item in employeeDictionary)
        {
            System.Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name} Age : {item.Value.Age} Salary: {item.Value.Salary}");
        }

        //Dictionaries that has String as the Key and String as the Value
        var codes = new Dictionary<string, string>
        {
            ["NYC"] = "New York",
            ["Paris"] = "France",
            ["New Delhi"] = "India"
        };

        if (codes.ContainsKey("NYC"))
        {
            System.Console.WriteLine(codes["NYC"]);
        }

    }
}
