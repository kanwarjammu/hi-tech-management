using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechClass.Business;
using HitechClass.DataAccess;
using HitechClass.Validation;
using System.Data.SqlClient;


namespace Hi_Tech_Order_Management_System.GUI
{
 

    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                HintUser.Text = " User Id cannot be empty";

            }
            else if (passTextBox.Text == "")
            {
                hint.Text = "Password cannot be empty";
            }
            else
            {

                SqlConnection connDB = UtilityDB.ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "Select * from Login where UserId=@UserId and Password=@password";

                cmd.Parameters.AddWithValue("@UserId", userTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passTextBox.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connDB.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, then show select form
                if (count == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select JobTitle from [User] where UserId='" + userTextBox.Text +"'", connDB);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                    connDB.Close();
                        if (dt.Rows.Count == 1)
                        {

                        
                            switch (dt.Rows[0]["JobTitle"].ToString())
                        {

                                case"MIS Manager":
                                    {
                                          this.Hide();
                                        ManagementForm mm = new ManagementForm();
                                        mm.Show();
                                        break;
                                    }
                                case"Sales Manager":
                                    {
                                        this.Hide();
                                        CustomerForm um = new CustomerForm();
                                        um.Show();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }

                    

                                       }
         
                    else
                    {
                        hint.Text = "Wrong Credentials";
                    
                    }
              
            }
        }
   
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "you want to exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
               
            }
            else
            {
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
                form.Show();
            this.Hide();
        }
    }
}
