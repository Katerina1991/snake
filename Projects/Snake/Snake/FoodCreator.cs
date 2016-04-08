using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator:Figure
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood(List<Point>  pointList)
        {
            int x;
            int y;
            Point p;

            do
            {
                x = random.Next(2, mapWidht - 2);
                y = random.Next(2, mapHeight - 2);
                p = new Point(x, y, sym);
            }

            while (pointList.Contains(p));


            return p;
        }
    }
}
