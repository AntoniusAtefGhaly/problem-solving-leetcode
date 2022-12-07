public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=numbers.Length;

        int i1=0,i2=0;
        for(int i=0;i<l;i++){
            i1=i;
            int num2=target-numbers[i],
            s=i+1, e=numbers.Length-1;
            while(s<=e){
                int m=s+(e-s)/2;
                if(numbers[m]==num2){
                    return new int[]{i1+1,m+1};
                }
                else if(numbers[m]<num2){
                    s=m+1;
                }
                else{
                    e=m-1;
                }
            }
        }
        return new int[]{5,5};
    }
}