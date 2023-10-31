using Codility_Ladder;

namespace Codility_LadderTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            Solution solution = new Solution();
            int[] A = { 4, 4, 5, 5, 1 };
            int[] B = { 3, 2, 4, 3, 1 };
            int[] expected = { 5, 1, 8, 0, 1 };
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleValueLowestRange()
        {
            Solution solution = new Solution();
            int[] A = { 1 };
            int[] B = { 1 };
            int[] expected = { 1 };
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleValueHighestRange()
        {
            Solution solution = new Solution();
            int[] A = { 50000 };
            int[] B = { 30 };
            int[] expected = solution.solution(A, B);
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEmptyInputArrays()
        {
            Solution solution = new Solution();
            int[] A = { };
            int[] B = { };
            int[] expected = { };
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEmptyInputArraysInRange()
        {
            Solution solution = new Solution();
            int[] A = { };
            int[] B = { };
            int[] expected = { };
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLargeInputs()
        {
            Solution solution = new Solution();
            int[] A = new int[50000];
            int[] B = new int[50000];
            int[] expected = solution.solution(A, B);
            int[] result = solution.solution(A, B);
            Assert.Equal(expected, result);
        }
    }
}