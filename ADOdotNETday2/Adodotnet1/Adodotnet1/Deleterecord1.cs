using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class Deleterecord1
    {
        static void Main(string[] args)
        {
            new Deleterecord1().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=JAY\\SQLEXPRESS; database=jay2; integrated security=SSPI");
                // writing sql query
                Console.WriteLine("enter the name of you table");
                string s1 = Console.ReadLine();
                Console.WriteLine("enter the column name for deleting data");
                string i = Console.ReadLine();
                
                SqlCommand cm = new SqlCommand("delete from " + s1 + " where FIRST_NAME =  '" + i + "'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
