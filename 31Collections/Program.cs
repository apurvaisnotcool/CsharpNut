namespace _31Collections;

class Program
{
    static void Main(string[] args)

    {
        /*
        Lists: a List<T> is a generic collection that stores element in a linear sequence.
        Unlike arrays, Lists are dynamic, meaning their size can be increased or decreased as needed.
        
        The <T> is a placeholder for a data type that can be filled with any type like int, string or
        even a class like car

        Properties of List:
        Count: Gets the Number of Elements in the List
        Capacity: Gets or Sets the number of Elements that the list can hold before needing to resize

        Core Methods of Lists:
        Add(T item):Adds the item to the end of the list.

        Remove(T item): Removes the first occurance of the specific object from the list.

        Insert(int index, T item): Inserts the element of the specified index

        Find(Predicate<T> match): Searches for an Element that matches the conditions defined
        by the specified predicate.

        Sort(): Sorts the Element in the Entire List<T>

        Clear(): Removes all the Elements from the List

        ToArray(): Copies the Element of the elements of the List to a new Array.

        IndexOf(T item): Returns the first occurance of the specified object in the List
        */

        List<string> colors = new List<string>();
        colors.Add("Red");//Adding item to the list in this case adding a string
        colors.Add("Blue");
        colors.Add("Green");
        colors.Add("Red");
        colors.Add("Red");
        colors.Add("Red");

        foreach (string color in colors)
        {
            System.Console.WriteLine(color);
        }

        colors.Remove("Red");//Removing the First Occurance of the color Red from the list


        bool isRemovingColorSuccessful = colors.Remove("red");//Checks weather the the item
        //Was successfully deleted from the list
        System.Console.WriteLine(isRemovingColorSuccessful);
        //Returns False because their is no item in the list named "red"

        bool deleteColor = colors.Remove("Red");//true
        //Returns true becuase we delete we color "Red"
        while (deleteColor)
        {
            deleteColor = colors.Remove("Red");
            //Runs until the Color "Red" is completely Removed
        }

        System.Console.WriteLine("New List ");
        foreach (string color in colors)
        {
            System.Console.WriteLine(color);
        }

        List<int> myNumber = [
        //Adding Numbers to the List
            0,
            1,
            2,
            10,
            5,
            6,
            4,
            4,
            25,
            18,
            15,
            //This is an Alternative way of initialising and adding to a List
        ];
        System.Console.WriteLine("             ");//Empty space in the console
        System.Console.WriteLine("List of Numbers");
        myNumber.Sort();//This sorts all the numbers in the List
        foreach (int number in myNumber)
        {
            System.Console.WriteLine(number);
        }
        //This here Returns a List of Numbers Higher Than Ten



        /*
        Lambda Expressions:
        lambda Expression consists of 2 parts
        Parameters
        Expression or statement blocks
        parameters are written on the left side of => this symbol means go to
        expression or action is performed on the right side.a
        x => x*x
        take input x and turn it  into x*x
        */

        /* Predicate:
        It works with those methods which contain some set of criteria and determine whether 
        the passed parameter fulfill the given criteria or not. 
        This delegate takes only one input and returns the value in the form of true or false
        
        Delegate:
        in C sharp a delegate is like a pointer or reference to a method.
        It allows you to pass methods as arguments to other methods, store them in variables and 
        call them later.This is useful when you want your code to be flexible and able to 
        handle different behaviors that aren't
        predetermined.
        */

        //Lambda extression is like a simplified method

        Predicate<int> isGreaterThanTen = x => x >= 10;
        /* 
        x => x >= 10;
        This expression is same as

        public bool isGreaterThanTen(int i){
            return i >= 10;
        }
        */


        //This here Defines an Int Predicate that checks for the Lambda expression is x >= 10
        System.Console.WriteLine("Listing Numbers higher than ten");
        List<int> higherThanTen = myNumber.FindAll(isGreaterThanTen);
        //Lambda expression here means x goes to x >=10 this checks weather the number 
        // in x is greater than 10

        /*Any Method:
        This method takes in a Lambda Expression and checks weather the list has has that element or 
        not
        */
        bool numberGreaterthanfifteen = myNumber.Any(x => x > 15);
        if (numberGreaterthanfifteen)
        {
            System.Console.WriteLine("List has Large numbers");
        }

        foreach (int number in higherThanTen)
        {
            System.Console.WriteLine(number);
            //Printing the list of numbers higher than ten
        }

        //This code here shows that we can Add different kind of List
        //Like Product is a Class with Name and Price as its Properties
        List<Product> products = new List<Product>
        {
            new Product { Name = "Apple", Price = 15.00},
            new Product { Name = "Banana", Price = 20.00},
        };
        products.Add(new Product { Name = "Manga", Price = 30.00 });
        System.Console.WriteLine("Available Productsa - ");
        foreach (Product product in products)
        {
            System.Console.WriteLine($"Product Name: {product.Name} with the price of {product.Price}");
        }

        /*A nullable value type T? represents all values of 
        its underlying value type T and an additional null value. For example, 
        you can assign any of the following three values to a bool? variable: true, false, or null. 
        An underlying value type T cannot be a nullable value type itself.*/
        int? num = null;//int on its own cannot be assigned the value null but if we add ? at the end
                        //It becomes a Nullable type
        if (num.HasValue)// If Num is Null it would be false and the code will not run
        {
            System.Console.WriteLine(num.Value);//If the num has a value this will return the value
        }
        else
        {
            System.Console.WriteLine("Num doesn't have a value");
        }

    }
}
