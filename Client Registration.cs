using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace metro_other_forms_with_sql
{
    public partial class Client_Registration : MetroFramework.Forms.MetroForm
    {
        public Client_Registration()
        {
            InitializeComponent();

        }
        SqlConnection con;
        SqlCommand cmd;


        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dob_picker.Value.Year).ToString();
        }
        
        private void Client_Registration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-PC19JL6;Initial Catalog=bank;Integrated Security=True");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            string id, name, address;
            DateTime dob;
            int age, tp;
            id = txt_id.Text;
            name = txt_name.Text;
            address = txt_address.Text;
            dob = dob_picker.Value;
            age = Convert.ToInt32(txt_age.Text);
            tp = Convert.ToInt32(txt_tp.Text);
            
            

            try
            {
                
                con.Open();
                cmd = new SqlCommand("Insert into clientinfo values (@a, @b, @c, @d, @e, @f)", con);
                cmd.Parameters.AddWithValue("a", id);
                cmd.Parameters.AddWithValue("b", name);
                cmd.Parameters.AddWithValue("c", address);  
                cmd.Parameters.AddWithValue("d", dob);
                cmd.Parameters.AddWithValue("e", age);
                cmd.Parameters.AddWithValue("f", tp);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 obj = new Form1();
            obj.Show();

        }

        private void Client_Registration_Load_1(object sender, EventArgs e)
        {

        }
    }
}
