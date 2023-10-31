using System.Runtime.CompilerServices;

namespace Codility_Ladder
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 50000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(int[] A, int[] B)
        {
            int L = A.Length;
            int M = B.Length;

            if (L >= RANGE_LOWEST_VALUE && L <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE) 
            {
                int maxA = A.Max(); // Find the maximum value in array A
                int maxB = B.Max(); // Find the maximum value in array B

                if (maxA > 0 && maxB > 0) 
                {
                    int[] fib = new int[maxA + 1];
                    fib[0] = 1;
                    fib[1] = 1;

                    for (int i = 2; i <= maxA; i++)
                        fib[i] = (fib[i - 1] + fib[i - 2]) & ((1 << maxB) - 1);

                    int[] result = new int[A.Length];
                    for (int i = 0; i < A.Length; i++)
                    {
                        int ladderClimbs = fib[A[i]];
                        result[i] = ladderClimbs & ((1 << B[i]) - 1);
                    }

                    return result;
                }   
            }
            
            return Array.Empty<int>();
        }
    }
}
