using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class empcreate
    {
        static void Main(string[] args)
        {
            new empcreate().CreateTable();
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
                Console.WriteLine("enter the name of your table");
                string s1 = Console.ReadLine();
                SqlCommand cm = new SqlCommand("create table " + s1 + "(ID int not null, FIRST_NAME varchar(100), LAST_NAME varchar(100), EMAIL varchar(50), AGE int)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
