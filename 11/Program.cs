using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _11
{
    /// <summary>
    /// class phone book for dictionary
    /// </summary>
    [BsonIgnoreExtraElements]
    public class PhoneBook
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }

    class Program
    {
        /// <summary>
        /// add new user in base
        /// </summary>
        /// <param name="collection"></param>
        private static void CreateNewUser(IMongoCollection<PhoneBook> collection)
        {
            Console.Write("Введите номер: ");
            string number = Console.ReadLine();
            if (FindNameByNumber(collection, number))
            {
                Console.WriteLine("  Данный номер уже есть в базе");
                return;
            }
            else
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                var newUser = new PhoneBook { Name = name, Number = number };
                collection.InsertOne(newUser);
            }
        }

        /// <summary>
        /// find number by name
        /// </summary>
        /// <param name="collection"></param>
        private static bool FindNumberByName(IMongoCollection<PhoneBook> collection, string name)
        {
            foreach (var users in collection.Find(new BsonDocument()).ToList())
            {
                if(users.Name == name)
                {
                    Console.Write("номер: "+users.Number);
                    return true;
                }
            }
            Console.Write("имя не найдено");
            return false;
        }
        
        /// <summary>
        /// find name by number
        /// </summary>
        /// <param name="collection"></param>
        private static bool FindNameByNumber(IMongoCollection<PhoneBook> collection, string number)
        {
            foreach (var users in collection.Find(new BsonDocument()).ToList())
            {
                if (users.Number == number)
                {
                    Console.Write("имя: " + users.Name);
                    return true;
                }
            }
            Console.Write("номер не найден");
            return false;
        }

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Dictionary");
            var collection = database.GetCollection<PhoneBook>("PhoneBook");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("A  список всех пользователей");
                Console.WriteLine("S  добавить пользователя");
                Console.WriteLine("D  найти телефон по имени");
                Console.WriteLine("F  найти имя по телефону ");
                Console.WriteLine("G  выход\n");
                Console.Write("Комманда: ");
                var c = Console.ReadKey();
                Console.WriteLine();
                switch (c.Key)
                {
                    case ConsoleKey.A:
                        foreach (var users in collection.Find(new BsonDocument()).ToList())
                        {
                            Console.WriteLine("{0} {1}", users.Name, users.Number);
                        }
                        break;
                    case ConsoleKey.S:
                        CreateNewUser(collection);
                        break;
                    case ConsoleKey.D:
                        Console.Write("Введите имя для поиска телефона: ");
                        string name = Console.ReadLine();
                        FindNumberByName(collection, name);
                        break;
                    case ConsoleKey.F:
                        Console.Write("Введите телефон для поиска имени: ");
                        string number = Console.ReadLine();
                        FindNameByNumber(collection, number);
                        break;
                    case ConsoleKey.G:
                        return;
                }
            }          
        }
    }
}
