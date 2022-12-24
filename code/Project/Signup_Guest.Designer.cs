namespace Project
{
    partial class Signup_Guest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.text_mobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radiobtn_female = new System.Windows.Forms.RadioButton();
            this.radiobtn_male = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_lname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_minit = new System.Windows.Forms.TextBox();
            this.bla = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btn_signup);
            this.groupBox1.Controls.Add(this.text_mobile);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.radiobtn_female);
            this.groupBox1.Controls.Add(this.radiobtn_male);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text_fname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_lname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_minit);
            this.groupBox1.Controls.Add(this.bla);
            this.groupBox1.Controls.Add(this.text_username);
            this.groupBox1.Controls.Add(this.text_password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 250);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Account";
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_signup.Location = new System.Drawing.Point(641, 209);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(121, 29);
            this.btn_signup.TabIndex = 84;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click_1);
            // 
            // text_mobile
            // 
            this.text_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_mobile.Location = new System.Drawing.Point(404, 161);
            this.text_mobile.Margin = new System.Windows.Forms.Padding(2);
            this.text_mobile.MaxLength = 12;
            this.text_mobile.Name = "text_mobile";
            this.text_mobile.Size = new System.Drawing.Size(111, 23);
            this.text_mobile.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(274, 161);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 21);
            this.label11.TabIndex = 82;
            this.label11.Text = "Dependent Phone";
            // 
            // radiobtn_female
            // 
            this.radiobtn_female.AutoSize = true;
            this.radiobtn_female.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.radiobtn_female.Location = new System.Drawing.Point(681, 161);
            this.radiobtn_female.Margin = new System.Windows.Forms.Padding(2);
            this.radiobtn_female.Name = "radiobtn_female";
            this.radiobtn_female.Size = new System.Drawing.Size(75, 25);
            this.radiobtn_female.TabIndex = 81;
            this.radiobtn_female.Text = "Female";
            this.radiobtn_female.UseVisualStyleBackColor = true;
            // 
            // radiobtn_male
            // 
            this.radiobtn_male.AutoSize = true;
            this.radiobtn_male.Checked = true;
            this.radiobtn_male.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.radiobtn_male.Location = new System.Drawing.Point(614, 161);
            this.radiobtn_male.Margin = new System.Windows.Forms.Padding(2);
            this.radiobtn_male.Name = "radiobtn_male";
            this.radiobtn_male.Size = new System.Drawing.Size(62, 25);
            this.radiobtn_male.TabIndex = 80;
            this.radiobtn_male.TabStop = true;
            this.radiobtn_male.Text = "Male";
            this.radiobtn_male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(556, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 79;
            this.label8.Text = "Gender";
            // 
            // text_fname
            // 
            this.text_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_fname.Location = new System.Drawing.Point(109, 101);
            this.text_fname.Margin = new System.Windows.Forms.Padding(2);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(127, 23);
            this.text_fname.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(31, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Guest ID";
            // 
            // text_lname
            // 
            this.text_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_lname.Location = new System.Drawing.Point(641, 102);
            this.text_lname.Margin = new System.Windows.Forms.Padding(2);
            this.text_lname.MaxLength = 15;
            this.text_lname.Name = "text_lname";
            this.text_lname.Size = new System.Drawing.Size(121, 23);
            this.text_lname.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(546, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Last Name";
            // 
            // text_minit
            // 
            this.text_minit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_minit.Location = new System.Drawing.Point(402, 101);
            this.text_minit.Margin = new System.Windows.Forms.Padding(2);
            this.text_minit.MaxLength = 1;
            this.text_minit.Name = "text_minit";
            this.text_minit.Size = new System.Drawing.Size(113, 23);
            this.text_minit.TabIndex = 74;
            // 
            // bla
            // 
            this.bla.AutoSize = true;
            this.bla.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.bla.Location = new System.Drawing.Point(279, 101);
            this.bla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bla.Name = "bla";
            this.bla.Size = new System.Drawing.Size(99, 21);
            this.bla.TabIndex = 73;
            this.bla.Text = "Middle Name";
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_username.Location = new System.Drawing.Point(240, 38);
            this.text_username.Margin = new System.Windows.Forms.Padding(2);
            this.text_username.MaxLength = 16;
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(138, 23);
            this.text_username.TabIndex = 72;
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text_password.Location = new System.Drawing.Point(474, 39);
            this.text_password.Margin = new System.Windows.Forms.Padding(2);
            this.text_password.MaxLength = 16;
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(129, 23);
            this.text_password.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 69;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(398, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(161, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Username";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(109, 159);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 23);
            this.numericUpDown1.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(21, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 86;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Signup_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(821, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Signup_Guest";
            this.Text = "Signup_Guest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox text_mobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radiobtn_female;
        private System.Windows.Forms.RadioButton radiobtn_male;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_lname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_minit;
        private System.Windows.Forms.Label bla;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}