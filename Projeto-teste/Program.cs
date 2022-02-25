using Projeto_teste.Entities;
using Projeto_teste.Entities.Enums;
using System;
using System.Globalization;
namespace Projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department´s name: ");
            string departmentname = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(departmentname);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Enter #{i}, contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("");
            Console.WriteLine("Enter mounth and year to calculate income (MM/YYYY): ");
            string yearmounth = Console.ReadLine();
            int year = int.Parse(yearmounth.Substring(0, 2));
            int mounth = int.Parse(yearmounth.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {yearmounth}: R$" + worker.Income(year, mounth).ToString("F2", CultureInfo.InvariantCulture));
               

        }
    }
}
