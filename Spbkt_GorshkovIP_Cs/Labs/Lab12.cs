using System.Linq;
using System.Text.RegularExpressions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дана строка S. Определить есть ли в строке удвоенные буквы (пара соседствующих одинаковых букв), напечатать слова, содержащие их
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab12
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 12,
            Title       = "Лабараторная работа №12",
            Description = "Дана строка S. Определить есть ли в строке удвоенные буквы (пара соседствующих одинаковых букв), напечатать слова, содержащие их",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var          words   = Menu.Question("Введите предложение").Split(' ');
            const string pattern = @"(\w)\1";
            var          result       = words.Where(q => Regex.IsMatch(q, pattern, RegexOptions.IgnoreCase));
            
            Menu.Print($"Слова, содержащие сдвоенные символы: {string.Join(", ", result)}");
            
            Menu.Pause();
        }
    }
}