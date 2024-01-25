using System;
namespace DevelopCApp_Homework_03
{
	public class LabyrinthSolver
	{

        public int HasExit(int startI, int startJ, int[,] l)
        {
            int exitCount = 0;
            bool[,] visited = new bool[l.GetLength(0), l.GetLength(1)];

            FindExit(startI, startJ, l, visited, ref exitCount);

            return exitCount;
        }

        private void FindExit(int i, int j, int[,] l, bool[,] visited, ref int exitCount)
        {
            int n = l.GetLength(0);
            int m = l.GetLength(1);

            if (i < 0 || i >= n || j < 0 || j >= m || visited[i, j])
                return;

            visited[i, j] = true;

            if (l[i, j] == 1)
                return;

            if (l[i,j] == 2)
            {
                exitCount++;
                return;
            }

            FindExit(i + 1, j, l, visited, ref exitCount);
            FindExit(i - 1, j, l, visited, ref exitCount);
            FindExit(i, j + 1, l, visited, ref exitCount);
            FindExit(i, j - 1, l, visited, ref exitCount);
        }
    }
}

