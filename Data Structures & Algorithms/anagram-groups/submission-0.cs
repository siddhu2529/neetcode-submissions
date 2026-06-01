public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> output = new List<List<string>>();
        var map = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            int[] count = new int[26];
            foreach(char c in s){
                count[c - 'a']++;
            }
            var sb = new StringBuilder();
            for(int i=0; i<26;i++){
                sb.Append(count[i]);
                sb.Append('#');
            }
            string key = sb.ToString();
            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }
        var result = new List<List<string>>();

        foreach(var entry in map.Values){
            result.Add(entry);
        }
        return result;
    }
}
