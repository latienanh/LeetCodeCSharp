// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");
var a = new Solution();
Console.WriteLine(a.LongestCommonPrefix(["dog", "racecar", "car"]));

//public class Solution
//{
//    public string LongestCommonPrefix(string[] strs)
//    {
//        StringBuilder currentString = new StringBuilder();

//        int min = int.MaxValue;
//        foreach (string str in strs)
//        {
//            if (str.Length < min)
//            {
//                min = str.Length;
//            }
//        }

//        bool checkDone = false;
//        for (int i = 0; i < min; i++)
//        {
//            char? curentChar = null;
//            for (int k = 0; k < strs.Length; k++)
//            {
//                if (!curentChar.HasValue)
//                {
//                    curentChar = strs[k][i];
//                }
//                else
//                {
//                    if (curentChar != strs[k][i])
//                    {
//                        checkDone = true;
//                        break;
//                    }
//                }
//            }

//            if (checkDone == false)
//            {
//                currentString.Append(curentChar);
//            }
//            else
//            {
//                break;
//            }

//        }
//        return currentString.ToString();
//    }
//}

// GPT
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder currentString = new StringBuilder();

        int min = int.MaxValue;
        foreach (string str in strs)
        {
            if (str.Length < min)
            {
                min = str.Length;
            }
        }

        bool checkDone = false;
        for (int i = 0; i < min; i++)
        {
            char? curentChar = null;
            for (int k = 0; k < strs.Length; k++)
            {
                if (!curentChar.HasValue)
                {
                    curentChar = strs[k][i];
                }
                else
                {
                    if (curentChar != strs[k][i])
                    {
                        checkDone = true;
                        break;
                    }
                }
            }

            if (checkDone == false)
            {
                currentString.Append(curentChar);
            }
            else
            {
                break;
            }

        }
        return currentString.ToString();
    }
}
//public class Solution
//{
//    public string LongestCommonPrefix(string[] strs)
//    {
//        var lengMax = 0;
//        List<int> currentChecker = new List<int>();
//        for (int i = 0; i < strs[0].Length; i++)
//        {
//            var currentChar = strs[0][i];
//            var check = 0;
//            for (int j = 1; j < strs.Length; j++)
//            {
//                bool a = strs[j].Contains(currentChar);
//                if (a)
//                {
//                    check++;
//                }
//            }

//            if (check == strs.Length - 1)
//            {
//                currentChecker.Add((currentChecker.Count != 0
//                    ? currentChecker[currentChecker.Count - 1] : 0) + 1);
//            }
//            else
//            {
//                currentChecker.Add(0);
//            }


//        }
//        var max = 0;
//        var indexMax = 0;
//        for (int k = 0; k < currentChecker.Count; k++)
//        {
//            if (currentChecker[k] > max)
//            {
//                max = currentChecker[k];
//                indexMax = k;
//            }
//        }
//        if (max == 0)
//            return "";
//        var subPrev = indexMax - max < 0 ? 0 : indexMax - max + 1;
//        var subNext = indexMax - 1;
//        var stringReturn =  strs[0].Substring(subPrev, subNext);
//        return stringReturn;
//    }
//}


