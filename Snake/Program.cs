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

			HorizontalLine topLine = new HorizontalLine(0, 79, 0, '+');
			HorizontalLine botLine = new HorizontalLine(0, 79, 23, '+');
			VerticalLine leftLine = new VerticalLine(0, 1, 22, '+');
			VerticalLine rightLine = new VerticalLine(79, 1, 22, '+');
			topLine.Draw();
			botLine.Draw();
			leftLine.Draw();
			rightLine.Draw();

			Point p = new Point(4, 6, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			while (true) 
			{
				if (Console.KeyAvailable) 
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
				Thread.Sleep(100);
				snake.Move();
			}

			Console.ReadLine();

		}
	}

}