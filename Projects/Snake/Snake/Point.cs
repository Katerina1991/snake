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

        public Point(Point p)
        {
            x = p.X;
            y = p.Y;
            sym = p.sym;
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

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offset;
            else if(direction == Direction.LEFT)
                x = x - offset;
            else if (direction == Direction.UP)
                y = y - offset;
            else if (direction == Direction.DOWN)
                y = y + offset;
        }

        public override string ToString()
        {
            return x + ", " + y + ", "+ sym;
        }

        public void Clear()
        {
            Sym = ' ';
            Draw();
        }


        public bool IsHit(Point p)
        {
            return p.X == this.x && p.Y == this.Y;
        }
    }
}
