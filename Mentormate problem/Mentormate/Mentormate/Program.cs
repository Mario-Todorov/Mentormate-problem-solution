using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Mentormate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here the user data is taken and processed
            // using constructor from class TakeAndProcessUserInput.
            // On the following lines, the variables necessary for 
            // the solution of the problem are created.
            var userData = new TakeAndProcessUserInput();

            int x = userData.x;
            int y = userData.y;


            Dictionary<int, string> grid = new Dictionary<int, string>();

            grid = userData.grid;

            int x1 = userData.x1;
            int y1 = userData.y1;
            int N = userData.N;

            // Here the 2D array is created. It will contain
            // the data about each cell and its surrounding elements.
            int[,] newGridHelper = new int[y, x];

            int greenCells = 0;
            int specialCellGreenTransformations = 0;

            for (int i = 0; i < N; i++)
            {
                // Check if the special cell is green
                if (grid[y1][x1] == '1')
                {
                    specialCellGreenTransformations++;
                }

                // Here the data about the surrounding elements
                // is taken from the current grid.
                for (int k = 0; k < y; k++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        // Take the number of green cells around cell in top left corner 
                        if (k == 0 && j == 0)
                        {
                            greenCells = SurroundingElementsData.TopLeftCornerData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cells in top center
                        if (k == 0 && j > 0 && j < x - 1)
                        {
                            greenCells = SurroundingElementsData.TopCenterData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cell in top right corner 
                        if (k == 0 && j == x - 1)
                        {
                            greenCells = SurroundingElementsData.TopRightCornerData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cells in left side
                        if (k > 0 && k < y - 1 && j == 0)
                        {
                            greenCells = SurroundingElementsData.LeftSideData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cells in center of the grid
                        if (k > 0 && k < y - 1 && j > 0 && j < x - 1)
                        {
                            greenCells = SurroundingElementsData.CenterData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cells in right side
                        if (k > 0 && k < y - 1 && j == x - 1)
                        {
                            greenCells = SurroundingElementsData.RightSideData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cell in down left corner 
                        if (k == y - 1 && j == 0)
                        {
                            greenCells = SurroundingElementsData.DownLeftCornerData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cells in down center
                        if (k == y - 1 && j > 0 && j < x - 1)
                        {
                            greenCells = SurroundingElementsData.DownCenterData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                        // Take the number of green cells around cell in down right corner 
                        if (k == y - 1 && j == x - 1)
                        {
                            greenCells = SurroundingElementsData.DownRightCornerData(grid, k, j);
                            newGridHelper[k, j] = greenCells;
                        }
                    }
                }

                // Here the new generation of the grid is created
                for (int l = 0; l < y; l++)
                {
                    for (int p = 0; p < x; p++)
                    {
                        if (grid[l][p] == '0'
                            && (newGridHelper[l, p] == 3
                            || newGridHelper[l, p] == 6))
                        {
                            grid[l] = grid[l].Substring(0, p) +
                                      "1" + grid[l].Substring(p + 1);
                        }

                        if (grid[l][p] == '1'
                            && (newGridHelper[l, p] == 0
                            || newGridHelper[l, p] == 1
                            || newGridHelper[l, p] == 4
                            || newGridHelper[l, p] == 5
                            || newGridHelper[l, p] == 7
                            || newGridHelper[l, p] == 8)
                            )
                        {
                            grid[l] = grid[l].Substring(0, p) +
                                      "0" + grid[l].Substring(p + 1);
                        }

                    }
                }
            }

            // Check if the special cell last generation is green
            if (grid[y1][x1] == '1')
            {
                specialCellGreenTransformations++;
            }

            Console.WriteLine();
            Console.WriteLine("The cell with coordinats {0} and {1} " +
                              "was green {2} times!", x1, y1, specialCellGreenTransformations);

        }
    }
}