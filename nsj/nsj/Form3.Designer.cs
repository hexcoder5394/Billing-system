namespace nsj
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_tpf = new System.Windows.Forms.Label();
            this.lbl_cf = new System.Windows.Forms.Label();
            this.lbl_wc = new System.Windows.Forms.Label();
            this.lbl_tf = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.lbl_cfee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(54, 49);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(38, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Name:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(54, 98);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(89, 13);
            this.l2.TabIndex = 1;
            this.l2.Text = "Training plan fee:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(54, 147);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(76, 13);
            this.l3.TabIndex = 2;
            this.l3.Text = "Coaching Fee:";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(54, 237);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(72, 13);
            this.l5.TabIndex = 3;
            this.l5.Text = "Weight Class:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(54, 293);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(58, 13);
            this.l6.TabIndex = 4;
            this.l6.Text = "Total Cost:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(209, 49);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 5;
            // 
            // lbl_tpf
            // 
            this.lbl_tpf.AutoSize = true;
            this.lbl_tpf.Location = new System.Drawing.Point(209, 98);
            this.lbl_tpf.Name = "lbl_tpf";
            this.lbl_tpf.Size = new System.Drawing.Size(0, 13);
            this.lbl_tpf.TabIndex = 6;
            // 
            // lbl_cf
            // 
            this.lbl_cf.AutoSize = true;
            this.lbl_cf.Location = new System.Drawing.Point(209, 147);
            this.lbl_cf.Name = "lbl_cf";
            this.lbl_cf.Size = new System.Drawing.Size(0, 13);
            this.lbl_cf.TabIndex = 7;
            this.lbl_cf.Click += new System.EventHandler(this.lbl_cf_Click);
            // 
            // lbl_wc
            // 
            this.lbl_wc.AutoSize = true;
            this.lbl_wc.Location = new System.Drawing.Point(209, 237);
            this.lbl_wc.Name = "lbl_wc";
            this.lbl_wc.Size = new System.Drawing.Size(0, 13);
            this.lbl_wc.TabIndex = 8;
            // 
            // lbl_tf
            // 
            this.lbl_tf.AutoSize = true;
            this.lbl_tf.Location = new System.Drawing.Point(209, 293);
            this.lbl_tf.Name = "lbl_tf";
            this.lbl_tf.Size = new System.Drawing.Size(0, 13);
            this.lbl_tf.TabIndex = 9;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(54, 194);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(86, 13);
            this.l4.TabIndex = 2;
            this.l4.Text = "Competition Fee:";
            // 
            // lbl_cfee
            // 
            this.lbl_cfee.AutoSize = true;
            this.lbl_cfee.Location = new System.Drawing.Point(209, 194);
            this.lbl_cfee.Name = "lbl_cfee";
            this.lbl_cfee.Size = new System.Drawing.Size(0, 13);
            this.lbl_cfee.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 336);
            this.Controls.Add(this.lbl_tf);
            this.Controls.Add(this.lbl_wc);
            this.Controls.Add(this.lbl_cfee);
            this.Controls.Add(this.lbl_cf);
            this.Controls.Add(this.lbl_tpf);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_tpf;
        private System.Windows.Forms.Label lbl_cf;
        private System.Windows.Forms.Label lbl_wc;
        private System.Windows.Forms.Label lbl_tf;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label lbl_cfee;
    }
}