namespace С__Pack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class EmployeeManagement
    {
        private Dictionary<string, string> employeePasswords;

        public EmployeeManagement()
        {
            employeePasswords = new Dictionary<string, string>();
        }

        public void AddEmployee(string username, string password)
        {
            if (!employeePasswords.ContainsKey(username))
            {
                employeePasswords.Add(username, password);
            }
            else
            {
                Console.WriteLine($"Username '{username}' already exists. Please choose a different username.");
            }
        }

        public void RemoveEmployee(string username)
        {
            if (employeePasswords.ContainsKey(username))
            {
                employeePasswords.Remove(username);
            }
            else
            {
                Console.WriteLine($"Username '{username}' not found.");
            }
        }

        public void UpdateEmployee(string username, string newPassword)
        {
            if (employeePasswords.ContainsKey(username))
            {
                employeePasswords[username] = newPassword;
            }
            else
            {
                Console.WriteLine($"Username '{username}' not found.");
            }
        }

        public string GetEmployeePassword(string username)
        {
            if (employeePasswords.ContainsKey(username))
            {
                return employeePasswords[username];
            }
            else
            {
                return "Username not found.";
            }
        }
    }
    class DictionaryApp
    {
        private Dictionary<string, List<string>> englishToFrenchDictionary;

        public DictionaryApp()
        {
            englishToFrenchDictionary = new Dictionary<string, List<string>>();
        }

        public void AddWord(string englishWord, List<string> frenchTranslations)
        {
            if (!englishToFrenchDictionary.ContainsKey(englishWord))
            {
                englishToFrenchDictionary.Add(englishWord, frenchTranslations);
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' already exists in the dictionary.");
            }
        }

        public void RemoveWord(string englishWord)
        {
            if (englishToFrenchDictionary.ContainsKey(englishWord))
            {
                englishToFrenchDictionary.Remove(englishWord);
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' does not exist in the dictionary.");
            }
        }

        public void UpdateWord(string englishWord, string newEnglishWord)
        {
            if (englishToFrenchDictionary.ContainsKey(englishWord))
            {
                var frenchTranslations = englishToFrenchDictionary[englishWord];
                englishToFrenchDictionary.Remove(englishWord);
                englishToFrenchDictionary.Add(newEnglishWord, frenchTranslations);
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' does not exist in the dictionary.");
            }
        }

        public void UpdateTranslations(string englishWord, List<string> newFrenchTranslations)
        {
            if (englishToFrenchDictionary.ContainsKey(englishWord))
            {
                englishToFrenchDictionary[englishWord] = newFrenchTranslations;
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' does not exist in the dictionary.");
            }
        }

        public List<string> GetTranslations(string englishWord)
        {
            if (englishToFrenchDictionary.ContainsKey(englishWord))
            {
                return englishToFrenchDictionary[englishWord];
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' does not exist in the dictionary.");
                return null;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-3):");
            int exerciseNumber = int.Parse(Console.ReadLine());
            switch (exerciseNumber)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                    static void Exercise1()
                    {
                        EmployeeManagement employeeManagement = new EmployeeManagement();

                        employeeManagement.AddEmployee("john_doe", "12345");
                        employeeManagement.AddEmployee("mary_smith", "password123");
                        employeeManagement.AddEmployee("jane_doe", "qwerty");

                        employeeManagement.AddEmployee("john_doe", "abcde");

                        employeeManagement.UpdateEmployee("john_doe", "newpassword");

                        employeeManagement.RemoveEmployee("mary_smith");

                        Console.WriteLine("Password for 'jane_doe': " + employeeManagement.GetEmployeePassword("jane_doe"));
                        Console.WriteLine("Password for 'mary_smith': " + employeeManagement.GetEmployeePassword("mary_smith"));
                    }
                    static void Exercise2()
                    {
                        DictionaryApp dictionaryApp = new DictionaryApp();

                        dictionaryApp.AddWord("apple", new List<string> { "pomme" });
                        dictionaryApp.AddWord("book", new List<string> { "livre" });
                        dictionaryApp.AddWord("computer", new List<string> { "ordinateur" });

                        dictionaryApp.UpdateWord("book", "notebook");

                        dictionaryApp.UpdateTranslations("apple", new List<string> { "pomme", "tarte" });

                        List<string> translations = dictionaryApp.GetTranslations("computer");
                        if (translations != null)
                        {
                            Console.WriteLine("Translations of 'computer': " + string.Join(", ", translations));
                        }

                        dictionaryApp.RemoveWord("book");

                        dictionaryApp.GetTranslations("book");
                    }
                    static void Exercise3()
                    {

                    }
            }
        }
    }
}