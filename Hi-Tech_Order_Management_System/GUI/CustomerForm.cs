using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechClass.DataAccess;
using HitechClass.Business;
using HitechClass.Validation;
using System.Data.SqlClient;



namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class CustomerForm : Form
    {
        SqlDataAdapter da;
        DataTable dtcustomer;



        Customer aCustomers = new Customer();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataSet dsHitechDB = new DataSet("HitechDB");
              SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
            dtcustomer = new DataTable("Customers");
         

      

            
            DataColumn dcName = new DataColumn("Name", typeof(String));
            DataColumn dcStreet = new DataColumn("Street", typeof(String));
            DataColumn dcPostalCode = new DataColumn("PostalCode", typeof(String));
            DataColumn dcCity = new DataColumn("City", typeof(String));
            DataColumn dcFaxNumber = new DataColumn("FaxNumber", typeof(Int32));
            dcFaxNumber.AllowDBNull = false;
            dcFaxNumber.AutoIncrementSeed = 0;
            dcFaxNumber.AutoIncrement = true;
            dcFaxNumber.AutoIncrementStep = 1;
            dcFaxNumber.ReadOnly = true;
            dcFaxNumber.Unique = true;
            DataColumn dcCreditLimit = new DataColumn("CreditLimit", typeof(Int32));
            DataColumn dcPhoneNumber = new DataColumn("PhoneNumber", typeof(String));

            dtcustomer.Columns.Add(dcName);
            dtcustomer.Columns.Add(dcStreet);
            dtcustomer.Columns.Add(dcPostalCode);

            dtcustomer.Columns.Add(dcCity);
            dtcustomer.Columns.Add(dcFaxNumber);

            dtcustomer.Columns.Add(dcCreditLimit);
            dtcustomer.Columns.Add(dcPhoneNumber);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dtcustomer.Columns["FaxNumber"];
            dtcustomer.PrimaryKey = PrimaryKeyColumns;
          
            dsHitechDB.Tables.Add(dtcustomer);

            dtcustomer.Rows.Add("gavan", "fort","hewres","Montreal",123,1111,"32323232332");


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=DESKTOP-TQ21UB8;database=HitechDB;user=sa;password=Lasalle";
            string queryString = "SELECT * from Customers";
            da = new SqlDataAdapter(queryString,conn);


            da.Fill(dsHitechDB, "Customers");

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            aCustomers.City = city.Text.Trim();
            aCustomers.CreditLimit = Convert.ToInt32(credit.Text.Trim());
            aCustomers.FaxNumber = Convert.ToInt32(fax.Text.Trim());
            aCustomers.Name = name.Text.Trim();
            aCustomers.PhoneNumber = phoneno.Text.Trim();
            aCustomers.PostalCode = postal.Text.Trim();
            aCustomers.Street = street.Text.Trim();
            dtcustomer.Rows.Add(aCustomers.Name, aCustomers.PhoneNumber, aCustomers.PostalCode,aCustomers.FaxNumber,aCustomers.City,aCustomers.Street,aCustomers.CreditLimit);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = aCustomers.ListCustomer();

        }
    }
}
