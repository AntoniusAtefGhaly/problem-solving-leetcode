public class Solution {
    public string ReverseWords(string s) {

                 string[] words = s.Split(' ');
                //       string[] words = phrase.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i]= new string(charArray);
                }

                return string.Join(" ", words);
}
}