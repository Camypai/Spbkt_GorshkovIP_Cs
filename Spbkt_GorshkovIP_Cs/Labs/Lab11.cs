using System.Linq;
using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дана строка. Вывести все слова, у которых первая и последняя буквы одинаковые не используя стандартные средства для разбиения строк
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab11
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 11,
            Title       = "Лабараторная работа №11",
            Description = "Дана строка. Вывести все слова, у которых первая и последняя буквы одинаковые не используя стандартные средства для разбиения строк",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var str = Menu.Question("Введите предложение").MyOwnSplit(' ').ToList();

            var result = str.Where(q => q.ToLower().First() == q.ToLower().Last());
            
            Menu.Print($"Слова, у которых первая и последняя буквы совпадают: {string.Join(", ", result)}");
            
            Menu.Pause();
        }
    }
}