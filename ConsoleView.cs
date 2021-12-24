using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoi_proekt
{
    class ConsoleView : View
    {
        public void UpdateState(Tour tour, int gen)
        {
            System.Console.WriteLine("Generation {0}\n" +
                "Best fitness:  {1}\n" +
                "Best distance: {2}\n" +
                "Tour: ", gen, tour.fitness, tour.distance);
            for (int i = 0; i < tour.tour.Count; i++)
            {
                Console.Write(tour.tour[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
