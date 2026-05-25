public class Solution {
    public int MajorityElement(int[] nums) {

        int key = nums[0];
        int count =1;
        for(int i=1; i < nums.Length; i++){
            if(key == nums[i]){
                count++;
            }
            else{
                count--;
            }
            if(count<=0) key = nums[i];
            if(count >= nums.Length/2) return key; 
        }
        return key;
    }
}