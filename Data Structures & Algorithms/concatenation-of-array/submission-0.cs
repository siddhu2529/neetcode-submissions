public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[n * 2];

        int j=0;
        for(int i =0; i< ans.Length; i++){
            if(i<n){
            ans[i]=nums[i];
            }
            if(i>=n && j<n){
                ans[i] = nums[j];
                j++;
            }
        }
        return ans;
    }
}