using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Написать программу, которая запрашивает размерность квадратного двумерного массива, заполняет массив случайными числами от 2 до 6 и вычисляет сумму элементов главной диагонали
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab10
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 10,
            Title       = "Лабараторная работа №10",
            Description = "Написать программу, которая запрашивает размерность квадратного двумерного массива, заполняет массив случайными числами от 2 до 6 и вычисляет сумму элементов главной диагонали",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var success = int.TryParse(Menu.Question("Введите размер квадратного двумерного массива"), out var number);
            
            if (!success)
            {
                Menu.Print("Введено некорректное значение, убедитесь, что введено целое положительное число");
                return;
            }
            
            var arr = new int[number, number];
            arr.FillRand(2, 6);
            var result = arr.SumByMainDiagonal();
            
            Menu.Print(arr.Show());
            Menu.Print($"Сумма элементов главной диагонали массива равна {result}");
            
            Menu.Pause();
        }
    }
}