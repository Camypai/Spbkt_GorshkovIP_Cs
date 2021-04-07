using System;
using System.Collections.Generic;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Ввести ФИО и вывести на экран: «Лабораторную работу No1 выполнил: ФИО»
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab1
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 1,
            Title       = "Лабараторная работа №1",
            Description = "Ввести ФИО и вывести на экран: «Лабораторную работу №1 выполнил: ФИО»",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var fullname = Menu.Question("Введите ваше ФИО");
            Menu.Print($"Лабораторную работу №1 выполнил: {fullname}");
            
            Menu.Pause();
        }
    }
}