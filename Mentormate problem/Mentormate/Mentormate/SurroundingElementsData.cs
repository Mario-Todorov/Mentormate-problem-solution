using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate
{
    class SurroundingElementsData
    {

        public static int TopLeftCornerData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int TopCenterData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j + 1].Equals('1'))
            {
                greenCells++;
            }

            return greenCells;
        }

        public static int TopRightCornerData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int LeftSideData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int CenterData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int RightSideData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k + 1][j].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int DownLeftCornerData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int DownCenterData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j + 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j + 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }

        public static int DownRightCornerData(Dictionary<int, string> grid, int k, int j)
        {
            int greenCells = 0;

            if (grid[k - 1][j - 1].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k - 1][j].Equals('1'))
            {
                greenCells++;
            }
            if (grid[k][j - 1].Equals('1'))
            {
                greenCells++;
            }
            return greenCells;
        }
    }

}
