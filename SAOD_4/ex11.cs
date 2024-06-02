 using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;


namespace RegExpLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "asd1 fdsa2 asввd1";
            //Console.WriteLine(str);

            //Regex re = new Regex(@"."); // По символам
            //Regex re = new Regex(@"\w+"); // По словам
            //Regex re = new Regex(@"\b[0-9]+\w+\b"); // Слова, начинающиеся на цифру
            //Regex re = new Regex(@"\b\w*\d+\w*\b"); // Хотя бы 1 цифра в слове
            //Regex re = new Regex(@"\w+3\b"); // cлова, оканчивающиеся на 3
            //Regex re = new Regex(@"(\w)\1"); // cдвоенные символы
            //Regex re = new Regex(@"\b\w*(\w)\1\w*\b"); // Слова, где есть сдвоенные символы

            //Regex re = new Regex(@"(\W*)(\w+)(\W+)(\w+)(\W+)(\w+)(\W*)"); // 7 групп: {символы, слово, символы, слово, символы, слово, символы} Если переставляем чётные группы, то поменяем слова между собой 
            //Console.WriteLine(re.Replace(str, "$1$4$3$2$5$6$7"));

            //Regex re = new Regex(@"\b[^\W]+\b"); // Слова только из латиницы и цифр (есть проблема => \b\w+[^\W]\w+\b)
            //Regex re = new Regex(@"\b\w+\b"); // Слова, хотябы одна латинская буква (\b\w*[a-zA-Z]\w*\b)
            
            Regex reDeffect1 = new Regex(@"<(article||bold||)>(\W*)<\/\1>"); // пустой тег
            Regex reDeffect2 = new Regex(@"\s+(\s[-.?!)(,:])"); // пробелы перед знаками препинания 

            string orig;
            try
            {
                using (StreamReader sr = new StreamReader("Dictionary.xml"))
                {
                    orig = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка чтения файла: \"Dictionary.xml\"\n{0}", ex);
                return;
            }

            reDeffect1.Replace(orig, "$2");
            reDeffect2.Replace(orig, "$1");

            //MatchCollection mc = re.Matches(orig);
            //foreach (var m in mc)
            //    Console.WriteLine(m);
            try
            {
                using (StreamWriter sw = new StreamWriter("Dictionary1.xml"))
                {
                    sw.Write(orig);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сохранений в файл: \"{0}\"\n{1}", "Dictionary1.xml", ex);
                return;
            }
        }
    }
}
