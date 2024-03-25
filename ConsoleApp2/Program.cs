namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers={10,20, 30,40,50,25,35,45,78,45};
            double total = 0;
            double average = 0;
           for (int i = 0; i < numbers.Length; i++)
            {
            total += numbers[i];
            
            }
           average = total / numbers.Length;
            Console.WriteLine("total" + total);
            Console.WriteLine("average" + average);
        }
    }
}
