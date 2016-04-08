using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls        
    {

        List<Figure> wallList;
        
        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();
           
            HorisontalLine UpLine = new HorisontalLine(0, mapWidht-2, 0, '+');       
            HorisontalLine DownLine = new HorisontalLine(0, mapWidht-2, mapHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight-1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidht-2, 0, mapHeight-1, '+');

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
           
        }

        public void Draw()
        {
            foreach (var wall in wallList)
                wall.Draw();
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if(wall.IsHit(figure))
                return true;
            }
            return false;
        }
    }
}
