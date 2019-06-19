using Aula136.Entities;     //Informa que usará algumas declarações cntida em classes deste endereço
using System;       //Necessário para o funcionamento dos pricipais comandos e declarações.
using System.Collections.Generic;   //Necessário para a criação de listas.
using System.Globalization;     //Necessário para o funcionamento do ponto ao invés da vírgula.

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();     //Lista "List" criada e instanciada

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());      //criada a variável "n" e recebendo o valor dado pelo usuário

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());     //Declarada a variável "type" e recebe o valor do usuário
                Console.Write("Name: ");
                String name = Console.ReadLine();       //Declarada a variável "name" e recebe o valor do usuário
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Declarada a variável "income"
                                                                                                // e recebe valor do usuário.
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
