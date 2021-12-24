using System;

namespace Kursovoi_proekt
{
    public class City
    {

        public int x { get; private set; }
        public int y { get; private set; }

        public City(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distanceTo(City c)
        {
            return Math.Sqrt(Math.Pow((c.x - this.x), 2)
                            + Math.Pow((c.y - this.y), 2));
        }

        public static City random()
        {
            return new City( GeneticController.rand.Next(GeneticController.Instance().weidth), GeneticController.rand.Next(GeneticController.Instance().height) );
        }

        public override string ToString()
        {
            return "[" + x + ", " + y + "]";
        }
    }
}
