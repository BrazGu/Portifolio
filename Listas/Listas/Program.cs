using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            //lista criada a partir de referência, ou seja, possui a classe Employee.
            //Assim, podemos construir a lista com tipos de variáveis diferentes, unindo string, int e double.
          
            Console.Write("How many employees will be registered? ");
            int employees = int.Parse(Console.ReadLine());
            //Simples, variável temporária

            for(int n = 0; n < employees; n++)
            // for utilizado para a captação de dados
            {
                Console.WriteLine("");
                Console.WriteLine($"Employees # {n + 1}: ");
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                //acima, coletamos os dados com variáveis temporárias 
                
                list.Add(new Employee(id, name, salary));
                //adicionamos itens à lista;
                //Instanciando pelo comando new...
                Console.WriteLine("");

            }
            Console.Write("Enter the eployee Id that will have sallary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            //captacao de dados comum

            Employee emp; //não precisa instanciar "colocar new..."
            emp = list.Find(x => x.Id == searchId);
            //variável referência;
            //comando list.Find -> procurar dentro da lista;
            //x dentro do Id (atributo da outra classe);
            //caso encontre, atribuirá um valor a emp, caso contrário, continua null;

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.increaseSalary(porcentagem);
                Console.WriteLine("");
            }
            else // caso não encontre
            {
                Console.WriteLine("This id does not exist!");
            }
    
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list){
                Console.WriteLine(obj);
            }
        }
    }
}
