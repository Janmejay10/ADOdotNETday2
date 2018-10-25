using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class AddressCreate
    {
        static void Main(string[] args)
        {
            new AddressCreate().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;

            try
            {
                Console.WriteLine("enter the no.of time you want to enter the data particularly");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=JAY\\SQLEXPRESS; database=jay2; integrated security=SSPI");
                    // writing sql query 
                    Console.WriteLine("enter the name of your table");
                    string t1 = Console.ReadLine();
                    Console.WriteLine("enter the house number");
                    string t2 = Console.ReadLine();
                    Console.WriteLine("enter the street name");
                    string t3 = Console.ReadLine();
                    Console.WriteLine("enter the city");
                    string t4 = Console.ReadLine();
                    Console.WriteLine("enter the state name");
                    string t5 = Console.ReadLine();
                    Console.WriteLine("enter the employee id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    SqlCommand cm = new SqlCommand("insert into " + t1 + "(house_no ,street_name,city ,state, Employee1_ID) values('" + t2 + "', '" + t3 + "', '" + t4 + "','" + t5 + "', '" + id + "')", con);
                    // Opening Connection  
                    con.Open();
                    // Executing the SQL query  
                    cm.ExecuteNonQuery();
                    
                }

                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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
