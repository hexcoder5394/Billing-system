namespace nsj
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.btn_prd = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.combo_tp = new System.Windows.Forms.ComboBox();
            this.combo_wc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_noc = new System.Windows.Forms.TextBox();
            this.btn_chk_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Athlete Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(238, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Training Plan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Weight:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(105, 109);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(62, 20);
            this.txt_weight.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Weight Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hours of private Coaching:";
            // 
            // txt_hours
            // 
            this.txt_hours.Enabled = false;
            this.txt_hours.Location = new System.Drawing.Point(166, 251);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(98, 20);
            this.txt_hours.TabIndex = 9;
            // 
            // btn_prd
            // 
            this.btn_prd.CausesValidation = false;
            this.btn_prd.Location = new System.Drawing.Point(71, 381);
            this.btn_prd.Name = "btn_prd";
            this.btn_prd.Size = new System.Drawing.Size(96, 28);
            this.btn_prd.TabIndex = 12;
            this.btn_prd.Text = "Proceed";
            this.btn_prd.UseVisualStyleBackColor = true;
            this.btn_prd.Click += new System.EventHandler(this.btn_prd_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(180, 381);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 28);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // combo_tp
            // 
            this.combo_tp.FormattingEnabled = true;
            this.combo_tp.Location = new System.Drawing.Point(98, 173);
            this.combo_tp.Name = "combo_tp";
            this.combo_tp.Size = new System.Drawing.Size(166, 21);
            this.combo_tp.TabIndex = 14;
            // 
            // combo_wc
            // 
            this.combo_wc.FormattingEnabled = true;
            this.combo_wc.Location = new System.Drawing.Point(321, 108);
            this.combo_wc.Name = "combo_wc";
            this.combo_wc.Size = new System.Drawing.Size(166, 21);
            this.combo_wc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Competitions:";
            // 
            // txt_noc
            // 
            this.txt_noc.Enabled = false;
            this.txt_noc.Location = new System.Drawing.Point(166, 306);
            this.txt_noc.Name = "txt_noc";
            this.txt_noc.Size = new System.Drawing.Size(98, 20);
            this.txt_noc.TabIndex = 9;
            // 
            // btn_chk_2
            // 
            this.btn_chk_2.Location = new System.Drawing.Point(280, 171);
            this.btn_chk_2.Name = "btn_chk_2";
            this.btn_chk_2.Size = new System.Drawing.Size(75, 23);
            this.btn_chk_2.TabIndex = 17;
            this.btn_chk_2.Text = "Check";
            this.btn_chk_2.UseVisualStyleBackColor = true;
            this.btn_chk_2.Click += new System.EventHandler(this.btn_chk_2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 447);
            this.Controls.Add(this.btn_chk_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_wc);
            this.Controls.Add(this.combo_tp);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_prd);
            this.Controls.Add(this.txt_noc);
            this.Controls.Add(this.txt_hours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "uh";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.Button btn_prd;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox combo_tp;
        private System.Windows.Forms.ComboBox combo_wc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_noc;
        private System.Windows.Forms.Button btn_chk_2;
    }
}