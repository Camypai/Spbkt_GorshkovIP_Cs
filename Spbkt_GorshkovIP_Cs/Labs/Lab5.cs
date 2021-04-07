using System.Linq;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Даны две точки A(x1,y1) и B(x2,y2). Написать программу, которая определяет какая из точек расположена ближе к началу координат.
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab5
    {
        public static readonly MenuItem MenuItem = new MenuItem
        {
            Id    = 5,
            Title = "Лабараторная работа №5",
            Description =
                "Даны две точки A(x1,y1) и B(x2,y2). Написать программу, которая определяет какая из точек расположена ближе к началу координат.",
            ItemMethod = Init
        };

        private static void Init()
        {
            var firstPoint = new Point(Menu.Question("Введите координаты первой точки через пробел").Split(' ').Select(
                                           q =>
                                               new
                                               {
                                                   succes = int.TryParse(q, out var i),
                                                   result = i
                                               }).Select(q => q.result).ToList());

            var secondPoint = new Point(Menu.Question("Введите координаты второй точки через пробел").Split(' ').Select(
                                            q =>
                                                new
                                                {
                                                    succes = int.TryParse(q, out var i),
                                                    result = i
                                                }).Select(q => q.result).ToList());

            var comparer = firstPoint.Compare(secondPoint); 
            
            switch (comparer)
            {
                case 1:
                    Menu.Print("Точка 1 ближе к началу координат");
                    break;
                case -1:
                    Menu.Print("Точка 2 ближе к началу координат");
                    break;
                default:
                    Menu.Print("Точки равноудалены от начала координат");
                    break;
            }

            Menu.Pause();
        }
    }
}