public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new();
        for(int p = 0 ; p<nums.Length;p++)
        {
            int num = target - nums[p];
            if(map.ContainsKey(num))
            {
                return new int[] {map[num],p};
            }
            map[nums[p]] = p ;
        }
        return null;
    }
}
