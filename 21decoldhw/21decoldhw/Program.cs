using System;

namespace _21decoldhw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazini daxil et");
            string text = Console.ReadLine();
            FixSentence(ref text);
            Console.WriteLine(text);


           

            Console.WriteLine(FindCount(text));

            

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            add(ref numbers, 20);

            
            string[] fullnames = { "Amin Israfilzade", "Maqsud Muslumov", "Tural Isbatov" };
            var names = makenewname(fullnames);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }

            
            Console.WriteLine(" Adi Daxil Edin");
            var str = Console.ReadLine();
            var namees = Isfullname(str);
            Console.WriteLine(namees);




        }

        
        static void FixSentence(ref string str)
        {
            str = str.Trim();
            string newStr = "";
            var arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    newStr += arr[i];
                    if (i < arr.Length - 1)
                    {
                        newStr += ' ';
                    }

                }


            }
            str = newStr;

        }

       
        static int FindCount(string strr)
        {
            FixSentence(ref strr);
            return strr.Split(' ').Length;

        }

       
        static void add(ref int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];

            }
            newarr[arr.Length - 1] = value;
            arr = newarr;
        }
        
        static string[] makenewname(string[] fullnames)
        {
            string[] arr = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                arr[i] = fullnames[i].Substring(0, fullnames[i].IndexOf(' '));

            }
            return arr;
        }
        
        static bool Finder(string str)
        {
            if (Char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return false;
        }
        static bool Isfullname(string soz)
        {
            var words = soz.Split(' ');
            if (words.Length != 2)
            {
                return false;
            }
            if (!Finder(words[0]) || !Finder(words[1]))
            {
                return false;
            }
            return true;
        }
    }
}
