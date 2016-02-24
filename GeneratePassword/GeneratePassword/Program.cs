using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i = 0 ; i < digits.Length; i++)
            {
                occupiedDigits.Add(i);
                Fillpassword(i, 0);
                occupiedDigits.Remove(i);
            }
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


        static void Fillpassword(int digPos, int freePlace)
        {
            password[freePlace] = digits[digPos];
            freePlace++;


            if (freePlace == password.Length - 1)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    if (FindElementInList(i) == false)
                    {
                        password[freePlace] = digits[i];
                        passwords.Add(password[0].ToString() + password[1].ToString() + password[2].ToString() + password[3].ToString() + password[4].ToString());
                    }
                }
                return;
            }


            for (int i = 0; i < digits.Length; i++)
            {
                if (FindElementInList(i) == false)
                {
                    occupiedDigits.Add(i);
                    Fillpassword(i, freePlace);
                    occupiedDigits.Remove(i);
                }
            }

            
        }
    }
}
