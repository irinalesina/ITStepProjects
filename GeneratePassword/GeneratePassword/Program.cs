using System;
using System.Collections.Generic;

namespace GeneratePassword
{
    class Program
    {
        static List<string> passwords = new List<string>();
        static int[] password = new int[5];
        static int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 };
        static List<int> occupiedDigits = new List<int>();


        static void Main(string[] args)
        {
            FindPassword();

            Console.WriteLine(passwords.Count);
            Console.ReadKey();
        }


        static bool FindElementInList(int el)
        {
            foreach(var i in occupiedDigits)
            {
                if (i == el)
                    return true;
            }
            return false;
        }


        static void FindPassword(int freePlace = 0)
        {
            if (freePlace == password.Length - 1)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    if (FindElementInList(i) == false)
                    {
                        password[freePlace] = digits[i];
                        string res = "";
                        foreach (var digit in password)
                            res += digit.ToString();
                        passwords.Add(res);
                    }
                }
                return;
            }


            for (int i = 0; i < digits.Length; i++)
            {
                if (FindElementInList(i) == false)
                {
                    occupiedDigits.Add(i);
                    password[freePlace] = digits[i];
                    FindPassword(freePlace + 1);
                    occupiedDigits.Remove(i);
                }
            }

            
        }
    }
}
