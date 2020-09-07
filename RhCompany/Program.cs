using System;
using System.Collections.Generic;

namespace RhCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> list = new List<Employee>();

            int id;
            string name;
            double salary;

            Console.Write("How many employess will be registered: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Enter with ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Enter with NAME: ");
                name = Console.ReadLine();
                Console.Write("Enter with SALARY: ");
                salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }


            Console.Write("Enter with employee ID that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Enter with percentage: ");
                double perc = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(perc);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
