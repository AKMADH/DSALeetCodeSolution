using System;
namespace Application
{
	public class ValidPalindrome
	{
        public bool IsPalindrome(string s)
        {
            int l = 0; r = s.Length;
            s = s.ToLower().Regex.Replace(input, "[^a-zA-Z0-9]", "");
            s = s.Trim();
            while (l<=r)
            {
                if (s[l] != s[r])
                {
                    return false;
                }
                l++;
                r--;
                
            }
            return true;
        }
    }
}

