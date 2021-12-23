using ExercicioResolvido1.Entities;
using ExercicioResolvido1.Enums;
using System;
using System.Globalization;

namespace ExercicioResolvido1
{
    class Program
    {
        static void Main()
        {
            string deptName;
            string workName;
            WorkerLevel workLevel;
            double workSalary;
            Departament dept;
            Worker worker;
            int N;
            string[] monthAndYear;
            double workIncome;

            Console.Write("Enter department's name: ");
            deptName = Console.ReadLine();
            Console.WriteLine("\nEnter worker data: ");
            Console.Write("Name:  ");
            workName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            workLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            workSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            dept = new Departament(deptName);
            worker = new Worker(workName, workLevel, workSalary, dept);

            Console.Write("\nHow many contracts to this worker? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                HourContract contract;
                Console.WriteLine($"\nEnter #{i + 1} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contDate = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double contValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Duration (hours): ");
                int contDuration = int.Parse(Console.ReadLine());
                
                contract = new HourContract(contDate,contValue,contDuration);

                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            monthAndYear = Console.ReadLine().Split("/");
            workIncome = worker.Income(int.Parse(monthAndYear[0]),int.Parse(monthAndYear[1]));

            Console.WriteLine($"\nName: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear[0]}/{monthAndYear[1]}: {workIncome.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
