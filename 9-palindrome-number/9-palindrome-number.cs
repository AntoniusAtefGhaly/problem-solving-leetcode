public class Solution {
    public bool IsPalindrome(int x) {
        
        string st=x.ToString();
        if(x<0)
            return false;
        for (int i=0;i<st.Length;i++)
        {
            if(st[i]!=st[st.Length-1-i])
                return false;
        }
                    return true;
    }
}