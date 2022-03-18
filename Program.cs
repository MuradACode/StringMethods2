using System;

namespace StringMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Connects strings
        /// </summary>
        /// <param First part: ="firstPart"></param>
        /// <param Second part: ="secondPart"></param>
        /// <returns></returns>
        public string Concat(string firstPart, string secondPart)
        {
            return firstPart + secondPart;
        }
        /// <summary>
        /// Checks a string for empty or null
        /// </summary>
        /// <param Checked string:="check"></param>
        /// <returns></returns>
        public bool NullOrEmpty(string check)
        {
            bool isNullOrEmpty = false;
            if (check == "" && check == null)
            {
                isNullOrEmpty = true;
            }
            return isNullOrEmpty;
        }
        /// <summary>
        /// Connects string array with separator
        /// </summary>
        /// <param Separator: ="separator"></param>
        /// <param String array: ="array"></param>
        /// <returns></returns>
        public string Join(string separator, string[] array)
        {
            string joined = array[0] + separator;
            for (int i = 1; i <= array.Length - 1; i++)
            {
                if (i == array.Length - 1) separator = "";
                joined = joined + array[i] + separator;
            }
            return joined;
        }
    }
}
