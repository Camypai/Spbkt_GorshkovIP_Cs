using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дано целое число. Определить, является ли оно четным или нет. Результат вывести на экран
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab4
    {
        public static readonly MenuItem MenuItem = new MenuItem
        {
            Id          = 4,
            Title       = "Лабараторная работа №4",
            Description = "Дано целое число. Определить, является ли оно четным или нет. Результат вывести на экран",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var success = int.TryParse(Menu.Question("Введите целое число"), out var number);
            
            if (!success)
            {
                Menu.Print("Введено некорректное значение, убедитесь, что введено целое число");
                return;
            }
            
            Menu.Print($"Введённое число {number} является {(number.IsEven() ? "чётным" : "нечётным")}");
            
            Menu.Pause();
        }
    }
}