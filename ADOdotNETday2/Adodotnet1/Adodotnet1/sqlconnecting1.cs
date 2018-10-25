using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adodotnet1
{
    class sqlconnecting1
    {
        static void Main(string[] args)
        {
            new sqlconnecting1().Connecting();
        }
        public void Connecting()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=JAY\\SQLEXPRESS; database=jay1; integrated security=SSPI");
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {   // Closing the connection explicitly because of not using the 'using' block
                con.Close();
            }
        }
    }
}
