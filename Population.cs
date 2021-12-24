using System;
using System.Collections.Generic;
using System.Linq;

namespace Kursovoi_proekt
{

    public class Population
    {

        public List<Tour> p { get; private set; }
        public double maxFit { get; private set; }


        public Population(List<Tour> l)
        {
            this.p = l;
            this.maxFit = this.calcMaxFit();
        }

        public static Population initPopulation(Tour t, int n)
        {
            List<Tour> tmp = new List<Tour>();

            for (int i = 0; i < n; ++i)
                tmp.Add( t.shuffle() );

            return new Population(tmp);
        }

        private double calcMaxFit()
        {
            return this.p.Max( t => t.fitness );
        }

        public Tour select()
        {
            while (true)
            {
                int i = GeneticController.rand.Next(0, GeneticController.popSize);

                if (GeneticController.rand.NextDouble() < this.p[i].fitness / this.maxFit)
                    return new Tour(this.p[i].tour);
            }
        }

        public Population genNewPop(int n)
        {
            List<Tour> p = new List<Tour>();

            for (int i = 0; i < n; ++i)
            {
                Tour t = this.select().crossover( this.select() );

                foreach (City c in t.tour)
                    t = t.mutate();

                p.Add(t);
            }

            return new Population(p);
        }

        public Population elite(int n)
        {
            List<Tour> best = new List<Tour>();
            Population tmp = new Population(p);

            for (int i = 0; i < n; ++i)
            {
                best.Add( tmp.findBest() );
                tmp = new Population( tmp.p.Except(best).ToList() );
            }

            return new Population(best);
        }

        public Tour findBest()
        {
            foreach (Tour t in this.p)
            {
                if (t.fitness == this.maxFit)
                    return t;
            }

            return null;
        }

        public Population evolve()
        {
            Population best = this.elite(GeneticController.elitism);
            Population np = this.genNewPop(GeneticController.popSize - GeneticController.elitism);
            return new Population( best.p.Concat(np.p).ToList() );
        }
    }
}

