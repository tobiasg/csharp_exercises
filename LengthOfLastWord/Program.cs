using System;
using System.Linq;

// https://leetcode.com/problems/length-of-last-word/

namespace LengthOfLastWord {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(LengthOfLastWord("Hello World"));
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
        }

        public static int LengthOfLastWord(string s) {
            string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Last().Length;
        }
    }
}