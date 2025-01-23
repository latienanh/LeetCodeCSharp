public static class Solution
{
    public static bool PalindromeNumber(int x)
    {
        if (x < 0) return false;
        var listInt = new List<int>();


        var result = x;
        var temp = x;
        while (temp > 0)
        {
            result = temp % 10;
            listInt.Add(result);
            temp = temp / 10;
        }

        for (int i = 0; i < listInt.Count / 2; i++)
        {
            if (listInt[i] != listInt[listInt.Count - i - 1])
                return false;
        }
        return true;
    }
    public static bool PalindromeNumberChatGpt(int x)
    {
        if (x < 0) return false;

        if (x != 0 && x % 10 == 0) return false;

        int reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedHalf || x == reversedHalf / 10;
    }
}

public class Program()
{
    public static void Main(string[] args)
    {
        var a = 1234321;

        Console.WriteLine(Solution.PalindromeNumber(a));
        Console.WriteLine(Solution.PalindromeNumberChatGpt(a));
    }
}
