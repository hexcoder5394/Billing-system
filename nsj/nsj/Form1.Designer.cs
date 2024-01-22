namespace nsj
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_exsisting = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_chk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(226, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(226, 118);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(172, 20);
            this.txt_age.TabIndex = 4;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(226, 170);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(172, 20);
            this.txt_weight.TabIndex = 5;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(151, 244);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(92, 31);
            this.btn_reg.TabIndex = 6;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_exsisting
            // 
            this.btn_exsisting.Location = new System.Drawing.Point(249, 244);
            this.btn_exsisting.Name = "btn_exsisting";
            this.btn_exsisting.Size = new System.Drawing.Size(86, 31);
            this.btn_exsisting.TabIndex = 7;
            this.btn_exsisting.Text = "Member";
            this.btn_exsisting.UseVisualStyleBackColor = true;
            this.btn_exsisting.Click += new System.EventHandler(this.btn_exsisting_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(41, 306);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(448, 210);
            this.dgv.TabIndex = 8;
            // 
            // btn_chk
            // 
            this.btn_chk.Location = new System.Drawing.Point(414, 277);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(75, 23);
            this.btn_chk.TabIndex = 9;
            this.btn_chk.Text = "Check";
            this.btn_chk.UseVisualStyleBackColor = true;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 528);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_exsisting);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_exsisting;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_chk;
    }
}

