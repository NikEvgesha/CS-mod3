using System;

namespace CSharp_mod3
{
    class Program
    {

        enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        static void Main(string[] args)
        {
           
            
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            var birth_date = Console.ReadLine();
            Console.Write("Ваш любимый день недели: ");
            var fav_day = (DayOfWeek) int.Parse(Console.ReadLine());

            Console.WriteLine("Привет, {0}!\n\tВы родились {1}, и сейчас Ваш возраст - {2} \n\tЛюбимый день недели - {3}", name, birth_date, age, fav_day);
            Console.ReadKey();
        }
    }
}
