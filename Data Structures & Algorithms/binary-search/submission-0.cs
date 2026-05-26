public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length -1;
        int i=0;
       var index = BinarySearch(i,n,nums,target);
       return index;
        
    }
   public int BinarySearch(int start, int end, int[] nums, int target){
    while(start<=end){
        int mid = start + end - start/2;
        if(nums[mid] == target){
            return mid;
        }
        else if(nums[mid]< target) {
            start = mid +1;
        }
        else{
            end = mid - 1;
        }
    }
    return -1;
        
    }
}
