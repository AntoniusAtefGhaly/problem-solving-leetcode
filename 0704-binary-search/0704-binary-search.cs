public class Solution {
    public int Search(int[] nums, int target) {
        
        int size=nums.Length;
        int l=0,r=size-1;
        int m=l+(r-l)/2;
        
        // if (size==1)
        // {
        //     if(nums[0]==target)
        //         return 0;
        // }
        while(l<=r){
            if(target==nums[m]){
                return m;
            }
            else if(target>nums[m]){
                l=m+1;
                m=l+(r-l)/2;
                
            }
            else{
                r=m-1;
                m=l+(r-l)/2;
            }
        }
        return -1;
    }
}

// l  m  r 
// 0  2  5
// 3  4  5
// 4  5  4