namespace Project
{
    partial class Signin_Manager_Rec
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
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(184, 197);
            this.text_password.Margin = new System.Windows.Forms.Padding(2);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '●';
            this.text_password.Size = new System.Drawing.Size(157, 20);
            this.text_password.TabIndex = 25;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(184, 149);
            this.text_username.Margin = new System.Windows.Forms.Padding(2);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(157, 20);
            this.text_username.TabIndex = 24;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(205, 262);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(136, 27);
            this.edit_btn.TabIndex = 20;
            this.edit_btn.Text = "Sign in";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(169, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 33);
            this.label4.TabIndex = 72;
            this.label4.Text = "Staff Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(174, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 56);
            this.label7.TabIndex = 71;
            this.label7.Text = "Otelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Password";
            // 
            // Signin_Manager_Rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(509, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.edit_btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Signin_Manager_Rec";
            this.Text = "Signin_Manager_REC";
            this.Load += new System.EventHandler(this.Signin_Manager_Rec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}