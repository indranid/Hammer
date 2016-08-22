using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hammer
{
    public class AllHammer
    {
        string connString =
          "Data Source=(local);Initial Catalog=Northwind;"
          + "Integrated Security=true";

        public DataTable gethammers()
        {
           

            string queryString =
        "SELECT HammerName,Hammertype from Hammer";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                DataSet ds = new DataSet();
                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(ds, "Hammer");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return ds.Tables[0];

            }

        }

        public void deletehammer(string id)
        {
            string queryString =
      "delete from hammer where hammerid='"+ id +"'";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

               
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              

            }

        }

        public void updatehammer(string hammername, string hammertype , string id)
        {
            string queryString =
      "update hammer set hammername ='"+ hammername + "' , hammertype = '"+ hammertype + "' where hammerid='" + id + "'";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }




    }
}