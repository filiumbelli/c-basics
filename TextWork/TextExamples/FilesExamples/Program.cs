using System;
using System.Collections.Generic;
namespace TextExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fullName = "Serhat sofisticat";
            //Console.WriteLine("Trim: {0}",fullName.Trim());
            //Console.WriteLine("Upper: {0}",fullName.ToUpper());

            //var firstName = fullName.Split(" ")[0];
            //var lastName = fullName.Split(" ")[1];
            //Console.WriteLine("Fn: {0} Ln: {1}",firstName,lastName);
            //var firstName2 =fullName.Substring(0,fullName.IndexOf(" "));
            //var lastName2 = fullName.Substring(fullName.IndexOf(" ")+1);
            //Console.WriteLine("Fn: {0} Ln: {1}",firstName2,lastName2);

            //if (String.IsNullOrEmpty(firstName))
            //{
            //    Console.WriteLine("It is empty..");
            //}
            //if (String.IsNullOrWhiteSpace(lastName))
            //{
            //    Console.WriteLine("It is whitespace");
            //}

            //float price = 29.95f;

            //Console.WriteLine(price.ToString("c"));

            var sentence = "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long\n" +
                "hey i am going to be long";

            const int maxLength = 60;
            var currentWords = new List<string>();

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(" ");
                var totalCharachters = 0;
                foreach (var word in words)
                {
                    totalCharachters += word.Length;
                    if (totalCharachters > maxLength)
                    {
                        break;
                    }
                    currentWords.Add(word);
                }
            }
            var summary = String.Join(" ", currentWords) + "...";

            Console.WriteLine(summary);
            Console.WriteLine(Consecutive(new int[9] { 1, 3, 5, 6, 7, 27, 2, 72, 2 }));
            Console.WriteLine(Consecutive(new int[3] { 3, 4, 5 }));

        }

        public static bool Consecutive(int[] array)
        {

            int conscount = 0;
            int inconscount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (Math.Abs(array[i] - array[i + 1]) == 1)
                {
                    if ((array[i] - array[i + 1]) == 1)
                    {
                        inconscount++;
                    }
                    else if (array[i] - array[i + 1] == -1)
                    {
                        conscount++;
                    }
                }

            }
            if(conscount == array.Length-1)
            {
                Console.WriteLine("Consecutive array");
                return true;
            }else if(inconscount == array.Length-1)
            {
                Console.WriteLine("Inconsecutive array");
                return true;
            }
            return false;
        }
    }   
}
