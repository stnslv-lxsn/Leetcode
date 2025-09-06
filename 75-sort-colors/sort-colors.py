class Solution:
    def sortColors(self, nums: List[int]) -> None:
        n = len(nums) if len(nums) < 300 or len(nums) > 1 else 0

        for i in range(1, n):
            if nums[i] > 2:
                raise ValueError("Значения неверные")

        for i in range(n):
            for j in range(1, n - i):
                if nums[j] < nums[j - 1]:
                    temp = nums[j - 1]
                    nums[j - 1] = nums[j]
                    nums[j] = temp