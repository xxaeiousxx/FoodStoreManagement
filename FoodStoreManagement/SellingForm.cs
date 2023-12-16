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
using DGVPrinterHelper;

namespace FoodStoreManagement
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "Name";
            
        }
        private void getTable()
        {
            string selectQuerry = "SELECT Name,Price FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;    
        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
              label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName; 
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Price.Text= DataGridView_product.SelectedRows[0].Cells[1].Value.ToString(); 
        }

        int grandTotal = 0, n = 0;

        private void DataGridView_sellList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill Values(" + TextBox_id.Text + ",'" + label_seller.Text + "','" + label_date.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "Shop N' Go Sell Lists";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Group 3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellList);
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Orange;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT Name,Price FROM Product WHERE Category = '" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void label_amount_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_Quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(TextBox_Price.Text) * Convert.ToInt32(TextBox_Quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(DataGridView_Order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_name.Text;
                addRow.Cells[2].Value = TextBox_Price.Text;
                addRow.Cells[3].Value = TextBox_Quantity.Text;
                addRow.Cells[4].Value = Total;
                DataGridView_Order.Rows.Add(addRow);
                grandTotal += Total;
                label_amount.Text = "P." + grandTotal;
            }
        }
    }
}
