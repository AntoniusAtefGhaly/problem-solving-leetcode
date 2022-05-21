using System;
public class Solution
{
    public int MyAtoi(string s)
    {
        //if (s == "") return 0;
        char[] chs = s.ToCharArray();
        long n=0;
        bool isnum = true;
        int i = 0;
        while (i<s.Length && isnum)
        {
            if((chs[i] >= '0' && chs[i] <= '9') || chs[i] == '-'|| chs[i] == '+')
            {
                if (chs[i] == '-')
                {
                    int j = i + 1;
                    while (j < s.Length && (chs[j] >= '0' && chs[j] <= '9') )
                    {
                        n = n * 10 + chs[j] - '0';
                        j++;
                        if (n >2147483648)
                        {
                            return -2147483648;
                        }
                    }
                    n *= -1;
                    return (int)n ;
                }
                else {
                    int j = i ;
                    if (chs[i] == '+') j = i + 1;
                    while (j < s.Length &&(chs[j] >= '0' && chs[j] <= '9') )
                    {
                        n = n * 10 + chs[j] - '0';
                        j++;
                        if (n > 2147483647)
                        {
                            return 2147483647;
                        }
                    }

                    return (int)n ;
                }
            }
            else if((chs[i] != ' '))
            {
                return 0;
            }
            i++;
        }
        return 0;
    }
}