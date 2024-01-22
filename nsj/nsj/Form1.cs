using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace nsj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exsisting_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private string constring = ("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Dell\\Documents\\HND\\Assignments\\Programming\\New folder\\nsj\nsj\\.mdf;Integrated Security=True");

        private void btn_reg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "insert into members values('" + txt_name + "', '" + Convert.ToInt32(txt_weight.Text) + "', '" + Convert.ToInt32(txt_age.Text) + "')";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added", "Message");
            con.Close();
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q2 = "select * from members";
            SqlCommand cmd = new SqlCommand(q2, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }

    }
}
