# Codility-Ladder
You have to climb up a ladder.</br>
The ladder has exactly N rungs, numbered from 1 to N.</br>
With each step, you can ascend by one or two rungs.</br>
More precisely:</br>
with your first step you can stand on rung 1 or 2,</br>
if you are on rung K, you can move to rungs K + 1 or K + 2,</br>
finally you have to stand on rung N.</br>
Your task is to count the number of different ways of climbing to the top of the ladder.

For example, given N = 4, you have five different ways of climbing, ascending by:</br>
1, 1, 1 and 1 rung,</br>
1, 1 and 2 rungs,</br>
1, 2 and 1 rung,</br>
2, 1 and 1 rungs, and</br>
2 and 2 rungs.

Given N = 5, you have eight different ways of climbing, ascending by:</br>
1, 1, 1, 1 and 1 rung,</br>
1, 1, 1 and 2 rungs,</br>
1, 1, 2 and 1 rung,</br>
1, 2, 1 and 1 rung,</br>
1, 2 and 2 rungs,</br>
2, 1, 1 and 1 rungs,</br>
2, 1 and 2 rungs, and</br>
2, 2 and 1 rung.</br>
The number of different ways can be very large, so it is sufficient to return the result modulo 2P, for a given integer P.

Write a function:</br>
class Solution { public int[] solution(int[] A, int[] B); }</br>
that, given two non-empty arrays A and B of L integers, returns an array consisting of L integers specifying the consecutive answers;</br>
position I should contain the number of different ways of climbing the ladder with A[I] rungs modulo 2B[I].

For example, given L = 5 and:</br>
A[0] = 4   B[0] = 3</br>
A[1] = 4   B[1] = 2</br>
A[2] = 5   B[2] = 4</br>
A[3] = 5   B[3] = 3</br>
A[4] = 1   B[4] = 1</br>
the function should return the sequence [5, 1, 8, 0, 1], as explained above.

Write an efficient algorithm for the following assumptions:</br>
L is an integer within the range [1..50,000];</br>
each element of array A is an integer within the range [1..L];</br>
each element of array B is an integer within the range [1..30].
