using System;
using System.Globalization;

namespace QLDSV_TC.Services
{
    public static class HandleString
    {
        public static string RemoveExtraSpaces(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }

        public static string RemoveAllSpaces(string input)
        {
            input = input.Replace(" ", "");
            return input;
        }

        public static string UpperFirstCharInString(string input)
        {
            string firstChar = input.Substring(0, 1).ToUpper(); 
            string output = firstChar + input.Substring(1);

            return output;
        }

        public static string UppercaseString(string input) 
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            input = textInfo.ToTitleCase(input.ToLower());

            return input;
        }
    }
}
