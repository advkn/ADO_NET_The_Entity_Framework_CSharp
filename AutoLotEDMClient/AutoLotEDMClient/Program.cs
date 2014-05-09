using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using AutoLotDAL;
using System.Data.Objects;

namespace AutoLotEDMClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter customer id: ");
            string customerID = Console.ReadLine();
            PrintCustomerOrders(customerID);

            Console.WriteLine();
            CallStoredProc();
            
            Console.ReadLine();
            
        }

        //Utilizes the navigation properties to select each Inventory object on order for a given customer.
        private static void PrintCustomerOrders(string custID)
        {
            int id = int.Parse(custID);

            using (AutoLotEntities context = new AutoLotEntities())
            {
                var carsOnOrder = from o in context.Orders where o.CustID == id select o.Inventory;

                Console.WriteLine("\nCustomer has {0} orders pending:", carsOnOrder.Count());
                foreach (var item in carsOnOrder)
                {
                    Console.WriteLine("-> {0} {1} named {2}.", item.Color, item.Make, item.PetName);
                }
                
            }
        }

        //Invoking a stored procedure.
        private static void CallStoredProc()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                ObjectParameter input = new ObjectParameter("carID", 83);
                ObjectParameter output = new ObjectParameter("petName", typeof(string));

                //Call ExecuteFuncion off the context...
                context.ExecuteFunction("GetPetName", input, output);

                //Or use the strongly typed method on the context.
                context.GetPetName(83, output);

                Console.WriteLine("Car #83 is named {0}", output.Value);
            }
        }
    }
}
