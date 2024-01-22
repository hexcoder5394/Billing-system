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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Form2.setvaluetext1;
            lbl_tpf.Text = Form2.setvaluetext2;
            lbl_cf.Text = Form2.setvaluetext3;
            lbl_cfee.Text = Form2.setvaluetext4;
            lbl_wc.Text = Form2.setvaluetext5;
            lbl_tf.Text = Form2.setvaluetext6;
        }

        private void lbl_cf_Click(object sender, EventArgs e)
        {

        }
    }
}
