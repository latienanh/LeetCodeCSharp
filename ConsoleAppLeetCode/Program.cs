public static class Solution
{
    public static int RomanToInt(string s)
    {
        int result = 0;

        char prevC = '\0';
        foreach (char c in s)
        {
            switch (c)
            {
                case 'I':
                    result += 1;
                    break;
                case 'V':

                    if (prevC == 'I')
                    {
                        result += 3;
                    }
                    else
                    {
                        result += 5;
                    }
                    break;
                case 'X':
                    if (prevC == 'I')
                    {
                        result += 8;
                    }
                    else
                    {
                        result += 10;
                    }
                    break;
                case 'L':

                    if (prevC == 'X')
                    {
                        result += 30;
                    }
                    else
                    {
                        result += 50;
                    }
                    break;
                case 'C':
                    if (prevC == 'X')
                    {
                        result += 80;
                    }
                    else
                    {
                        result += 100;
                    }
                    break;
                case 'D':
                    if (prevC == 'C')
                    {
                        result += 300;
                    }
                    else
                    {
                        result += 500;
                    }

                    break;
                case 'M':
                    if (prevC == 'C')
                    {
                        result += 800;
                    }
                    else
                    {
                        result += 1000;
                    }

                    break;
            }
            prevC = c;
        }

        return result;
    }
    public static int RomanToIntChatGPT(string s)
    {
        int result = 0;

        var romanDicnary = new Dictionary<char, int>()
        {
             { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && romanDicnary[s[i]] > romanDicnary[s[i - 1]])
                result -= 2*romanDicnary[s[i - 1]];
            result += romanDicnary[s[i]];
        }
        return result;
    }
}

public class Program()
{
    public static void Main(string[] args)
    {
        string s = "MCMXCIV";


        Console.WriteLine(Solution.RomanToIntChatGPT(s));
    }
}
