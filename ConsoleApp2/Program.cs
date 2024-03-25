namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          Employee employee = new Employee();
            employee.FirstName = "Chamil";
            employee.LastName = "jeewantha";
            employee.BasicSalary = 25000;
           Console.WriteLine("full name"+employee.FirstName+employee.LastName);
            Console.WriteLine("salary" + employee.BasicSalary);




        }
    }
}
