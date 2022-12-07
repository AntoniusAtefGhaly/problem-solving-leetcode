public class Solution {
    public void ReverseString(char[] s) {
/**************sol 1****************/
        // for (int i=0;i<(int)(s.Length/2) +s.Length%2 ;i++){
        //     char temp=s[i];
        //     s[i]=s[s.Length-1-i];
        //     s[s.Length-1-i]=temp;
        // }
        
/**************sol 2****************/

        int m=(int)(s.Length/2) +s.Length%2;
        
         for (int i=0;i<m ;i++){
            char temp=s[i];
            s[i]=s[s.Length-1-i];
            s[s.Length-1-i]=temp;
        }
        
 /**************sol 3****************/
        //  int i = 0;
        // int j = s.Length - 1;
        // while (i < j) {
        //     char temp = s[i];
        //     s[i] = s[j];
        //     s[j] = temp;
        //     i++;
        //     j--;
        // }
}
}