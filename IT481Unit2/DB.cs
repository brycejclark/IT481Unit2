using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace IT481Unit2
{
    class DB
    {
        string connectionString;
        SqlConnection cnn;

        public DB()
        {
            connectionString = "Server = HOU3-5CG0136D6B\\SQLEXPRESS; " +
                                "Trusted_Cnnection=true;" +
                                "Database=Northwind;" +
                                "User INstance=false;" +
                                "Connection timeout=30";
        }

        public DB(string conn)
        {
            connectionString = conn;
        }

        public string getCustomerCount()
        {
            Int32 count = 8;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return count.ToString();
        }

        public string getCompanyName()
        {
            string names = "None";
            SqlDataReader datareader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select companyname from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            datareader = cmd.ExecuteReader();
            while(datareader.Read())
            {
                try
                {
                    names = names + datareader.GetValue(0) + "\n";
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                        
                }
            }
            return names;

        }
    }
}
