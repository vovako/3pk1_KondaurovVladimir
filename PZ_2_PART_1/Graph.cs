namespace PZ_2_PART_1
{
    public static class Graph
    {

        /*public static bool IsAdjacent(int[,] graph)
        {
            bool isAdjacentGraph = true;

            for (int row = 0; row < graph.GetLength(0); row++)
            {
                bool isAdjacentString = false;
                for (int col = 0; col < graph.GetLength(0); col++)
                    if (graph[row, col] == 1)
                    {
                        isAdjacentString = true;
                        break;
                    }

                if (!isAdjacentString)
                {
                    isAdjacentGraph = false;
                    break;
                }
            }
            return isAdjacentGraph;
        }*/

        public static int[,] GetAchievability(int[,] graph)
        {
            int size = graph.GetLength(0);
            var mNext = (int[,])graph.Clone();
            var mResult = (int[,])graph.Clone();

            for (int n = 0; n < size; n++)
            {
                mNext = Multiply(mNext, graph);
                mResult = Sum(mResult, mNext);
            }

            return mResult;
        }

        public static int[,] Multiply(int[,] m1, int[,] m2)
        {
            int size = m1.GetLength(0);
            var m = new int[size, size];
            
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    int value = 0;
                    for (int x = 0; x < size; x++)
                    {
                        value = m1[r, x] & m2[x, c];
                        if (value == 1)
                            break;
                    }
                    m[r, c] = value;
                }
            }


            return m;
        }
        
        public static int[,] Sum(int[,] m1, int[,] m2)
        {
            int size = m1.GetLength(0);
            var m = new int[size, size];

            for (int r = 0; r < size; r++)
                for (int c = 0; c < size; c++)
                    m[r, c] = m1[r, c] | m2[r, c];

            return m;
        }
    }
}
