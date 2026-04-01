public class Solution {

    public string Encode(IList<string> strs) {
        var encodedString = new StringBuilder();
        foreach (string str in strs){
            encodedString.Append(str.Length).Append("#").Append(str);
        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {
        var strs2 = new List<string>();
        int i=0;
        while(i<s.Length){
            int j=i;
            while(s[j]!='#'){
                j++;
            }

            int length = int.Parse(s.Substring(i,j-i));
            j++;
            string word = s.Substring(j,length);
            strs2.Add(word);

            i=j+length;
        }
        
        return strs2;
   }
}
