public class Solution {
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
                    IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(candidates);
            backtrack(ref list, new List<int>(), candidates, target, 0,0);

            return list;        
    
    }
            private  void backtrack(ref IList<IList<int>> list, List<int> temp, int[] candidates, int target, int index,int sum)
        {
            if (sum == target)
            {
                list.Add(new List<int>(temp));

            }
            for (int i=index; i<candidates.Length; i++)
            {
                if (candidates[i] + sum <= target)
                {
                    temp.Add(candidates[i]);
                    backtrack(ref list, temp, candidates, target, i, sum+candidates[i]);
                        temp.RemoveAt(temp.Count - 1);
                }
            }
        }
}