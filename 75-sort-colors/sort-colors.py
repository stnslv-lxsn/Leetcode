class Solution:
    def sortColors(self, nums: List[int]) -> None:
        left = 0
        right = len(nums) - 1
        i = 0
        
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