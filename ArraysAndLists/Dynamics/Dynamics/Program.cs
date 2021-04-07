using System;
using System.Collections.Generic;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 1, 5, 6, 7, 8 };
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Array.IndexOf(numbers, 6));

            //// Assign 0
            //Array.Clear(numbers, 0, 3);
            //Console.WriteLine(numbers.Length);
            //PrintArray(numbers);


            //int[] arr = new int[10];

            //Array.Copy(numbers, arr, numbers.Length);
            //int fix;
            //PrintArray(arr);

            //arr[0] = 15;
            //Console.WriteLine("Array: " + arr[0] + "\n" + "Numbers : " + numbers[0]);
            //Array.Reverse(arr);
            //PrintArray(arr);

            //var numbers = new List<int>();
            //numbers.Add(15);
            //numbers.AddRange(new int[3] { 1, 3, 5 });

            //foreach(int n in numbers)
            //{
            //    Console.Write(n + ", ");
            //}







            var friend1 = new Friend();
            friend1.Name = "Hoody";
            var friend2 = new Friend();
            friend2.Name = "Bogay";
            var post = new Post();
            var person = new Friend();
            person.Name = "Ahmedi Necat";
            var friends = new List<Friend>();
            friends.Add(friend1);
            friends.Add(friend2);
            post.Context = "Today is the best day of my life!!!!";
            post.LikedPeople = friends;
            foreach (Friend fr in post.LikedPeople)
            {
                Console.WriteLine(fr.Name);
            }
        }


        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
    struct Friend
    {
        private string name;

        public string Name { get => name; set => name = value; }
    }

    struct Post
    {
        private string context;

        private Friend belongsToWho;

        private List<Friend> likedPeople;

        public Friend BelongsToWho { get => belongsToWho; set => belongsToWho = value; }
        public string Context { get => context; set => context = value; }
        internal List<Friend> LikedPeople { get => likedPeople; set => likedPeople = value; }
    }


}
