class Solution {
    public:
        int climbStairs(int n) {
            if (n <= 2) return n;
            return matrixPower(n - 1)[0][0];
        }
        
    private:
        vector<vector<long long>> multiply(vector<vector<long long>>& a, vector<vector<long long>>& b) {
            vector<vector<long long>> result(2, vector<long long>(2));
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        result[i][j] += a[i][k] * b[k][j];

            return result;
        }
        
        vector<vector<long long>> matrixPower(int n) {
            vector<vector<long long>> base = {{1, 1}, {1, 0}};
            vector<vector<long long>> result = {{1, 0}, {0, 1}};
            
            while (n > 0) {
                if (n & 1)
                    result = multiply(result, base);
                base = multiply(base, base);
                n >>= 1;
            }
            
            return {{result[0][0] * 1 + result[0][1] * 1, 0}, {0, 0}};
        }
    };