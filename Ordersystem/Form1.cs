using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;





namespace Ordersystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //InitializeDatabase();
            LoadData();
            this.IsMdiContainer = true;
        }

        private void LoadData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steph\OneDrive\Documents\SQLOrder.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Orders";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;  // Assuming your DataGridView is named dataGridView1
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load data: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveData();
            }
        }

        private void SaveData()
        {


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steph\OneDrive\Documents\SQLOrder.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "INSERT INTO Orders (SenderName, SenderEmail, Recipient, RecipientEmail, RecipientPhone, Address) VALUES (@SenderName, @SenderEmail, @Recipient, @RecipientEmail, @RecipientPhone, @Address)";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SenderName", TxtBxYourName.Text);
                        command.Parameters.AddWithValue("@SenderEmail", txtBxSenderEmail.Text);
                        command.Parameters.AddWithValue("@Recipient", TxtBxRecpt.Text);
                        command.Parameters.AddWithValue("@RecipientEmail", TxtBxEmail.Text);
                        command.Parameters.AddWithValue("@RecipientPhone", TxtBxPhone.Text);
                        command.Parameters.AddWithValue("@Address", richTextBox1Address.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order submitted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to submit order: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxYourName.Text) || string.IsNullOrWhiteSpace(txtBxSenderEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtBxSenderEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void InitializeDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steph\OneDrive\Documents\SQLOrder.mdf;Integrated Security=True;Connect Timeout=30";

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming 'Form1' is the name of the form you want to display
            Form1 form1 = new Form1();
            //form1.Show();
            this.Hide(); // Hide the current form

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming 'Form2' is the name of the form you want to display
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Hide the current form
        }
        private void ShowForm2()
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
