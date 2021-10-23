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

            //var recs = db.LoadRecords<PersonModel>("Users");
            //foreach (var item in recs)
            //{
            //    Console.Write($"PersonId = {item.Id}, Person FullName= {item.FirstName} {item.LastName} ");

            //    if (item.PrimaryAddress !=null)
            //    {
            //        Console.Write($", Person's City = {item.PrimaryAddress.City}");
            //    }
            //    Console.WriteLine();
            //}

            /**************************************************************/
            //GETBYID OPERATION

            var rec = db.LoadRecordById<PersonModel>("Users", new Guid("64125166-7003-4b91-b92a-89840fb47800"));
            //Console.WriteLine(rec.FirstName+" "+rec.LastName);

            /********************************************************************/
            //UPDATE OPERATION
            //rec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord<PersonModel>("Users", rec.Id, rec);

            /********************************************************************/
            //DELETE OPERATION
           // db.DeleteRecord<PersonModel>("Users", rec.Id);

            Console.ReadLine();

        }
    }
}
