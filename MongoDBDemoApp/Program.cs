using MongoDBDemoApp.Models;
using System;

namespace MongoDBDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
           // db.InsertRecord("Users", new PersonModel() { FirstName = "Ece", LastName = "Yayal" });
            PersonModel person = new()
            {
                FirstName = "Cem",
                LastName = "Cünedi",
                PrimaryAddress = new AddressModel()
                {
                    StreetAddress = "101 Oak Street",
                    City = "Scranton",
                    State = "PA",
                    ZipCode = "18512"
                }
            };
            db.InsertRecord("Users", person);

            Console.ReadLine();
        }
    }
}
