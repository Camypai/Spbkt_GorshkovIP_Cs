using System;
using System.Linq;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// По данным сторонам прямоугольника вычислить его периметр, площадь и длину диагонали
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab2
    {
        public static readonly MenuItem MenuItem = new MenuItem
        {
            Id          = 2,
            Title       = "Лабараторная работа №2",
            Description = "По данным сторонам прямоугольника вычислить его периметр, площадь и длину диагонали",
            ItemMethod  = Init
        };

        private static void Init()
        {
            var rectSides = Menu.Question("Введите длину и ширину прямоугольника через пробел").Split(' ').Select(q =>
                new
                {
                    succes = int.TryParse(q, out var i),
                    result = i
                }).ToList();

            if (rectSides.Any(q => !q.succes) || rectSides.Count > 2)
            {
                Menu.Print("Введены некорректные значения или их больше 2");
                return;
            }

            var p         = rectSides.Sum(q => q.result);
            var s         = rectSides.Select(q => q.result).Aggregate((a, b) => a * b);
            var sumSqrCat = rectSides.Sum(q => Math.Pow(q.result, 2));
            var gip       = Math.Sqrt(sumSqrCat);
            
            Menu.Print($"Периметр прямоугольника равен: {p}");
            Menu.Print($"Площадь прямоугольника равен: {s}");
            Menu.Print($"Гипотенуза прямоугольника равен: {gip}");

            Menu.Pause();
        }
    }
}