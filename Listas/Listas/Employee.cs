using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }    
        public double Salary { get; private set; }

        public Employee (int id, string name, double salary) 
        //construtor, para atribuir os valores aos atributos de forma encapsulada
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary (double percentage)
        //metodo, utilixado para calcular o novo salario com aumento
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
