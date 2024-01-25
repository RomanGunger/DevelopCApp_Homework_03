using DevelopCApp_Homework_03;

public static class Program
{
    static void Main(string[] args)
    {
        int[,] labirynth1 = new int[,]
{
{1, 1, 1, 1, 1, 1, 1 },
{1, 0, 0, 0, 0, 0, 1 },
{1, 0, 1, 1, 1, 0, 1 },
{0, 0, 0, 0, 1, 0, 2 },
{1, 1, 0, 0, 1, 1, 1 },
{1, 1, 1, 0, 1, 1, 1 },
{1, 1, 1, 2, 1, 1, 1 }
};

        int startI = 3;
        int startJ = 0;


        LabyrinthSolver labyrinthSolver = new LabyrinthSolver();

        Console.WriteLine("Number of exits: " + labyrinthSolver.HasExit(startI, startJ, labirynth1));
    }
}