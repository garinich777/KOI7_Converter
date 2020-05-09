using System;

namespace text_to_koi
{
    class Program
    {
        static string Convertor(string text)
        {
            string koi = "";
            foreach (char symbol in text)
            {
                switch (symbol)
                {
                    case ('А'):
                    case ('а'):
                        koi += "61";
                        break;
                    case ('Б'):
                    case ('б'):
                        koi += "62";
                        break;
                    case ('В'):
                    case ('в'):
                        koi += "77";
                        break;
                    case ('Г'):
                    case ('г'):
                        koi += "67";
                        break;
                    case ('Д'):
                    case ('д'):
                        koi += "64";
                        break;
                    case ('Е'):
                    case ('е'):
                        koi += "65";
                        break;
                    case ('Ё'):
                    case ('ё'):
                        koi += "65";
                        break;
                    case ('Ж'):
                    case ('ж'):
                        koi += "76";
                        break;
                    case ('З'):
                    case ('з'):
                        koi += "7A";
                        break;
                    case ('И'):
                    case ('и'):
                        koi += "69";
                        break;
                    case ('Й'):
                    case ('й'):
                        koi += "6A";
                        break;
                    case ('К'):
                    case ('к'):
                        koi += "6B";
                        break;
                    case ('Л'):
                    case ('л'):
                        koi += "6C";
                        break;
                    case ('М'):
                    case ('м'):
                        koi += "6D";
                        break;
                    case ('Н'):
                    case ('н'):
                        koi += "6E";
                        break;
                    case ('О'):
                    case ('о'):
                        koi += "6F";
                        break;
                    case ('П'):
                    case ('п'):
                        koi += "70";
                        break;
                    case ('Р'):
                    case ('р'):
                        koi += "72";
                        break;
                    case ('С'):
                    case ('с'):
                        koi += "73";
                        break;
                    case ('Т'):
                    case ('т'):
                        koi += "74";
                        break;
                    case ('У'):
                    case ('у'):
                        koi += "75";
                        break;
                    case ('Ф'):
                    case ('ф'):
                        koi += "66";
                        break;
                    case ('Х'):
                    case ('х'):
                        koi += "68";
                        break;
                    case ('Ц'):
                    case ('ц'):
                        koi += "63";
                        break;
                    case ('Ч'):
                    case ('ч'):
                        koi += "7E";
                        break;
                    case ('Ш'):
                    case ('ш'):
                        koi += "7B";
                        break;
                    case ('Щ'):
                    case ('щ'):
                        koi += "7D";
                        break;
                    case ('Ъ'):
                    case ('ъ'):
                        koi += "78";
                        break;
                    case ('Ы'):
                    case ('ы'):
                        koi += "79";
                        break;
                    case ('Ь'):
                    case ('ь'):
                        koi += "78";
                        break;
                    case ('Э'):
                    case ('э'):
                        koi += "7C";
                        break;
                    case ('Ю'):
                    case ('ю'):
                        koi += "60";
                        break;
                    case ('Я'):
                    case ('я'):
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
