public class Solution {
    public bool IsPalindrome(string s) 
    {
        int strLength = s.Length;
        int right = s.Length;
        for(int i = 0; i < Math.Floor(strLength/2.0); i++)
        {
            if(!char.IsLetterOrDigit(s[i])) continue;
            right -= 1;
            while(!char.IsLetterOrDigit(s[right])) right -=1;
            Console.WriteLine($"left = {s[i]} right = {s[right]}");
            if(char.ToUpperInvariant(s[i]) == char.ToUpperInvariant(s[right])) continue;
            return false;
        }
        return true;
    }
}
