public class Solution {
        public  int RemoveDuplicates(int[] nums)
        {
            int index = 1;
            int[] num2=new int[nums.Length];

            if(nums.Length<2)
                return nums.Length;
            else if(nums.Length==2)
            {
                if (nums[0] == nums[1])
                    return 1;
                else
                    return 2;
            }
            //num2[index++]=nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums[i] < nums[i + 1]))
                {
                    nums[index++] = nums[i+1];
                }
            }
            //nums.Equals(num2);
            return index;
        }
}