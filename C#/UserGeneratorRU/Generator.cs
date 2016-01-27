using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace UserGeneratorRU
{
    static class Generator
    {
        public static Random random = new Random();
        // male
        private static List<string> maleFirstNames;
        public static List<string> MaleFirstNames
        {
            get 
            {
                if (maleFirstNames == null)
                {
                    maleFirstNames = new List<string>();
                    FillElement("../../Resources/ru/FirstName/male.txt", maleFirstNames);
                }
                return maleFirstNames;
            }
        }

        private static List<string> maleLastNames;
        public static List<string> MaleLastNames
        {
            get
            {
                if (maleLastNames == null)
                {
                    maleLastNames = new List<string>();
                    FillElement("../../Resources/ru/LastName/male.txt", maleLastNames);
                }
                return maleLastNames;
            }
        }

        private static List<string> malePatronymics;
        public static List<string> MalePatronymics
        {
            get
            {
                if (malePatronymics == null)
                {
                    malePatronymics = new List<string>();
                    FillElement("../../Resources/ru/Patronymic/male.txt", malePatronymics);
                }
                return malePatronymics;
            }
        }

        // female
        private static List<string> femaleFirstNames;
        public static List<string> FemaleFirstNames
        {
            get
            {
                if (femaleFirstNames == null)
                {
                    femaleFirstNames = new List<string>();
                    FillElement("../../Resources/ru/FirstName/female.txt", femaleFirstNames);
                }
                return femaleFirstNames;
            }
        }

        private static List<string> femaleLastNames;
        public static List<string> FemaleLastNames
        {
            get
            {
                if (femaleLastNames == null)
                {
                    femaleLastNames = new List<string>();
                    FillElement("../../Resources/ru/LastName/female.txt", femaleLastNames);
                }
                return femaleLastNames;
            }
        }

        private static List<string> femalePatronymics;
        public static List<string> FemalePatronymics
        {
            get
            {
                if (femalePatronymics == null)
                {
                    femalePatronymics = new List<string>();
                    FillElement("../../Resources/ru/Patronymic/female.txt", femalePatronymics);
                }
                return femalePatronymics;
            }
        }


        private static void FillElement(string pathFrom, List<string> destination)
        {
            TextReader srMaleFirstName = new StreamReader(pathFrom, Encoding.Default);
            while (true)
            {
                var readedStr = srMaleFirstName.ReadLine();
                if (readedStr == null)
                    break;
                destination.Add(readedStr);
            }
        }

        /// <summary>
        /// [0] - surname
        /// [1] - name
        /// [2] - Patronymic
        /// </summary>
        /// <returns></returns>
        public static List<string> GenerateFemale()
        {
            List<string> res = new List<string>();
            res.Add(ConvertRUToEN(FemaleLastNames[random.Next(FemaleLastNames.Count)]));
            res.Add(ConvertRUToEN(FemaleFirstNames[random.Next(FemaleFirstNames.Count)]));
            res.Add(ConvertRUToEN(FemalePatronymics[random.Next(FemalePatronymics.Count)]));
            return res;
        }

        /// <summary>
        /// [0] - surname
        /// [1] - name
        /// [2] - Patronymic
        /// </summary>
        /// <returns></returns>
        public static List<string> GenerateMale()
        {
            List<string> res = new List<string>();
            res.Add(ConvertRUToEN(MaleLastNames[random.Next(MaleLastNames.Count)]));
            res.Add(ConvertRUToEN(MaleFirstNames[random.Next(MaleFirstNames.Count)]));
            res.Add(ConvertRUToEN(MalePatronymics[random.Next(MalePatronymics.Count)]));
            return res;
        }

        public static string GenerateBirthday(int maxYear)
        {
            int year = random.Next(DateTime.Today.Year - 100, maxYear + 1);
            int month = random.Next(1, 13);
            int day;
            if (month == 2)
                day = random.Next(1, 29);
            else
                day = random.Next(1, 31);

            DateTime birthday = new DateTime(year, month, day);

            return birthday.ToString("d");
        }

        public static string GeneratePhoneNumber()
        {
            List<string> codes = new List<string>() { "29", "44", "33", "25" };
            string phomeNumber = "+375";
            phomeNumber += codes[random.Next(codes.Count)];
            for (int i = 0; i < 7; i++)
                phomeNumber += random.Next(10);

            return phomeNumber;
        }

        public static string GenerateEmail(string name, string surname, string yearOfBirthday)
        {
            List<string> emailProviderDomains = new List<string>() { "mail.ru", "gmail.com", "yandex.ru", 
                "onliner.by", "rambler.ru" ,"yahoo.com", "hehe.com" };
            string email = surname[0] + "." + name + yearOfBirthday;
            email += "@";
            email += emailProviderDomains[random.Next(emailProviderDomains.Count)];

            return email;
        }


        public static string ConvertRUToEN(string str)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>() 
            {
                {'А', "A"},{'а', "a"},{'Б', "B"},{'б', "b"},{'В', "V"},{'в', "v"},{'Г', "G"},{'г', "g"},
                {'Д', "D"},{'д', "d"},{'Е', "E"},{'е', "e"},{'Ё', ""},{'ё', ""},{'Ж', "Zh"},{'ж', "zh"},
                {'З', "Z"},{'з', "z"},{'И', "I"},{'и', "i"},{'Й', "J"},{'й', "j"},{'К', "K"},{'к', "k"},
                {'Л', "L"},{'л', "l"},{'М', "M"},{'м', "m"},{'Н', "N"},{'н', "n"},{'О', "O"},{'о', "o"},
                {'П', "P"},{'п', "p"},{'Р', "R"},{'р', "r"},{'С', "S"},{'с', "s"},{'Т', "T"},{'т', "t"},
                {'У', "U"},{'у', "u"},{'Ф', "F"},{'ф', "f"},{'Х', "H"},{'х', "h"},{'Ц', "Ts"},{'ц', "ts"},
                {'Ч', "Ch"},{'ч', "ch"},{'Ш', "Sh"},{'ш', "sh"},{'Щ', "Shch"},{'щ', "shch"},{'ъ', ""},{'ы', "y"},
                {'ь', ""},{'Э', "A"},{'э', "a"},{'Ю', "Yu"},{'ю', "yu"},{'Я', "Ya"},{'я', "ya"},
            };

            return string.Concat(str.Select(c => dict[c]));
        }
    }
}
