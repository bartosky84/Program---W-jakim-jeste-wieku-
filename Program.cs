using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imie :");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);

            Console.WriteLine("Podaj swoj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < 18)
            {
                Console.WriteLine("Masz " + wiek + ", Nie jesteś pełnooletni i nie możesz napić się piwa");

            }
            else if (wiek > 18)
            {
                Console.WriteLine("Masz " + wiek + ", Jesteś pełnoletni i możesz zamówić alkochol");
            }
            Console.WriteLine("A teraz sprawdzimy czy możesz kandydować na Prezydenta");
           
            Console.WriteLine("Podaj jeszcze raz  swoj wiek: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Nie jesteś pełnoletni i nie możesz kandydować na Prezydenta");

            }
            else if ((age>=18)&&(wiek<35))
            {
                Console.WriteLine("Jesteś pełnoletni ale nie możesz jeszcze kandydować na Prezydenta");
            }
            else              
            {
                Console.WriteLine("jesteś pełnoletni i możesz kandydować na Prezydenta");
            }

            Console.ReadKey();
        }
    }
}
    
