﻿namespace _2.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class PhonebookUpgrade
    {
        public static void AddEntry(Dictionary<string, string> phonebook, string[] input)
        {
            var key = input[1];
            var value = input[2];

            if (!phonebook.ContainsKey(key))
            {
                phonebook.Add(key, value);
            }
            else
            {
                phonebook[key] = value;
            }
        }

        public static void SearchPhonebook(Dictionary<string, string> phonebook, string[] input)
        {
            var key = input[1];
            bool isExist = false;

            foreach (var name in phonebook.Keys)
            {
                if (name == key)
                {
                    isExist = true;
                }
            }
            if (isExist)
            {
                Console.WriteLine("{0} -> {1}", key, phonebook[key]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", key);
            }
        }

        public static void ListAll(Dictionary<string, string> phonebook, string[] input)
        {
            var sortedPhonebook = new SortedDictionary<string, string>(phonebook);

            foreach (var name in sortedPhonebook.Keys)
            {
                Console.WriteLine("{0} -> {1}", name, phonebook[name]);
            }
        }

        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            while (1 > 0)
            {
                var input = Console.ReadLine().Split(' ');

                if (input[0] == "A")
                {
                    AddEntry(phonebook, input);
                }
                if (input[0] == "S")
                {
                    SearchPhonebook(phonebook, input);
                }
                if (input[0] == "ListAll")
                {
                    ListAll(phonebook, input);
                }
                if (input[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
