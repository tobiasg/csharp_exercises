using System.Text.RegularExpressions;

// https://leetcode.com/problems/valid-palindrome/

namespace ValidPalindrome {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ValidPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(ValidPalindrome("race a car"));
            Console.WriteLine(ValidPalindrome(" "));
        }

        public static bool ValidPalindrome(string s) {
            string stripped = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
            
            char[] charArray = stripped.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            
            return stripped.Equals(reversed);
        }
    }
}