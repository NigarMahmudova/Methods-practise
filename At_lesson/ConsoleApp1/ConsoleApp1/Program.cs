using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Siyahinin uzunlugunu daxil edin...");
            //int length = Convert.ToInt32(Console.ReadLine());
            //string[] wordArray = new string[length];

            //for (int i = 0; i < wordArray.Length; i++)
            //{
            //    Console.WriteLine($"Arrayin {i}-ci elementini daxil edin...");
            //    wordArray[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Yazi daxil edin...");
            //string word = Console.ReadLine();
            //bool result = FindWord(wordArray, word);
            //Console.WriteLine("Netice..." + result);
            //Console.WriteLine( "Simvol daxil edin...");
            //char cr = Convert.ToChar(Console.ReadLine());
            //bool result = IsDigit(cr);
            //Console.WriteLine("Netice..." + result);
            //string result = SubstringWord("HelloWorld", 5);
            //Console.WriteLine(result);
            string email;
            do
            {
                Console.WriteLine("Email daxil edin...");
                email = Console.ReadLine();

            } while (IsChar(email)!=true);


        }

        static bool FindWord (string[] str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i]==str2)
                {
                    return true;
                }
            }
            return false;
        }

        static bool FindNumber (int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==num)
                {
                    return true;
                }
            }
            return false;
        }

        static bool FindNumbers (int[] numbers, int[] values)
        {
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for (int j = 0; j < numbers2.Length; j++)
            //    {
            //        if (numbers1[i] == numbers2[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
            foreach (var number in numbers)
            {
                foreach (var value in values)
                {
                    if (number == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool IsChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '@')
                {
                    return true;
                }
            }
            
            return false;
        }

        //static bool CheckNumber(string str, char cr)
        //{
           
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (IsDigit(str[i]) == true)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        static int FindIndex (string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==cr)
                {
                    return i;
                }
            }
            return -1;
        }

        static string SubstringWord (string str, int index)
        {
            string substring = "";
            for (int i = 0; i < index; i++)
            {
                  substring += str[i];
            }
            return substring;
        }


    }
}
