using System;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2)
            return s.Length;
        int max = 0, c = 1;
        string s2;
        if (s.Length > 2000)
            s = s.Substring(0, 2000);
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i ; j < s.Length; j++)
            {
                if((j - i + 1) > max)
                {
                    s2 = s.Substring(i, j - i + 1);

                    if (findRepeatFirstN2(s2) == -1)
                    {
                        if (s2.Length > max)
                        {
                            max = s2.Length;
                        }
                    }
                }
                //Console.WriteLine(s.Substring(i, j-i));
                 
                //if(!(s.Substring(i, j - i).Contains(s[j])))
                //{
                //    if((j-i+1)>max)
                //        max = j - i + 1;
                //}
                //{
                //    max = 0;
                //}
                //else
                //{
                //    max = j-i;
                //}
            }
        }
        return max;

    }

    int findRepeatFirstN2(string s)
    {
        // this is O(N^2) method
        int p = -1, i, j;
        for (i = 0; i < s.Length; i++)
        {
            for (j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    p = i;
                    break;
                }
            }
            if (p != -1)
                break;
        }

        return p;
    }

}