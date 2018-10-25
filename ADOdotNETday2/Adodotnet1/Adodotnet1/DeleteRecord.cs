using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class DeleteRecord
    {
        static void Main(string[] args)
        {
            new DeleteRecord().CreateTable();
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
                int i = Convert.ToInt32(Console.ReadLine());
               // string s2 = "delete from " + s1 + " where id =  '" + i + "'";
               // Console.WriteLine(s2);
                SqlCommand cm = new SqlCommand("delete from "+s1+" where id =  '"+i+"'", con);
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
