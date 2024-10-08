using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            while (true) // Бесконечный цикл
            {

                Console.WriteLine("Введите свой возраст (или 'exit' для выхода): " );

                string NameAge = Console.ReadLine();

                if (NameAge.ToLower() == "exit")  // Если пользователь захочет выйти

                {
                    break; // Выход
                }

                int Age;

                try
                {
                    Age = int.Parse(NameAge); //
                }

                catch (FormatException)
                {
                    Console.WriteLine("Неверно... ");

                    continue;
                }

                if (Age >= 18)
                {
                    Console.WriteLine("Ты большой дядя");
                }

                else
                {
                    Console.WriteLine("Идиот ливай с сайта, а то маме скажу");
                }
            }

            
        }
    }
}
