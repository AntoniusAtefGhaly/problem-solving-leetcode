using System;
public class Solution {
    public int[] SortedSquares(int[] arr) {

     for(int i=0;i<arr.Length;i++ ){
         arr[i]=arr[i]*arr[i]; 
     }
        
 Array.Sort(arr);
        return arr;
    }
}