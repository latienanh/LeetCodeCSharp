// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] s = [1,9,9,9,9,9,9];

int[] k = new Solution().PlusOne(s);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int promise = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            promise = digits[i] + 1 % 2;

            digits[i] = (digits[i] + 1 + promise) % 10;

        }
        return digits;
    }
}
