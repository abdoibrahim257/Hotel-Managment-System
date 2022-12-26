
namespace Project
{
    partial class Receptionist_BookRoom
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
            this.CheckRoomViewCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.CheckRoomAvailableBTN = new System.Windows.Forms.Button();
            this.CheckEndDate = new System.Windows.Forms.DateTimePicker();
            this.CheckStartDate = new System.Windows.Forms.DateTimePicker();
            this.CheckRoomNO = new System.Windows.Forms.ComboBox();
            this.CheckUSSN = new System.Windows.Forms.ComboBox();
            this.CheckRoomTypeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckOutUSSNCombo = new System.Windows.Forms.ComboBox();
            this.CheckOutRoomNOCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckRoomViewCombo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ReserveBTN);
            this.groupBox1.Controls.Add(this.CheckRoomAvailableBTN);
            this.groupBox1.Controls.Add(this.CheckEndDate);
            this.groupBox1.Controls.Add(this.CheckStartDate);
            this.groupBox1.Controls.Add(this.CheckRoomNO);
            this.groupBox1.Controls.Add(this.CheckUSSN);
            this.groupBox1.Controls.Add(this.CheckRoomTypeCombo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(591, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "check and book room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CheckRoomViewCombo
            // 
            this.CheckRoomViewCombo.FormattingEnabled = true;
            this.CheckRoomViewCombo.Location = new System.Drawing.Point(469, 64);
            this.CheckRoomViewCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomViewCombo.Name = "CheckRoomViewCombo";
            this.CheckRoomViewCombo.Size = new System.Drawing.Size(92, 21);
            this.CheckRoomViewCombo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "room view";
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ReserveBTN.Location = new System.Drawing.Point(332, 125);
            this.ReserveBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(125, 52);
            this.ReserveBTN.TabIndex = 12;
            this.ReserveBTN.Text = "reserve room";
            this.ReserveBTN.UseVisualStyleBackColor = true;
            this.ReserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // CheckRoomAvailableBTN
            // 
            this.CheckRoomAvailableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRoomAvailableBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CheckRoomAvailableBTN.Location = new System.Drawing.Point(116, 125);
            this.CheckRoomAvailableBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomAvailableBTN.Name = "CheckRoomAvailableBTN";
            this.CheckRoomAvailableBTN.Size = new System.Drawing.Size(128, 52);
            this.CheckRoomAvailableBTN.TabIndex = 11;
            this.CheckRoomAvailableBTN.Text = "check availability";
            this.CheckRoomAvailableBTN.UseVisualStyleBackColor = true;
            this.CheckRoomAvailableBTN.Click += new System.EventHandler(this.CheckRoomAvailableBTN_Click);
            // 
            // CheckEndDate
            // 
            this.CheckEndDate.Location = new System.Drawing.Point(360, 94);
            this.CheckEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckEndDate.Name = "CheckEndDate";
            this.CheckEndDate.Size = new System.Drawing.Size(188, 20);
            this.CheckEndDate.TabIndex = 10;
            // 
            // CheckStartDate
            // 
            this.CheckStartDate.Location = new System.Drawing.Point(86, 94);
            this.CheckStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckStartDate.Name = "CheckStartDate";
            this.CheckStartDate.Size = new System.Drawing.Size(185, 20);
            this.CheckStartDate.TabIndex = 9;
            // 
            // CheckRoomNO
            // 
            this.CheckRoomNO.FormattingEnabled = true;
            this.CheckRoomNO.Location = new System.Drawing.Point(248, 31);
            this.CheckRoomNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomNO.Name = "CheckRoomNO";
            this.CheckRoomNO.Size = new System.Drawing.Size(92, 21);
            this.CheckRoomNO.TabIndex = 8;
            // 
            // CheckUSSN
            // 
            this.CheckUSSN.FormattingEnabled = true;
            this.CheckUSSN.Location = new System.Drawing.Point(469, 33);
            this.CheckUSSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckUSSN.Name = "CheckUSSN";
            this.CheckUSSN.Size = new System.Drawing.Size(92, 21);
            this.CheckUSSN.TabIndex = 7;
            // 
            // CheckRoomTypeCombo
            // 
            this.CheckRoomTypeCombo.FormattingEnabled = true;
            this.CheckRoomTypeCombo.Location = new System.Drawing.Point(71, 33);
            this.CheckRoomTypeCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckRoomTypeCombo.Name = "CheckRoomTypeCombo";
            this.CheckRoomTypeCombo.Size = new System.Drawing.Size(92, 21);
            this.CheckRoomTypeCombo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "receptionist id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "end date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "room id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "start date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "room type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckOutUSSNCombo);
            this.groupBox2.Controls.Add(this.CheckOutRoomNOCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(9, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(387, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "check out";
            // 
            // CheckOutUSSNCombo
            // 
            this.CheckOutUSSNCombo.FormattingEnabled = true;
            this.CheckOutUSSNCombo.Location = new System.Drawing.Point(89, 60);
            this.CheckOutUSSNCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOutUSSNCombo.Name = "CheckOutUSSNCombo";
            this.CheckOutUSSNCombo.Size = new System.Drawing.Size(128, 21);
            this.CheckOutUSSNCombo.TabIndex = 4;
            // 
            // CheckOutRoomNOCombo
            // 
            this.CheckOutRoomNOCombo.FormattingEnabled = true;
            this.CheckOutRoomNOCombo.Location = new System.Drawing.Point(89, 27);
            this.CheckOutRoomNOCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOutRoomNOCombo.Name = "CheckOutRoomNOCombo";
            this.CheckOutRoomNOCombo.Size = new System.Drawing.Size(128, 21);
            this.CheckOutRoomNOCombo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "receptionist ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "room ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(254, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(428, 243);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "bookroom";
            this.Text = "bookroom";
            this.Load += new System.EventHandler(this.bookroom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CheckEndDate;
        private System.Windows.Forms.DateTimePicker CheckStartDate;
        private System.Windows.Forms.ComboBox CheckUSSN;
        private System.Windows.Forms.ComboBox CheckRoomTypeCombo;
        private System.Windows.Forms.ComboBox CheckOutUSSNCombo;
        private System.Windows.Forms.ComboBox CheckOutRoomNOCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ReserveBTN;
        private System.Windows.Forms.Button CheckRoomAvailableBTN;
        private System.Windows.Forms.ComboBox CheckRoomViewCombo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox CheckRoomNO;
    }
}