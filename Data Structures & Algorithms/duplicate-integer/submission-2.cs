public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> map = new();
        for(int p1 = 0 ; p1<nums.Length; p1++)
        {
            if (map.ContainsKey(nums[p1]))
            {
                return true;
            }
            map.Add(nums[p1],1);
        }
        return false;
    }
}