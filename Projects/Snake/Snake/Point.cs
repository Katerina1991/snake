using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x; int y; char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public int X
        {
            get {return x;}
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public char Sym
        {
            get { return sym; }
            set { sym = value; }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
