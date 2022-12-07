public class Solution {
    public void ReverseString(char[] s) {

        // for (int i=0;i<(int)(s.Length/2) +s.Length%2 ;i++){
        //     char temp=s[i];
        //     s[i]=s[s.Length-1-i];
        //     s[s.Length-1-i]=temp;
        // }
        
         for (int i=0;i<(int)(s.Length/2) +s.Length%2 ;i++){
            char temp=s[i];
            s[i]=s[s.Length-1-i];
            s[s.Length-1-i]=temp;
        }
        
    }
}