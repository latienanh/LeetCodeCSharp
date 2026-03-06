// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string haystack = "hello";
string needle = "gg";
int k = new Solution().StrStr(haystack, needle);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack.Length - i < needle.Length)
            {
                return -1;
            }
            var checkString = haystack.Substring(i, needle.Length);
            if (checkString == needle)
            {
                return i;
            }
        }

        return -1;
    }
}

