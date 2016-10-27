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
			List<char> charList = new List<char>();
			charList.Add('#');
			charList.Add('#');
			charList.Add('#');
			charList.Add('#');
			int count = 0;

			foreach (char i in charList)
			{
				Point p = new Point(count, 0, charList[count]);
				p.Draw();
				count++;
			}

			Console.ReadLine();

		}
	}

}