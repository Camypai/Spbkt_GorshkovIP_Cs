using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Реализовать метод, который определяет является ли введенное предложение палиндромом (читается в обе стороны одинаково, например: А роза упала на лапу Азора)
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab15
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 15,
            Title       = "Лабараторная работа №15",
            Description = "Реализовать метод, который определяет является ли введенное предложение палиндромом (читается в обе стороны одинаково, например: А роза упала на лапу Азора)",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var sequence = Menu.Question("Введите предложение").ToLower();
            Menu.Print($"Введённое предложение{(sequence.IsPalindrome() ? "" : " не")} является палиндромом");
            
            Menu.Pause();
        }
    }
}