using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert string1");
            string str1=  Console.ReadLine();
            //string str1 = null;
            Console.WriteLine("please insert string2");
            string str2 = Console.ReadLine();
            int result = StringCompare(str1, str2);
            //int result = string.Compare(str1, str2);
            Console.WriteLine(result);
            Console.ReadLine();

        }

      
        public static int StringCompare(string a, string b)
        {


            //a = Regex.Replace(a, @"[^\w]", string.Empty);// ignore special characters
            //b = Regex.Replace(b, @"[^\w]", string.Empty);


            //mystring = mystring.Replace("somestring", variable1) /// alternative for replacing special characters
            //       .Replace("somestring2", variable2)
            //       .Replace("somestring", variable1); 


            if (string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b)) ///handle cases where 1 or both strings are null
                return -1;
            if (string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(a))
                return 1;
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
                return 0;

            //a = a.ToLower(); //ignore case
            //b = b.ToLower();


            for (int i = 0; i < (a.Length > b.Length ? a.Length:b.Length); i++)
            {
                if ((char.IsLower(a[i]) && char.IsLower(b[i])) || (char.IsUpper(a[i]) && char.IsUpper(b[i]))) //mono an DEN ignoreCase
                {
                    if (a[i] - b[i] == 0)
                    { }
                    else
                    {
                        if (a[i] - b[i] < 0)
                        {
                            Console.WriteLine(a[i] - b[i]);
                            return -1;
                        }
                        else if (a[i] - b[i] > 0)
                            return 1;
                    }
                }
                else if (char.IsLower(a[i]) && char.IsUpper(b[i]))  //mono an DEN ignoreCase
                {
                    if (a[i].Equals(char.ToLower(b[i])))
                        return -1;
                    else if (a[i] - char.ToLower(b[i]) > 0)
                        return 1;
                    else return -1;
                }

                else if (char.IsLower(b[i]) && char.IsUpper(a[i]) && b[i].Equals(char.ToLower(a[i])))  //mono an DEN ignoreCase
                {
                    if (b[i].Equals(char.ToLower(a[i])))
                        return 1;
                    else if (b[i] - char.ToLower(a[i]) > 0)
                        return -1;
                    else return 1;
                }
                
            }
            if (a.Length.Equals(b.Length))
                return 0;
            else if (a.Length > b.Length)
                return 1;
            else return -1;
        }

        public static bool ReverseWordsNoSplit(string input, out string output)
        {
            output = string.Empty;
            List <string> words= new List<string>();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                char[] inputString = input.ToCharArray();
                foreach (char c in inputString)
                { 
               if (c != ' ')
               {
                   sb.Append(c);
               }
               else 
               {
                   words.Add(sb.ToString());
                   sb.Clear();
               }
           

                }
                if (sb.Length != 0)
                {
                    words.Add(sb.ToString());
                }
                string [] temp = words.ToArray();
                Array.Reverse(temp);
                output = string.Join(" ",temp);

                return true;
            }
        }

 public static bool ReverseWordswithRegex(string input, out string output)
        {
             output = string.Empty;

          if (string.IsNullOrEmpty(input))

            {return false;}
          else
            {
                string [] words = Regex.Split(input," ");
                Array.Reverse(words);
                output = string.Join(" ",words);
                return true;
            }
        }




        public static string reverseTextNoFunctions(string str)
        {
            string reverted = string.Empty;

            foreach (char ch  in str)
               {
                reverted = ch + reverted;
               }
            return reverted;

        }



        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
           return new string(arr);
            
        }


       /* public static string reverseWorsNoFunctions(string str)
        { 
        
        }*/


        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
       
        }

        private static string firstNonRepeatedChar(String str)
        {
            Hashtable h = new Hashtable();
            string fail = "no unique char";
            foreach (char c in str)
            {
                if (h.ContainsKey(c))
                {
                    h[c] = ((int)h[c]) + 1;
                }
                else
                {
                    h[c] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (h[c].Equals(1))
                {
                    return c.ToString();
                }
               
                
            }
            return fail;
        }

        /////////////////////////////////////////////////////////////////

        private static bool IsPal(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            s.ToLower();
            s = s.Replace(" ", string.Empty);

            foreach (char c in s)
            {
                if (!IsAlphanumeric(c))
                    return false;
            }
            char[] tempstring = s.ToCharArray();

            Array.Reverse(tempstring);
            string s1 = new string(tempstring);
            if (s1 == s)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    
        /// ////////////////////////////////////////////////////////////////////////////

        private static bool IsAlphanumeric(char c)
        {
            if (char.IsLetter(c) | char.IsNumber(c))

                return true;

            else
                return false;
        }



        /// //////////////////////////////////////////////////////////////


        private static bool Anagram(string parameter1, string parameter2)
        {
            if (string.IsNullOrEmpty(parameter1) || string.IsNullOrEmpty(parameter2))
                return false;   //Check if any string is null
            else if (parameter1.Length != parameter2.Length)
                return false;   //Check if the length of the two strings is equal
            else
                return parameter1.OrderBy(x => x).SequenceEqual(parameter2.OrderBy(x => x));
        }



       
        /// ////////////////////////////////////////////


        private static int String2Int(string str)
        {
            int i = 0;
            int num = 0;
            bool isNeg = false;
            int len = str.Length;
            if (str[0] == '-')
            {
                isNeg = true;
                i = 1;
            }
            while (i < len)
            {
                num *= 10;
                num += (str[i++] - '0');
            }
            if (isNeg)
                num *= -1;
            return num;

        }



        /// ////////////////////////////////////////////

       private static string Int2String(int num)
        {
            int i = 0;
            bool isNeg = false;
            char[] temp = new char[11];
            if (num < 0)
            {
                num *= -1;
                isNeg = true;
            }
            do
            {
                temp[i++] = (char)((num % 10) + '0');
                num /= 10;
            } while (num != 0);
            StringBuilder b = new StringBuilder();
            if (isNeg)
                b.Append('-');
            while (i > 0)
            {
                b.Append(temp[--i]);
            }
            return b.ToString();
        }
        







    }
}
