// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string s = "   fly me   to   the moon  ";

int k = new Solution().LengthOfLastWord(s);

Console.WriteLine($"Result:{k}");
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int count = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ' && count == 0)
            {
                continue;
            }
            if (s[i] == ' ' && count > 0)
            {
                break;
            }

            if (s[i] != ' ')
            {
                count++;
            }
        }
        return count;
    }
}
