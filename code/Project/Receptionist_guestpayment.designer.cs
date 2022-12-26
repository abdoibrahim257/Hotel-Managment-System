
namespace Project
{
    partial class Receptionist_guestpayment
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
            this.BillRoomNoCombo = new System.Windows.Forms.ComboBox();
            this.CheckBillGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckBillBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBillGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room ID";
            // 
            // BillRoomNoCombo
            // 
            this.BillRoomNoCombo.FormattingEnabled = true;
            this.BillRoomNoCombo.Location = new System.Drawing.Point(194, 138);
            this.BillRoomNoCombo.Name = "BillRoomNoCombo";
            this.BillRoomNoCombo.Size = new System.Drawing.Size(128, 24);
            this.BillRoomNoCombo.TabIndex = 1;
            // 
            // CheckBillGrid
            // 
            this.CheckBillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckBillGrid.Location = new System.Drawing.Point(352, 59);
            this.CheckBillGrid.Name = "CheckBillGrid";
            this.CheckBillGrid.RowHeadersWidth = 51;
            this.CheckBillGrid.RowTemplate.Height = 24;
            this.CheckBillGrid.Size = new System.Drawing.Size(436, 309);
            this.CheckBillGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CheckBillBTN
            // 
            this.CheckBillBTN.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBillBTN.Location = new System.Drawing.Point(89, 217);
            this.CheckBillBTN.Name = "CheckBillBTN";
            this.CheckBillBTN.Size = new System.Drawing.Size(169, 101);
            this.CheckBillBTN.TabIndex = 4;
            this.CheckBillBTN.Text = "check bill";
            this.CheckBillBTN.UseVisualStyleBackColor = true;
            this.CheckBillBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // guestpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBillBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBillGrid);
            this.Controls.Add(this.BillRoomNoCombo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "guestpayment";
            this.Text = "guestpayment";
            this.Load += new System.EventHandler(this.guestpayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBillGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BillRoomNoCombo;
        private System.Windows.Forms.DataGridView CheckBillGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckBillBTN;
    }
}