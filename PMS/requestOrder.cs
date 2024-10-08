﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PMS
{
    public partial class requestOrder : Form
    {
        public requestOrder()
        {
            InitializeComponent();
            ConfigureDataGridView();
            //Set the Initial text
            //Set the color silver as the texts are invisible
            textBox1.Text = "Napa Extra";
            textBox1.ForeColor = Color.Silver;
            textBox2.Text = "5 MG";
            textBox2.ForeColor = Color.Silver;
            textBox3.Text = "1";
            textBox3.ForeColor = Color.Silver;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void requestOrder_Load(object sender, EventArgs e)
        {
            productsGridView.Columns.Add("Column1", "Product name");
            productsGridView.Columns.Add("Column2", "Strength");
            productsGridView.Columns.Add("Column3", "Quantity");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            // Get the text from the TextBoxes
            string Text1 = textBox1.Text;
            string Text2 = textBox2.Text;
            string Text3 = textBox3.Text;

            
            if (!string.IsNullOrEmpty(Text1) && !string.IsNullOrEmpty(Text2) && !string.IsNullOrEmpty(Text3))
            {
                panel5.Visible = true;

                productsGridView.Rows.Add(Text1, Text2, Text3);

                // Clear TextBoxes after adding
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                // Reset TextBox placeholders
                textBox1.Text = "Napa Extra";
                textBox1.ForeColor = Color.Silver;
                textBox2.Text = "5 MG";
                textBox2.ForeColor = Color.Silver;
                textBox3.Text = "1";
                textBox3.ForeColor = Color.Silver;
                
            }
        }
        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            productsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            productsGridView.EnableHeadersVisualStyles = false;
            productsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            productsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            productsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            productsGridView.GridColor = Color.Black;

            // Set default row styles
            productsGridView.DefaultCellStyle.BackColor = Color.White;
            productsGridView.DefaultCellStyle.ForeColor = Color.Black;
            productsGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            productsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            productsGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            productsGridView.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            productsGridView.RowHeadersVisible = false;
            productsGridView.ColumnHeadersVisible = true;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count > 0)
            {
                try
                {
                    // Remove each selected row
                    foreach (DataGridViewRow row in productsGridView.SelectedRows)
                    {
                        productsGridView.Rows.Remove(row);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while removing row: Please select which medicine you want to remove");
                }
            }
           
            if (productsGridView.Rows.Count == 1)
            {
                panel5.Visible = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        
        //Esc btn event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (Home.stack.Count > 0)
                {
                    Form previousForm = Home.stack.Pop();
                    this.Hide();
                    previousForm.Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            Home.stack.Push(this);
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel6.Visible = !panel6.Visible;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Home.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
            this.Show();
        }
        
        //Fix the textboxes as empty and set color silver to black
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox3.ForeColor = Color.Black;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }



        string conStr = "Data Source=ZOBAER;Initial Catalog=\"Pharmacy Management System\";User ID=sa;Password=admin;Encrypt=True;TrustServerCertificate=True";

        private void button4_Click(object sender, EventArgs e)
        {
            //Add element error tracer
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider6.SetError(this.textBox1, "Please fill Product Name");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider7.SetError(this.textBox2, "Please fill Strenth");
            }
            else if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider6.SetError(this.textBox3, "Please fill Quantity");
            }

            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox5.Focus();
                errorProvider1.SetError(this.textBox5, "Please fill Receiver Phone No");
            }
            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox6.Focus();
                errorProvider2.SetError(this.textBox6, "Please fill Region");
            }
            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox7.Focus();
                errorProvider3.SetError(this.textBox5, "Please fill City");
            }
            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox8.Focus();
                errorProvider4.SetError(this.textBox5, "Please fill Area");
            }
            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox9.Focus();
                errorProvider5.SetError(this.textBox9, "Please fill Receiver Phone No");
            }
            else
            {
                using(SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    foreach(DataGridViewRow row in productsGridView.Rows)
                    {
                        if(!row.IsNewRow)
                        {
                            string productname = row.Cells["column1"].Value.ToString();
                            string strenght = row.Cells["column2"].Value.ToString();
                            string quantity = row.Cells["column3"].Value.ToString();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO RequestOrderTable (productname, strength, quantity, receivername, receiverphone, region,city,area,address,receiveremail)VALUES(@productname, @strength, @quantity, @receivername, @receiverphone, @region, @city, @area, @address, @receiveremail)", con))
                            {
                                cmd.Parameters.AddWithValue("@productname", productname);
                                cmd.Parameters.AddWithValue("@strength", strenght);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@receivername", textBox4.Text);
                                cmd.Parameters.AddWithValue("@receiverphone", textBox5.Text);
                                cmd.Parameters.AddWithValue("@region", textBox6.Text);
                                cmd.Parameters.AddWithValue("@city", textBox8.Text);
                                cmd.Parameters.AddWithValue("@area", textBox7.Text);
                                cmd.Parameters.AddWithValue("@address", textBox9.Text);
                                cmd.Parameters.AddWithValue("@receiveremail", textBox10.Text);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Order is placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
            this.Show();
        }

        

        private void label26_Click_1(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (sessionManager.IsLoggedIn)
            {
                Cart cart = new Cart();
                Home.stack.Push(this);
                this.Hide();
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login or Sign up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            surgicalProduct surgicalProduct = new surgicalProduct();
            Home.stack.Push(this);  
            this.Hide();
            surgicalProduct.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            otcMedicine otc = new otcMedicine();
            Home.stack.Push(this);
            this.Hide();
            otc.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            babyCare babyCare = new babyCare();
            Home.stack.Push(this);
            this.Hide();
            babyCare.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            About about = new About();
            Home.stack.Push(this);
            this.Hide();
            about.ShowDialog();
        }
    }
}
