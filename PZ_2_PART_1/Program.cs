namespace PZ_2_PART_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix ={{0,1,1,0,0},
                            {0,0,0,1,0},
                            {0,1,0,0,1},
                            {0,0,1,0,0},
                            {0,0,0,1,0}};

            PrintMatrix(matrix);

            Console.WriteLine();

            Console.WriteLine("Матрица достижимости для данного графа");
            var matrixAchievability = Graph.GetAchievability(matrix);
            PrintMatrix(matrixAchievability);

            Console.WriteLine();

            string msg = Graph.IsAdjacent(matrixAchievability) ? "" : "не ";
            Console.WriteLine($"Данный граф {msg}является связным");
        }

        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                    Console.Write(matrix[r, c] + " ");
                Console.WriteLine();
            }
        }
    }
}