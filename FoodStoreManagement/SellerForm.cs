using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodStoreManagement
{
    public partial class SellerForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Seller.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_Phone.Clear();
            TextBox_Password.Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_Phone.Text == "" || TextBox_Password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Seller Values(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_Phone.Text + "','" + TextBox_Password.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_Phone.Text == "" || TextBox_Password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Edit this record?", "Edit Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string updateQuery = "UPDATE Seller SET Name='" + TextBox_name.Text + "',Phone='" + TextBox_Phone.Text + "',Password='" + TextBox_Password.Text + "' WHERE ID = " + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dataGridView_Seller_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_Seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_Seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Phone.Text = dataGridView_Seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Password.Text = dataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE ID = " + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account Deleted Successfully", "Deleted Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red; 
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Orange;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryFormcs category = new CategoryFormcs();
            category.Show();
            this.Hide();
        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
