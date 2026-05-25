public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        var output = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            map[num] = i;
        }
        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (map.ContainsKey(diff)) {
                var j = map.GetValueOrDefault(diff);
                if(i!=j){
                output.Add(i);
                output.Add(j);
                return output.ToArray();
                }
            }
        }
        return output.ToArray();
    }
}
