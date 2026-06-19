public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int res = -1;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (charIndex.ContainsKey(c)) {
                res = Math.Max(res, i - charIndex[c] - 1);
            } else {
                charIndex[c] = i;
            }
        }

        return res;
    }
}