using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Mentormate
{
    class TakeAndProcessUserInput
    {
        public int x;
        public int y;
        public Dictionary<int, string> grid = new Dictionary<int, string>();
        public int x1;
        public int y1;
        public int N;

        public TakeAndProcessUserInput()
        {
            Console.WriteLine("Please, enter your input:");
            Console.WriteLine();

            var gridSize = Console.ReadLine()
              .Split(',')
              .Select(int.Parse)
              .ToList();

            x = gridSize[0];
            y = gridSize[1];

            // Check if input is correct
            if (x <= 0 || x > 999 || y <= 0 || y > 999 || x > y)
            {
                    throw new Exception("Please, enter correct input!");
            }


            for (int i = 0; i < y; i++)
            {
                int row = i;
                string column = Console.ReadLine();
                grid.Add(row, column);
            }

            var specialCoordinatesData = Console.ReadLine()
               .Split(',')
               .Select(int.Parse)
               .ToList();

            x1 = specialCoordinatesData[0];
            y1 = specialCoordinatesData[1];
            N = specialCoordinatesData[2];
        }
    }
}
