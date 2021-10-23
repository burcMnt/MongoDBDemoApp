using MongoDBDemoApp.Models;
using System;

namespace MongoDBDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //POST OPERATION

            // db.InsertRecord("Users", new PersonModel() { FirstName = "Ece", LastName = "Yayal" });
            //PersonModel person = new()
            //{
            //    FirstName = "Cem",
            //    LastName = "Cünedi",
            //    PrimaryAddress = new AddressModel()
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "Scranton",
            //        State = "PA",
            //        ZipCode = "18512"
            //    }
            //};
            //db.InsertRecord("Users", person);

        /**************************************************************/
        //GET OPERATION

            var recs = db.LoadRecords<PersonModel>("Users");
            foreach (var item in recs)
            {
                Console.Write($"PersonId = {item.Id}, Person FullName= {item.FirstName} {item.LastName} ");

                if (item.PrimaryAddress !=null)
                {
                    Console.Write($", Person's City = {item.PrimaryAddress.City}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
