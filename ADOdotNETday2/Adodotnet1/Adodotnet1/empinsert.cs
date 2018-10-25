using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class empinsert
    {
        static void Main(string[] args)
        {
            new empinsert().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            DateTime dt = new DateTime();
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
                    Console.WriteLine("enter the id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the first name");
                    string f1 = Console.ReadLine();
                    Console.WriteLine("enter the last name");
                    string l1 = Console.ReadLine();
                    Console.WriteLine("enter the Email.Id");
                    string e1 = Console.ReadLine();
                    Console.WriteLine("enter the date of joining");
                    dt = DateTime.Parse(Console.ReadLine());
                    SqlCommand cm = new SqlCommand("insert into " + t1 + "(ID, FIRST_NAME, LAST_NAME, EMAIL, join_date)values('" + id + "', '" + f1 + "', '" + l1 + "','" + e1 + "', '" + dt + "')", con);
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
