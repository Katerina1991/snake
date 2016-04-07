using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '+');
            UpLine.Draw();
            HorisontalLine DownLine = new HorisontalLine(0, 78, 24, '+');
            DownLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Draw();

            Console.ReadLine();
        }

       

    }
}
