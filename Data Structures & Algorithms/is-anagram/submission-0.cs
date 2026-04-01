public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        Dictionary<char,int> freq = new Dictionary<char,int>();
        for(char i='a';i<='z';i++){
            freq[i] = 0;
        }
        for(int i=0; i<s.Length;i++){
            if (freq.ContainsKey(s[i]))
                freq[s[i]]++;
            if (freq.ContainsKey(t[i]))
                freq[t[i]]--;
        }
        foreach (var i in freq){
            if(i.Value != 0)
                return false;
        }
        return true;
    }
}
