using System;
using System.Collections.Generic;
using System.IO;

namespace _2sem_8laba
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = File.ReadAllText("D:\\Lisa.txt").ToCharArray();
            OOP8.countCharacters(characters);
        }
    }

    public class OOP8
    {
        public static void countCharacters(char[] characters)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'а', 'о', 'у', 'е', 'и', 'і', 'ю', 'я', 'є', 'ї' };
            List<char> consonants = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь' };

            int countVowels = 0;
            int countConsonants = 0;

            foreach (char character in characters)
            {
                if (vowels.Contains(char.ToLower(character)))
                {
                    countVowels++;
                }
                if (consonants.Contains(char.ToLower(character)))
                {
                    countConsonants++;
                }
            }

            Console.WriteLine("Кiлькiсть голосних лiтер = " + countVowels + "\nКiлькiсть приголосних лiтер = " + countConsonants);
        }
    }
}
