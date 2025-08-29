namespace NumberAdd;

class Program
{
    static void Main(string[] args)
    {
        int totalValue = 0;
        for (int i = 0; i < 8; i++)
        {
            int value = int.Parse(Console.ReadLine());
            totalValue += value;
        }

        System.Console.WriteLine(totalValue);
            
    }
}
