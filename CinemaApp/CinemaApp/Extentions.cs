using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public static class Extentions
    {
        public static bool myContains(this string word, char a)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0) return true;

            return false;
        }
    }
}
