public class Solution {
    public bool IsPalindrome(string s) {
        var stringArray = s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray(); 
        var k = stringArray.Length - 1;
        var i = 0;
        while (i < k) {
            if (stringArray[i] != stringArray[k]) {
                return false;
            }
            i++;
            k--;
        }
        return true;
    }
}
