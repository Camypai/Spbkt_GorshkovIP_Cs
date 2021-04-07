﻿using System;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дан  номер  некоторого  года  (положительное  целое  число).
    /// Вывести  число  дней  в  этом  году,  учитывая,  что  обычный год насчитывает  365  дней,  а  високосный — 366  дней.
    /// Високосным считается  год,  делящийся  на  4,
    /// за  исключением  тех  годов,  которые делятся на 100 и не делятся на 400 (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
    /// Результатвывести на экран.
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab3
    {
        public static readonly MenuItem MenuItem = new MenuItem
        {
            Id          = 3,
            Title       = "Лабараторная работа №3",
            Description = @"Дан номер некоторого года (положительное целое число).
Вывести число дней в этом году, учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней.
Високосным считается год, делящийся на 4,
за исключением тех годов, которые делятся на 100 и не делятся на 400 (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
Результатвывести на экран.",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var success = int.TryParse(Menu.Question("Введите номер года"), out var year);

            if (!success)
            {
                Menu.Print("Введено некорректное значение, убедитесь, что введено положительное целое число");
                return;
            }
            
            Menu.Print($"В {year} году {(DateTime.IsLeapYear(year) ? 366 : 365)} дней");
            
            Menu.Pause();
        }
    }
}