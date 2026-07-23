public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> map = new();
        for(int p1 = 0 ; p1<nums.Length; p1++)
        {
           for(int p2 =p1+1 ; p2<nums.Length;p2++)
           {
            if(nums[p1]==nums[p2])
            {
                return true;
            }
           }
        }
        return false;
    }
}