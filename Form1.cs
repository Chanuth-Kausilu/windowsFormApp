using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace metro_other_forms_with_sql
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Reg_cli_Click(object sender, EventArgs e)
        {
            Hide();
            Client_Registration obj = new Client_Registration();
            obj.Show();
        }

        private void Upd_cli_Click(object sender, EventArgs e)
        {
            Hide();
            Update_clients obj = new Update_clients();
            obj.Show();

        }

        private void Del_cli_Click(object sender, EventArgs e)
        {
            Hide();
            Delete_Clients obj = new Delete_Clients();
            obj.Show();
        }

        private void Search_cli_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            string id = "c5";
            string name = "dddd";
            string address = "col,sl";
            string dob = "mar";
            int age = 20;
            int tp = 01233456789;
            con = new SqlConnection("Data Source=DESKTOP-PC19JL6;Initial Catalog=bank;Integrated Security=True"); con.Open();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
