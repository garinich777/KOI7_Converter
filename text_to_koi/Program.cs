using System;

namespace text_to_koi
{
    class Program
    {
        static string Convertor(string text)
        {
            string koi = "";
            foreach (char symbol in text.ToUpper())
            {
                switch (symbol)
                {
                    case ('А'):
                        koi += "61";
                        break;
                    case ('Б'):
                        koi += "62";
                        break;
                    case ('В'):
                        koi += "77";
                        break;
                    case ('Г'):
                        koi += "67";
                        break;
                    case ('Д'):
                        koi += "64";
                        break;
                    case ('Е'):
                        koi += "65";
                        break;
                    case ('Ё'):
                        koi += "65";
                        break;
                    case ('Ж'):
                        koi += "76";
                        break;
                    case ('З'):
                        koi += "7A";
                        break;
                    case ('И'):
                        koi += "69";
                        break;
                    case ('Й'):
                        koi += "6A";
                        break;
                    case ('К'):
                        koi += "6B";
                        break;
                    case ('Л'):
                        koi += "6C";
                        break;
                    case ('М'):
                        koi += "6D";
                        break;
                    case ('Н'):
                        koi += "6E";
                        break;
                    case ('О'):
                        koi += "6F";
                        break;
                    case ('П'):
                        koi += "70";
                        break;
                    case ('Р'):
                        koi += "72";
                        break;
                    case ('С'):
                        koi += "73";
                        break;
                    case ('Т'):
                        koi += "74";
                        break;
                    case ('У'):
                        koi += "75";
                        break;
                    case ('Ф'):
                        koi += "66";
                        break;
                    case ('Х'):
                        koi += "68";
                        break;
                    case ('Ц'):
                        koi += "63";
                        break;
                    case ('Ч'):
                        koi += "7E";
                        break;
                    case ('Ш'):
                        koi += "7B";
                        break;
                    case ('Щ'):
                        koi += "7D";
                        break;
                    case ('Ъ'):
                        koi += "78";
                        break;
                    case ('Ы'):
                        koi += "79";
                        break;
                    case ('Ь'):
                        koi += "78";
                        break;
                    case ('Э'):
                        koi += "7C";
                        break;
                    case ('Ю'):
                        koi += "60";
                        break;
                    case ('Я'):
                        koi += "71";
                        break;
                    case (' '):
                        koi += "20";
                        break;
                    case ('0'):
                        koi += "30";
                        break;
                    case ('1'):
                        koi += "31";
                        break;
                    case ('2'):
                        koi += "32";
                        break;
                    case ('3'):
                        koi += "33";
                        break;
                    case ('4'):
                        koi += "34";
                        break;
                    case ('5'):
                        koi += "35";
                        break;
                    case ('6'):
                        koi += "36";
                        break;
                    case ('7'):
                        koi += "37";
                        break;
                    case ('8'):
                        koi += "38";
                        break;
                    case ('9'):
                        koi += "39";
                        break;
                    case (':'):
                        koi += "3A";
                        break;
                    default:
                        break;
                }
                koi += " ";
            }
            return koi;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите текст:");
                string text = Console.ReadLine();
                Console.WriteLine(Convertor(text));
            }
        }
    }
}
