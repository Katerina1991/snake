using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);


            HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '+');
            UpLine.Draw();
            HorisontalLine DownLine = new HorisontalLine(0, 78, 24, '+');
            DownLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo key = Console.ReadKey(true);

                    while (Console.KeyAvailable) 
                        key = Console.ReadKey(true);

                    snake.HandleKey(key.Key);
                    
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Console.ReadLine();
        }

       

    }
}
