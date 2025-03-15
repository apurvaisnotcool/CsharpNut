namespace _28WeatherSimulator;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number of days you want to simulate");
        int days = int.Parse(System.Console.ReadLine());
        int[] temp = new int[days];
        string[] conditions = {"Sunny","Rainy","Cloudy","Snowy"};
        string[] weatherConditions = new string[days];
        Random random= new Random();
        for(int i=0; i<days; i++){
            temp[i] = random.Next(-10, 40); // This will give us a Random Temperature value between -10
            //and 40'C
            
            System.Console.WriteLine($"The Random Temperature is {temp[i]}\n");
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
            //This generates a Random Condition such as "Rainy" to the weatherConditions array
            System.Console.WriteLine($"The Weather condition is {weatherConditions[i]}.\n");
            //This statement gives us a random conditions from the condition array condition.Length
            //is used because lets say we want to add a condition we can do it directly in the conditions
            //array and not have to worry about the compiler failing us
        }
        System.Console.WriteLine($"The average of the weather is {CalculateAverage(temp)}");
        System.Console.WriteLine($"The Max Temp is {temp.Max()}");//This gets the max Temp
        System.Console.WriteLine($"The Min Temp is {temp.Min()}");// This gets the min Temp
    }
    static double CalculateAverage(int[] temp){
        int sum = 0;
        for (int i=0; i<temp.Length; i++){
            sum += temp[i];
        }
        double average = sum / temp.Length;
        return average;
    }
}
