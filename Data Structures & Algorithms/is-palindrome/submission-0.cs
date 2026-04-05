public class Solution {
    public bool IsPalindrome(string s) {

        var chars = s.ToLower().ToCharArray();
        int l = 0, r = chars.Length-1;
        while(l<r)
        {
            while(l<r && !char.IsLetterOrDigit(chars[l])) l++;
            while(l<r && !char.IsLetterOrDigit(chars[r])) r--;
            if (chars[l] != chars[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}
