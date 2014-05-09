using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;      //necessary in order to define an EntityKey type.
using System.Data.EntityClient;     //necessary for the use of the EntityConnection type.

/*A simple program that uses the Entity Framework to insert and print from a database table.*/

namespace InventoryEDMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Fun with the ADO.NET Entity Framework ********");
            AddNewRecord();
            //RemoveRecord(2222);
            UpdateRecord(2222);
            PrintAllInventory();

            SimpleEntitySQL();
            Console.WriteLine();
            EntityDataReaderExample();
            
            Console.ReadLine();
        }

        //Add some data to the table
        private static void AddNewRecord()
        {
            //Add a record to the Inventory table of the AutoLot database.
            using (AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    //hard coded data for a new record, for testing.
                    context.Cars.AddObject(new Car() { CarID = 2222, Make = "Yugo", Color = "Brown", CarNickName="TestCar" });
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }

        /*Select all items from the Inventory table of AutoLot, and print out the data
         using our custom ToString() of the Car entity class.*/
        private static void PrintAllInventory()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                foreach (Car c in context.Cars)
                {
                    Console.WriteLine(c);
                }
            }
        }

        //Delete a record
        private static void RemoveRecord(int value)
        {
            //Find a car to delete by primary key
            using (AutoLotEntities context = new AutoLotEntities())
            {
                //Define a key for the entity we are looking for.
                EntityKey key = new EntityKey("AutoLotEntities.Cars", "CarID", value);

                //see if we have it, then delete it if we do.
                Car carToDelete = (Car)context.GetObjectByKey(key);
                if (carToDelete != null)
                {
                    context.DeleteObject(carToDelete);
                    context.SaveChanges();
                }
            }
        }

        //Update a record
        private static void UpdateRecord(int value)
        {
            //Find a car to update by primary key
            using (AutoLotEntities context = new AutoLotEntities())
            {
                //Define a key for the entity we are looking for.
                EntityKey key = new EntityKey("AutoLotEntities.Cars", "CarID", value);

                //see if we have it, then delete it if we do.
                Car carToUpdate = (Car)context.GetObjectByKey(key);
                if (carToUpdate != null)
                {
                    carToUpdate.Color = "Blue";
                    context.SaveChanges();
                }
            }
        }

        //Simple example demonstrating the use of Entity SQL.
        private static void SimpleEntitySQL()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                //Build a string containing Entity SQL syntax.
                string query = "SELECT VALUE car FROM AutoLotEntities.Cars AS car WHERE car.Color='black'";

                //Build a ObjectQuery<T> based on the string
                var blackCars = context.CreateQuery<Car>(query);

                foreach (var item in blackCars)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //Intercept the result set using EntityDataReader and process the results manually.
        private static void EntityDataReaderExample()
        {
            //Make a connection object based on the *.config file.
            using (EntityConnection cn = new EntityConnection("name=AutoLotEntities"))
            {
                cn.Open();

                //now build an Entity SQL query
                string query = "SELECT VALUE car FROM AutoLotEntities.Cars AS car";

                //create a command object
                using (EntityCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = query;

                    //Finally, get the data reader and process the records.
                    using (EntityDataReader dr = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("***** RECORD *****");
                            Console.WriteLine("ID: {0}", dr["CarID"]);
                            Console.WriteLine("Make: {0}", dr["Make"]);
                            Console.WriteLine("Color: {0}", dr["Color"]);
                            Console.WriteLine("Pet Name: {0}", dr["CarNickName"]);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

    }
}
