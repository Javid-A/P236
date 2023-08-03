using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Enum__Nullable
{
    internal static class Extension
    {
        public static string ToCapitalized(this string word)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string lowerResult = word.ToLower();

            stringBuilder.Append(char.ToUpper(lowerResult[0]));
            stringBuilder.Append(lowerResult.Substring(1));
            return stringBuilder.ToString();
        }



        public static bool CustomContains(this string sentence,string search)//Bu bir custom contains methodudur
        {
            string[] arr = sentence.Split();

            foreach (string word in arr)
            {
                if(word == search)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
