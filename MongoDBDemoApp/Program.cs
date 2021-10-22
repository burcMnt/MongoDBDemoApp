using System;

namespace MongoDBDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            Console.ReadLine();
        }
    }
}
