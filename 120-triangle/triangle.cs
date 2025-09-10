public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle == null || triangle.Count == 0) return 0;

        int lastRowIndex = triangle.Count - 1;
        int[] dp = new int[triangle[lastRowIndex].Count];
        for (int i = 0; i < dp.Length; i++) dp[i] = triangle[lastRowIndex][i];

        for (int row = lastRowIndex - 1; row >= 0; row--)
            for (int col = 0; col < triangle[row].Count; col++)
                dp[col] = triangle[row][col] + Math.Min(dp[col], dp[col + 1]);

        return dp[0];
    }
}