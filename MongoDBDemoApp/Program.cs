using MongoDBDemoApp.Models;
using System;

namespace MongoDBDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            db.InsertRecord("Users", new PersonModel() { FirstName = "Ece", LastName = "Yayal" });
            Console.ReadLine();
        }
    }
}
