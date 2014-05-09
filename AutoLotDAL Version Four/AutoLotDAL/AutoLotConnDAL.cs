using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


/*This class library is used to interact with the 'AutoLot' database using the Connected types
 of ADO.NET.*/
namespace AutoLotDisconnectedLayer
{

    /// <summary>
    /// This class demonstates the disconnected aspect of ADO.NET in using a data adapter
    /// that will not only push changes in a DatatTable back to the database for processing,
    /// but will handle the opening and closing of connection(s) without any input from the user.
    /// </summary>
    public class InventoryDALDisLayer
    {
       //Field data
        private string cnString = string.Empty;
        private SqlDataAdapter dAdapt = null;

        public InventoryDALDisLayer(string connectionString)
        {
            cnString = connectionString;

            //configure the SqlDataAdapter
            ConfigureAdapter(out dAdapt);
        }

        private void ConfigureAdapter(out SqlDataAdapter dAdapt)
        {
            //Create the adapter and set up the SelectCommand
            dAdapt = new SqlDataAdapter("Select * From Inventory", cnString);

            //Obtain the remaining command objects dynamically at runtime using the SqlCommandBuilder
            SqlCommandBuilder builder = new SqlCommandBuilder(dAdapt);
        }

        public DataTable GetAllInventory()
        {
            DataTable inv = new DataTable("Inventory");
            dAdapt.Fill(inv);
            return inv;
        }

        public void UpdateInventroy(DataTable modifiedTable)
        {
            dAdapt.Update(modifiedTable);
        }
    }
}
