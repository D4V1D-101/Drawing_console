using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    class Box
    {
        private int _left;
        private int _top;
        private int _right;
        private int _bottom;
        private ConsoleColor _boxForeColor;


        public Box(int left, int top, int right, int bottom, ConsoleColor boxForeColor  = ConsoleColor.Yellow)
        {
            _left = left;
            _top = top;
            _right = right;
            _bottom = bottom;
            _boxForeColor = boxForeColor;
            //│─┌ ┐└ ┘

        }
        private char[] BoxChar = new char[6] { '│', '─', '┌', '┐', '└', '┘' };
        public void Draw()
        {
            //szin
            Console.ForegroundColor = _boxForeColor;
            //felsobal
            Console.SetCursorPosition(_left, _top);
            Console.Write(BoxChar[2]);
            //felsojobb
            Console.SetCursorPosition(_right, _top);
            Console.Write(BoxChar[3]);
            //alsobal
            Console.SetCursorPosition(_left, _bottom);
            Console.Write(BoxChar[4]);
            //alsojobb
            Console.SetCursorPosition(_right, _bottom);
            Console.Write(BoxChar[5]);

            
            for (int i = _left + 1; i < _bottom; i++)
            {
                Console.SetCursorPosition(i, _top);
                Console.WriteLine(BoxChar[1]);
                Console.SetCursorPosition(i, _bottom);
                Console.WriteLine(BoxChar[1]);
            }

            for (int i = _top + 1; i < _bottom; i++)
            {
                Console.SetCursorPosition(_left, i);
                Console.Write(BoxChar[0]);
                Console.SetCursorPosition(_right, i);
                Console.Write(BoxChar[0]);
                
            }


        }
        

    }
}
