public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int k = 0;
        int i = numbers.Length - 1;
        while (k < i) {
            int sum = numbers[k] + numbers[i];
            if (sum == target) {
                return new int[] { k + 1, i + 1 };  // 1-indexed
            } else if (sum > target) {
                i--;  // sum too big → shrink from i
            } else {
                k++;  // sum too small → grow from k
            }
        }
        return new int[2];
    }
}
