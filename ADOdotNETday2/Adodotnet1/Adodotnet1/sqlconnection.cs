using System;
using System.Data.SqlClient;
namespace Adodotnet1
{
    class sqlconnection
    {
        static void Main(string[] args)
        {
            new sqlconnection().Connecting();
            Console.Read();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("data source=JAY\\SQLEXPRESS; database=jay1; integrated security=SSPI")
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}