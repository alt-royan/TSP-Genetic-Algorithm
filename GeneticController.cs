using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Kursovoi_proekt
{
    class GeneticController
    {
        private static readonly GeneticController instance=new GeneticController();
        public const double mutRate = 0.05;
        public const int elitism = 6;
        public const int popSize = 60;

        public bool slowMotion { get; set; }
       
        public static Random rand = new Random();

        public int numCities { get; set; }
        public int height { get; set; }
        public int weidth { get; set; }

        public  bool doing;

        private Form1 view1;
        private ConsoleView view2;

        public void addFormView(Form1 form)
        {
            view1 = form;
        }

        public void addConsoleView(ConsoleView view2)
        {
            this.view2 = view2;
        }


        private Population population;

        private GeneticController()
        {

        }

        public static GeneticController Instance()
        {
            return instance;
        }

        public void initPopulation(List<City> cities)
        {
            Tour tour = new Tour(cities);
            population = Population.initPopulation(tour, popSize);
        }

        public void start()
        {
            doing = true;
            int gen = 1;
            bool better = true;

            while (doing)
            {
                if (better)
                    UpdateState(population, gen);

                better = false;
                double oldFit = population.maxFit;

                population = population.evolve();
                if (population.maxFit > oldFit)
                    better = true;

                gen++;
                if (slowMotion)
                {
                    Thread.Sleep(500);
                }
            }
        }
        public void stop()
        {
            doing = false;
        }

        private void UpdateState(Population p, int gen)
        {
            Tour best = p.findBest();
            view1.BestTour = best;
            view1.Invoke((MethodInvoker)delegate () {
                view1.UpdateState(best, gen);
            });
            view2.UpdateState(best, gen);
        }
    }
}
