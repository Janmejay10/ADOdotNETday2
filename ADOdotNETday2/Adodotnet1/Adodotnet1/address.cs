using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class address
    {
        static void Main(string[] args)
        {
            new address().CreateTable();
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
                SqlCommand cm = new SqlCommand("create table " + s1 + "(house_no varchar(90),street_name varchar(90),city varchar(90),state varchar(90),Employee1_ID int)", con);
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
