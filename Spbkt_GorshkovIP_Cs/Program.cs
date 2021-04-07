using Spbkt_GorshkovIP_Cs.Labs;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        
        private static void ShowMenu()
        {
            Menu.Create(new []
            {
                Lab1.MenuItem,
                Lab2.MenuItem,
                Lab3.MenuItem,
                Lab4.MenuItem,
                Lab5.MenuItem,
                Lab6.MenuItem,
                Lab7.MenuItem,
                Lab8.MenuItem,
                Lab9.MenuItem,
                Lab10.MenuItem,
                Lab11.MenuItem,
                Lab12.MenuItem,
                Lab13.MenuItem,
                Lab14.MenuItem,
                Lab15.MenuItem
            });
        }
    }
}