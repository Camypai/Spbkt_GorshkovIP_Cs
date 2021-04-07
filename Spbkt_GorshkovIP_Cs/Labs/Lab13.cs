using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Реализовать метод возвращающий степень числа
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab13
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 13,
            Title       = "Лабараторная работа №13",
            Description = "Реализовать метод возвращающий степень числа",
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

            var result = number.Pow(2);
            
            Menu.Print($"Вторая степень числа {number} равна {result}");
            
            Menu.Pause();
        }
    }
}