using System;
using System.Collections.Generic;
using System.Linq;

namespace Kursovoi_proekt
{

    public class Tour
    {

        public List<City> tour { get; private set; }
        public double distance { get; private set; }
        public double fitness { get; private set; }

        public Tour(List<City> l)
        {
            this.tour = l;
            this.distance = this.calcDist();
            this.fitness = this.calcFit();
        }

        public static Tour random(int n)
        {
            List<City> t = new List<City>();

            for (int i = 0; i < n; ++i)
                t.Add( City.random() );

            return new Tour(t);
        }

        public Tour shuffle()
        {
            List<City> tmp = new List<City>(this.tour);
            int n = tmp.Count;

            while (n > 1)
            {
                n--;
                int k = GeneticController.rand.Next(1,n + 1);
                City v = tmp[k];
                tmp[k] = tmp[n];
                tmp[n] = v;
            }

            return new Tour(tmp);
        }

        public Tour crossover(Tour m)
        {
            int i = GeneticController.rand.Next(1, m.tour.Count);
            int j = GeneticController.rand.Next(i, m.tour.Count);
            List<City> s = this.tour.GetRange(i, j - i + 1);
            List<City> ms = m.tour.Except(s).ToList();
            List<City> c = ms.Take(i)
                             .Concat(s)
                             .Concat( ms.Skip(i) )
                             .ToList();
            return new Tour(c);
        }

        public Tour mutate()
        {
            List<City> tmp = new List<City>(this.tour);

            if (GeneticController.rand.NextDouble() < GeneticController.mutRate)
            {
                int i = GeneticController.rand.Next(1, this.tour.Count);
                int j = GeneticController.rand.Next(1, this.tour.Count);
                City v = tmp[i];
                tmp[i] = tmp[j];
                tmp[j] = v;
            }

            return new Tour(tmp);
        }

        private double calcDist()
        {
            double total = 0;
            for (int i = 0; i < this.tour.Count; ++i)
                total += this.tour[i].distanceTo( this.tour[ (i + 1) % this.tour.Count ] );

            return total;

            // Execution time is doubled by using linq in this case
            //return this.t.Sum( c => c.distanceTo(this.t[ (this.t.IndexOf(c) + 1) % this.t.Count] ) );
        }

        private double calcFit()
        {
            return 1 / this.distance;
        }

    }
}

