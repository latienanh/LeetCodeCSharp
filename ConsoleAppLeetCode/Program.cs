// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int k = new Solution().RemoveDuplicates(nums);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k-1])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}

