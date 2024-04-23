namespace Ordersystem
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblYourName = new Label();
            LblYourEmail = new Label();
            TxtBxYourName = new TextBox();
            txtBxSenderEmail = new TextBox();
            LblRecipient = new Label();
            lblRecEmail = new Label();
            LblRecPhone = new Label();
            LblAddress = new Label();
            TxtBxRecpt = new TextBox();
            TxtBxEmail = new TextBox();
            TxtBxPhone = new TextBox();
            richTextBox1Address = new RichTextBox();
            BtnSubmit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblYourName
            // 
            LblYourName.AutoSize = true;
            LblYourName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblYourName.Location = new Point(234, 139);
            LblYourName.Name = "LblYourName";
            LblYourName.Size = new Size(211, 50);
            LblYourName.TabIndex = 0;
            LblYourName.Text = "Your Name:";
            // 
            // LblYourEmail
            // 
            LblYourEmail.AutoSize = true;
            LblYourEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblYourEmail.Location = new Point(244, 208);
            LblYourEmail.Name = "LblYourEmail";
            LblYourEmail.Size = new Size(201, 50);
            LblYourEmail.TabIndex = 1;
            LblYourEmail.Text = "Your Email:";
            // 
            // TxtBxYourName
            // 
            TxtBxYourName.Location = new Point(437, 150);
            TxtBxYourName.Name = "TxtBxYourName";
            TxtBxYourName.Size = new Size(200, 39);
            TxtBxYourName.TabIndex = 4;
            TxtBxYourName.Text = "Enter Name";
            // 
            // txtBxSenderEmail
            // 
            txtBxSenderEmail.Location = new Point(437, 217);
            txtBxSenderEmail.Name = "txtBxSenderEmail";
            txtBxSenderEmail.Size = new Size(200, 39);
            txtBxSenderEmail.TabIndex = 5;
            txtBxSenderEmail.Text = "Enter Your Email";
            // 
            // LblRecipient
            // 
            LblRecipient.AutoSize = true;
            LblRecipient.Location = new Point(220, 356);
            LblRecipient.Name = "LblRecipient";
            LblRecipient.Size = new Size(117, 32);
            LblRecipient.TabIndex = 6;
            LblRecipient.Text = "Recipient:";
            // 
            // lblRecEmail
            // 
            lblRecEmail.AutoSize = true;
            lblRecEmail.Location = new Point(180, 423);
            lblRecEmail.Name = "lblRecEmail";
            lblRecEmail.Size = new Size(159, 32);
            lblRecEmail.TabIndex = 7;
            lblRecEmail.Text = "Reciver Email:";
            // 
            // LblRecPhone
            // 
            LblRecPhone.AutoSize = true;
            LblRecPhone.Location = new Point(167, 477);
            LblRecPhone.Name = "LblRecPhone";
            LblRecPhone.Size = new Size(170, 32);
            LblRecPhone.TabIndex = 8;
            LblRecPhone.Text = "Reciver Phone:";
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(220, 532);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(103, 32);
            LblAddress.TabIndex = 9;
            LblAddress.Text = "Address:";
            // 
            // TxtBxRecpt
            // 
            TxtBxRecpt.Location = new Point(358, 353);
            TxtBxRecpt.Name = "TxtBxRecpt";
            TxtBxRecpt.Size = new Size(305, 39);
            TxtBxRecpt.TabIndex = 10;
            TxtBxRecpt.Text = "Required";
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(358, 420);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(305, 39);
            TxtBxEmail.TabIndex = 11;
            TxtBxEmail.Text = "Required for Internainal";
            // 
            // TxtBxPhone
            // 
            TxtBxPhone.Location = new Point(370, 474);
            TxtBxPhone.Name = "TxtBxPhone";
            TxtBxPhone.Size = new Size(293, 39);
            TxtBxPhone.TabIndex = 12;
            TxtBxPhone.Text = "Required For Internainal";
            // 
            // richTextBox1Address
            // 
            richTextBox1Address.Location = new Point(363, 531);
            richTextBox1Address.Name = "richTextBox1Address";
            richTextBox1Address.Size = new Size(300, 278);
            richTextBox1Address.TabIndex = 13;
            richTextBox1Address.Text = "Required Full Address";
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(363, 864);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(246, 46);
            BtnSubmit.TabIndex = 14;
            BtnSubmit.Text = "Sumbit Order";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 958);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1116, 371);
            dataGridView1.TabIndex = 15;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1116, 1329);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSubmit);
            Controls.Add(richTextBox1Address);
            Controls.Add(TxtBxPhone);
            Controls.Add(TxtBxEmail);
            Controls.Add(TxtBxRecpt);
            Controls.Add(LblAddress);
            Controls.Add(LblRecPhone);
            Controls.Add(lblRecEmail);
            Controls.Add(LblRecipient);
            Controls.Add(txtBxSenderEmail);
            Controls.Add(TxtBxYourName);
            Controls.Add(LblYourEmail);
            Controls.Add(LblYourName);
            Name = "FrmMain";
            Text = "Order Page";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblYourName;
        private Label LblYourEmail;
        private TextBox TxtBxYourName;
        private TextBox txtBxSenderEmail;
        private Label LblRecipient;
        private Label lblRecEmail;
        private Label LblRecPhone;
        private Label LblAddress;
        private TextBox TxtBxRecpt;
        private TextBox TxtBxEmail;
        private TextBox TxtBxPhone;
        private RichTextBox richTextBox1Address;
        private Button BtnSubmit;
        private DataGridView dataGridView1;
    }
}
