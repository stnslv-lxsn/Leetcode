class Solution:
    def sortColors(self, nums: list[int]) -> None:
        n = len(nums) if len(nums) > 1 or len(nums) < 300 else 0

        left = i = 0
        right = n - 1
        
        while i <= right:
            match nums[i]:
                case 0:
                    nums[i], nums[left] = nums[left], nums[i]
                    left += 1
                    i += 1
                case 1:
                    i += 1
                case 2:
                    nums[i], nums[right] = nums[right], nums[i]
                    right -= 1