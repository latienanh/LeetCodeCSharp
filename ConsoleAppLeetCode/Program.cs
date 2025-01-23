using System.ComponentModel.DataAnnotations;

namespace ConsoleAppLeetCode;

public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        //false
        var subString = new List<string>();
        var index = 0;
        foreach (var charString in s)
        {
            if (subString.Count <= index)
            {
                subString.Add("");
            }

            if (subString[index] == "")
                subString[index] += charString;
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
    public static int LengthOfLongestSubstring2(string s)
    {
        var check = new HashSet<char>();
        var countPrev = 0;
        int left = 0;
        int right = 0;
        int maxLength = 0;
        for (int i = 0; i < s.Length; i++)
        {

            check.Add(s[i]);
            if (countPrev == check.Count)
            {

                left++;
                if (left < i + 1)
                {
                    i--;
                    continue;
                }
                    

            }

            right++;
            countPrev = check.Count;
            //if(check.Count)

        }
        maxLength = right - left;
        return maxLength;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var testString = "pwwkew";

        var maxLengthSubString = Solution.LengthOfLongestSubstring2(testString);
        Console.WriteLine(maxLengthSubString);
    }
}