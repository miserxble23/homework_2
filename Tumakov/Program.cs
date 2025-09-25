using System;
using Enums;
using Struct;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("№1 ");
            AccType account = AccType.Текущий;
            Console.WriteLine($"Тип счета: {account}");
            // 2 
            Console.WriteLine("№2 ");
            dataBank account1;
            account1.Number = 111;
            account1.Type = "Текущий";
            account1.Balance = 12344321;
            Console.WriteLine($"Номер: {account1.Number}");
            Console.WriteLine($"Тип: {account1.Type}");
            Console.WriteLine($"Балаанс: {account1.Balance}");
            // 3
            Console.WriteLine("№3 ");
            Worker worker;
            worker.Name = "Азат";
            worker.Vuz = Vuz.КГУ;
            Console.WriteLine($"Работник: {worker.Name}");
            Console.WriteLine($"Вуз: {worker.Vuz}");

        }
    }
}
