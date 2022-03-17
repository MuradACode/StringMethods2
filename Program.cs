using System;

namespace StringMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Concat(string firstPart, string secondPart)
            {
                return firstPart + secondPart;
            }
            string Join(string separator, string[] array)
            {
                string joined = array[0] + separator;
                for (int i = 1; i <= array.Length - 1; i++)
                {
                    if (i == array.Length - 1) separator = "";
                    joined = joined + array[i] + separator;
                }
                return joined;
            }
            bool NullOrEmpty(string check)
            {
                bool isNullOrEmpty = false;
                if (check == "" && check == null)
                {
                    isNullOrEmpty = true;
                }
                return isNullOrEmpty;
            }
        }
    }
}
