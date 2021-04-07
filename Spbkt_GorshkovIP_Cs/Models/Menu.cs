using System;
using System.Collections.Generic;
using System.Linq;


namespace Spbkt_GorshkovIP_Cs.Models
{
    public class Menu
    {
        public static void Create(IEnumerable<MenuItem> menuPoints)
        {
            do
            {
                Console.Clear();
                
                Print(@"Введите цифру, соответствующую заданию.
Для выхода из программы введите ""q""");
                foreach (var menuPoint in menuPoints)
                {
                    Console.WriteLine($"{menuPoint.Id}: {menuPoint.Title}");
                }

                Print("Номер задания: ", true);
                var input = Console.ReadLine();
                if (menuPoints.Any(q => q.Id.ToString() == input))
                {   
                    var item = menuPoints.FirstOrDefault(q => q.Id.ToString() == input);
                    Print();
                    Print(item.Description);
                    item.ItemMethod();
                    continue;
                }

                if (input?.ToLower() == ConsoleKey.Q.ToString().ToLower())
                {
                    break;
                }
                
            } while (true);
        }
        
        public static void Print(string message = "", bool inLine = false)
        {
            if (!inLine)
            {
                Console.WriteLine(message);
                return;
            }

            Console.Write(message);
        }
        
        public static void Pause(string message = "Для завершения программы нажмите любую клавишу...") 
        {
            Console.Write(message);
            Console.ReadKey();
        }
        
        public static string Question(string question)
        {
            Console.Write($"{question}: ");
            return Console.ReadLine();
        }
    }
}