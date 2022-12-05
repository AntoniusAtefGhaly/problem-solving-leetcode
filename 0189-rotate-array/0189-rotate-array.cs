public class Solution {
    public void Rotate(int[] nums, int k) {
        while(k>nums.Length)
            k-=nums.Length;
        int new_index;
        int[] nums_new=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            new_index=((i+k)<nums.Length)?(i+k):(i+k-nums.Length);
            nums_new[new_index]=nums[i];
        }
        for(int i=0;i<nums.Length;i++){
            nums[i]=nums_new[i];
        }

    }
}