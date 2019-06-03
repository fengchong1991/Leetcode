// Running time: O(N)
// Space O(1)
public class Solution
{
    public int[] SortArrayByParity(int[] A)
    {
        for (int i = 0, j = A.Length - 1; i < j;)
        {
            if (A[i] % 2 == 1 && A[j] % 2 == 0)
            {
                var temp = A[j];
                A[j] = A[i];
                A[i] = temp;
            }
            else if (A[i] % 2 == 1)
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return A;
    }
}