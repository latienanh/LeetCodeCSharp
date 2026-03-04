// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
int k = new Solution().RemoveElement(nums, 2);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
            
        }

        return k;
    }
}

