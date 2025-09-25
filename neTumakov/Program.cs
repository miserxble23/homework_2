using System;
using System.Security.AccessControl;
using Enums;
using Struct;


namespace neTumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("№1");
            Console.WriteLine("Целочисленные");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
            Console.WriteLine("Вещественные");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");
            Console.WriteLine("Символьный");
            Console.WriteLine($"char – {(int)char.MaxValue} – {(int)char.MinValue}");
            Console.WriteLine("Логический");
            Console.WriteLine($"bool - true - false");
            // 2
            Console.WriteLine();
            Console.WriteLine("№2");
            Console.Write("Введите имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите город: ");
            string userCite = Console.ReadLine();
            int userAge;
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (int.TryParse(Console.ReadLine(), out userAge) && userAge > 0 && userAge < 101)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            int userPin;
            while (true)
            {
                Console.Write("Введите PIN-код(3 цифры): ");
                if (int.TryParse(Console.ReadLine(), out userPin) && userPin >= 0 && userPin <= 999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            string name = userName;
            string city = userCite;
            int age = userAge;
            int pin = userPin;
            Console.WriteLine();
            Console.WriteLine($"Имя: {name}\n" + $"Город: {city}\n" + $"Возраст: {age}\n" + $"PIN: {pin}");

            // 3
            Console.WriteLine();
            Console.WriteLine("№3");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string res = "";
            for (int i = 0; i < input.Length; i++)
            {
                char u = input[i]; //получаем символ по индексу i
                if (char.IsLower(u))
                {
                    res += char.ToUpper(u);
                }
                else
                {
                    res += char.ToLower(u);
                }

            }
            Console.WriteLine($"Результат: {res}");
            //4
            Console.WriteLine();
            Console.WriteLine("№4");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string pod = Console.ReadLine();
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(pod, index)) != -1)
            {
                count++;
                index += pod.Length; //сдвигает позицию поиска за найденную подстроку
            }
            Console.WriteLine($"Кол-во вхождений: {count}");
            // 5
            Console.WriteLine();
            Console.WriteLine("№5");
            Console.Write("Обычная цена: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Цена со скидкой: ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("Стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            int save = normPrice - salePrice;
            int bottle = holidayPrice / save;
            Console.WriteLine($"Нужно бутылок: {bottle}");

            // 6
            Console.WriteLine();
            Console.WriteLine("№6");
            Drink[] drinks =
            {
                new Drink {Name="Пивасик",Percent=6},
                new Drink {Name="Винишко",Percent=15},
                new Drink {Name="Самогонка",Percent=45},
                new Drink {Name="Сок",Percent=0}    
            };
            Student[] students =
            {
                new Student {LastName= "Казаков",FirstName="Иван", ID=1,Category=Alcohol.a,DrinkType=drinks[2],V=500},
                new Student {LastName= "Николаев",FirstName="Сергей", ID=2,Category=Alcohol.b,DrinkType=drinks[1],V=300},
                new Student {LastName= "Сидоров",FirstName="Дима  ", ID=3,Category=Alcohol.c,DrinkType=drinks[0],V=600},
                new Student {LastName= "Козлова",FirstName="Анна", ID=4,Category=Alcohol.d,DrinkType=drinks[3],V=1500},
                new Student {LastName= "Петухов",FirstName="Никита", ID=5,Category=Alcohol.b,DrinkType=drinks[2],V=200}
            };
            double obshV = 0;
            double obshAl = 0;
            for (int i = 0;i < students.Length; i++)
            {
                obshV += students[i].V;
                obshAl += students[i].alcV;
            }
            Console.WriteLine($"Общий объем: {obshV} мл");
            Console.WriteLine($"Общий алкогооль: {obshAl} мл");
            for (int i = 0; i < students.Length; i++) 
            {
                double vPercent = students[i].V / obshV * 100;
                double alcPercent = 0;
                if (obshAl>0)
                {
                    alcPercent = students[i].alcV / obshAl * 100;
                }
                Console.WriteLine($"{students[i].LastName}, {vPercent:F1}% жидкости, {alcPercent:F1}% алкоголя");
            }
            

        }
    }
}
