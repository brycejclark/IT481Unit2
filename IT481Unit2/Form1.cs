using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481Unit2
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
           
                InitializeComponent();
                button1.Click += new EventHandler(button1_Click);
                button2.Click += new EventHandler(button2_Click);
                button3.Click += new EventHandler(button3_Click);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = HOU3-5CG0136D6B\\SQLEXPRESS; " +
                                "Trusted_Connection=true;" +
                                "Database=northwind;" +
                                "User INstance=false;" +
                                "Connection timeout=30;");

            MessageBox.Show("Connection information sent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyName();
            MessageBox.Show(names, "Company Names");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
