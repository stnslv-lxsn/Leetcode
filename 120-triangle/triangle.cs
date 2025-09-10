public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle == null || triangle.Count == 0) return 0;

        int lastRowIndex = triangle.Count - 1;
        int[] dp = new int[triangle[lastRowIndex].Count];
        for (int i = 0; i < dp.Length; i++) dp[i] = triangle[lastRowIndex][i];

        for (int row = lastRowIndex - 1; row >= 0; row--)
        {
            int cols = triangle[row].Count;
            int[] newDp = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                newDp[col] = triangle[row][col] + Math.Min(dp[col], dp[col + 1]);
            }
            dp = newDp;
        }

        return dp[0];
    }
}