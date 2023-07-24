using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobus_Snopbus
{
    public class Game
    {
        public List<Shortcut> shortcuts = new List<Shortcut>();
        public Game(List<Shortcut> _shortcuts)
        {
            shortcuts = _shortcuts;
        }
        public void Start()
        {
            Random random = new Random();
            string _anganswer, _planswer, answer;
            double points = 0, final = 0;
            string fileName = @"../Files/skroty_wyniki.txt";
            bool flaga = true;
            while (flaga)
            {
                for (int i = 0; i < 20; i++)
                {
                    var question = random.Next(0, shortcuts.Count());
                    Console.WriteLine(i + "." + shortcuts[question]._short);
                    Console.Write("Angielskie rozwinięcie: ");
                    _anganswer = Console.ReadLine();
                    Console.Write("Polskie rozwinięcie: ");
                    _planswer = Console.ReadLine();
                    if (_anganswer.ToLower() == shortcuts[question]._ang.ToLower() && _planswer.ToLower() == shortcuts[question]._pl.ToLower())
                    {
                        points++;
                        Console.WriteLine("Odpowiedz poprawna");
                    }
                    if (_anganswer.ToLower() != shortcuts[question]._ang.ToLower() && _planswer.ToLower() == shortcuts[question]._pl.ToLower())
                    {
                        points += 0.5;
                        Console.WriteLine("Połowiczna odpowiedz");
                    }
                    if (_anganswer.ToLower() == shortcuts[question]._ang.ToLower() && _planswer.ToLower() != shortcuts[question]._pl.ToLower())
                    {
                        points += 0.5;
                        Console.WriteLine("Połowiczna odpowiedz");
                    }
                    if (_anganswer.ToLower() != shortcuts[question]._ang.ToLower() && _planswer.ToLower() != shortcuts[question]._pl.ToLower())
                        Console.WriteLine("Odpowiedz niepoprawna");
                    Console.WriteLine("\n\nPoprawne odpowiedzi:\nANG: " + shortcuts[question]._ang + "\nPL : " + shortcuts[question]._pl);
                }
                final = points / 20;
                Console.WriteLine(DateTime.Now + " --- Punkty: " + points + "/20 --- Wynik: " + Math.Round(final, 2) + "%;");
                if (fileName == null)
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(DateTime.Now + " --- Punkty: " + points + "/20 --- Wynik: " + Math.Round(final, 2) + "%;");
                    }
                else
                    using (StreamWriter writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(DateTime.Now + " --- Punkty: " + points + "/20 --- Wynik: " + Math.Round(final, 2) + "%;");
                    }
                Console.WriteLine("Jeszcze raz? Y/N");
                answer = Console.ReadLine();
                if (answer == "N")
                    flaga = false;
            }


        }
    }
}
