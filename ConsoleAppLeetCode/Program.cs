using System.ComponentModel.DataAnnotations;

namespace ConsoleAppLeetCode;

public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        var subString = new List<string>();
        var index = 0;
        foreach (var charString in s)
        {
            if (subString.Count <= index)
            {
                subString.Add("");
            }

            if (subString[index] == "")
                    subString[index]+=charString;
            else
            {
                foreach (var charSubString in subString[index])
                {
                    if (charString == charSubString)
                    {
                        index++;
                        if (subString.Count <= index)
                        {
                            subString.Add("");
                        }
                        if (subString[index] == "")
                        break;
                    }
                }
                subString[index] += charString;
            }
            
        }
        var maxLengthSubString = 0;
        {
            foreach (var a in subString)
            {
                if (a.Length > maxLengthSubString)
                {
                    maxLengthSubString = a.Length;
                }
            }
        }
        return maxLengthSubString;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var testString = "abcabcbb";
        var maxLengthSubString = Solution.LengthOfLongestSubstring(testString);
        Console.WriteLine(maxLengthSubString);
    }
}