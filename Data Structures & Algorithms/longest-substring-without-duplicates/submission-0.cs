public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;

        var lastIndex = new Dictionary<char,int>();
        int left=0;
        int right =0;
        int maxLen=0;
        while(right<s.Length){
            char c = s[right];

            if(lastIndex.ContainsKey(c) && lastIndex[c] >=left){
                left = lastIndex[c] +1;
            }
            lastIndex[c] = right;

            int windowLen = right - left + 1;
            if(windowLen > maxLen){
                maxLen = windowLen;
            }
            right ++;
        }
        return maxLen;
    }
}
