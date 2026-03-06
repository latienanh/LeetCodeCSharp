// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = [1, 3];
int target = 2;

int k = new Solution().SearchInsert(nums, target);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {

        int left = 0;
        int right = nums.Length - 1;

        if (nums[left] > target)
            return 0;
        if (nums[right] < target)
        {
            return right + 1;
        }

        while (left <= right)
        {
            int mid = left + (right-left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}
