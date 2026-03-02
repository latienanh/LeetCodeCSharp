// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new Solution();
Console.WriteLine(a.IsValid("()"));

// dùng loop
//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        var list = s.ToList();

//        if (list.Count % 2 != 0)
//        {
//            return false;
//        }
//        var dict = new Dictionary<char, char>()
//        {
//            {'[', ']'},
//            {'(', ')'},
//            {'{', '}'},
//            {'n', 'n'},
//        };
//        var listCheck = new char[]
//        {
//            ']', ')', '}'
//        };
//        for (int i = 0; i < list.Count; i++)
//        {
//            if (listCheck.Contains(list[i])) 
//            {
//                for (int j = i - 1; j >= 0; j--)
//                {
//                    if (dict.TryGetValue(list[j], out var value))
//                    {
//                        if (value == list[i])
//                        {
//                            list[i] = 'n';
//                            list[j] = 'n';
//                            break;
//                        }
//                        else if(value == 'n')
//                        {
//                            continue;
//                        }
//                        else
//                        {
//                            return false;
//                        }
//                    }

//                }
//            }
//        }

//        foreach (var l in list)
//        {
//            if (l != 'n')
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

//stack
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        var stack = new Stack<char>();

        var dict = new Dictionary<char, char>()
        {
            {']', '['},
            {')', '('},
            {'}', '{'},
        };

        foreach (var c in s)
        {
            if (dict.TryGetValue(c, out var value))
            {
                if (stack.Count == 0 || value != stack.Pop())
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}