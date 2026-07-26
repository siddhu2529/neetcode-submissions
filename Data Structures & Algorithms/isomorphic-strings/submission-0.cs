public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if(s==null || t==null || s.Length != t.Length) return false;

        Dictionary<char,char> charST = new Dictionary<char,char>();
        Dictionary<char,char> charTS = new Dictionary<char,char>();

        for(int i=0; i< s.Length; i++){
            char c1=s[i], c2=t[i];
            if(charST.ContainsKey(c1) && charST[c1] !=c2 || charTS.ContainsKey(c2) && charTS[c2] != c1){
                return false;
            }
            charST[c1] =c2;
            charTS[c2] =c1;
        }
        return true;
    }
}