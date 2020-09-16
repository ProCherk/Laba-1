using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"имя:{name}");
            Console.WriteLine($"возраст:{age}");
            Console.WriteLine($"вес: {weight}");
            Console.WriteLine($"работает: {isEmployed}");

            Console.WriteLine("имя : {0}, возраст - {1}", name, age);
            Console.Write("Введите имя: ");
            string name2 = Console.ReadLine();
            Console.WriteLine($"привет {name2}");


            Console.Write("Введите возраст ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"взраст - {age2}");

            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} cм Зарплата: {salary}$");

        }
    }
}
