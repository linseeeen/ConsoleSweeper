using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        Random generator = new Random();
        
        int[,] grid = new int[5, 5];
        
        public SweeperGrid()
        {
           for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    grid[i,j] = 9;
                } 
            }
            for (int i = 0; i < 10; i++)
            {
                int x = generator.Next(5);
                int y = generator.Next(5);
                grid[x, y] = 10;
            }
            
        }
        public bool CheckPosition(int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i,j] == grid[x,y])
                    {
                        if (grid[x,y] == 10)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void Draw() 
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ( grid[i,j] == 9)
                    {
                        Console.Write("█");
                    }
                    else if (grid[i,j] == 10)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
