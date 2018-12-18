using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE___Exercice_6
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            Enum.GetValues(typeof(Week));
            foreach(Week day in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(day.ToString());
            }
        }
    }
}
