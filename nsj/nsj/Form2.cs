using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsj
{
    public partial class Form2 : Form
    {
        /* varriables and list for trsining plan prices and weight class */
        Double [] plan_costs = {25, 30, 35, 9.5,22 };
        Double [] weights = {66, 73, 81, 90, 100};
        Double total = 0;
        double cost = 0;
        double competition_fee = 0;
        double coaching_fee = 0;
        string weight_cat = "";


        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;
        public static string setvaluetext5;
        public static string setvaluetext6;

        private void Form2_Load(object sender, EventArgs e)
        {
            Label lable_com = new Label();
            lable_com.Location = new Point(96, 54);
            lable_com.Text = "Number of Competitions:";
            lable_com.AutoSize = true;
            lable_com.BackColor = Color.Black;
        }

        public Form2()
        {

            /* Drop down menu - training plan */
            InitializeComponent();
            combo_tp.Items.Add("Beginner");
            combo_tp.Items.Add("Intermediate");
            combo_tp.Items.Add("Elite");
            combo_tp.Items.Add("private coaching");
            combo_tp.Items.Add("Competition Entry Fee");
            combo_tp.DropDownStyle = ComboBoxStyle.DropDownList;

            /* Drop down menu - weights */
            combo_wc.Items.Add("Fly Weight >= 66");
            combo_wc.Items.Add("Light Weight >= 73");
            combo_wc.Items.Add("Light Middle Weight >= 81");
            combo_wc.Items.Add("Middle Weight >= 90");
            combo_wc.Items.Add("Light heavy Weight >= 100");
            combo_wc.Items.Add("Heavy Weight > 100");
            combo_wc.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_chk_2_Click(object sender, EventArgs e)
        {

            // check the training plan = intermediate or elite

            if (combo_tp.SelectedItem == "Intermediate" || combo_tp.SelectedItem == "Elite")
            {
                txt_noc.Enabled = true;          // enable the competition  text box   
                txt_hours.Enabled = false;       // disable the number of hours  text box 
            }
            else if (combo_tp.SelectedItem == "private coaching")
            {
                txt_hours.Enabled = true;   // enable the number of hours text box 
                txt_noc.Enabled = false;    // disable the number of competition text box 

            }
            

           
        }

        private void btn_prd_Click(object sender, EventArgs e)
        {
             
            // calculate total 

            double weight = Convert.ToDouble(txt_weight.Text);
            string weight_cat = "";
            string coaching_hours = txt_hours.Text;


            // check the training plan 

            if (combo_tp.SelectedItem == "Beginner")
            {
                txt_hours.Enabled = false;
                txt_noc.Enabled = false;

                cost = plan_costs[0] * 4;
                total = total + cost;
            }
            else if (combo_tp.SelectedItem == "Intermediate")
            {
                cost = plan_costs[1] * 4;
                if (Convert.ToInt32(txt_noc.Text) > 1)
                {
                    MessageBox.Show("Exceeded the competition limit !!!", "North Sussex Judo");
                }
                else
                {
                    competition_fee = plan_costs[4] * Convert.ToDouble(txt_noc.Text);
                    total = cost + competition_fee;
                }
            }
            else if (combo_tp.SelectedItem == "Elite")
            {
                cost = plan_costs[2] * 4;
                if (Convert.ToInt32(txt_noc.Text) > 1)
                {
                    MessageBox.Show("Exceeded the competition limit !!!", "North Sussex Judo");
                }
                else
                {
                    competition_fee = plan_costs[4] * Convert.ToDouble(txt_noc.Text);
                    total = cost + competition_fee;
                }
            }
            else if (combo_tp.SelectedItem == "private coaching")
            {


                if (Convert.ToInt32(txt_hours.Text) <= 20)
                {
                    coaching_fee = plan_costs[3] * Convert.ToInt32(txt_hours.Text);
                    total = total + coaching_fee;
                }
                else
                {
                    MessageBox.Show("Coaching hours limit is exceeded !!!", "North Sussex Judo");
                }

            }
            else if (combo_tp.SelectedItem == "Competition Entry Fee")
            {
                total = total + plan_costs[4] * 4;
                cost = plan_costs[4];

            }


            // compare weight classes 

            if (weight >= weights[0])
            {
                weight_cat = "You are in Fly weight class";
            }
            else if (weight >= weights[1])
            {
                weight_cat = "You are in Light weight class";
            }
            else if (weight >= weights[2])
            {
                weight_cat = "You are in Light Middle weight class";
            }
            else if (weight >= weights[3])
            {
                weight_cat = "You are in Middle weight class";
            }
            else if (weight == weights[4])
            {
                weight_cat = "You are in Light Heavy weight class";
            }
            else if (weight > weights[4])
            {
                weight_cat = "You are in Heavy weight class";
            }


            string dis_total = ("$ " + Convert.ToString(total));
            // pass values to another result form 

            setvaluetext1 = txt_name.Text;
            setvaluetext2 = ("$ " + Convert.ToString(cost));
            setvaluetext3 = ("$ " + Convert.ToString(coaching_fee));
            setvaluetext4 = ("$ " + Convert.ToString(competition_fee));
            setvaluetext5 = weight_cat;
            setvaluetext6 = dis_total;

            Form3 f3 = new Form3();
            f3.Show();




        }

        
    }
}
