public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++) {

            // skip duplicate i
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int l = i + 1;
            int r = n - 1;

            while (l < r) {

                int sum = nums[i] + nums[l] + nums[r];

                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[l], nums[r] });

                    l++;
                    r--;

                    // skip duplicates for l
                    while (l < r && nums[l] == nums[l - 1]) l++;

                    // skip duplicates for r
                    while (l < r && nums[r] == nums[r + 1]) r--;
                }
                else if (sum < 0) {
                    l++;
                } 
                else {
                    r--;
                }
            }
        }

        return result;
    }
}