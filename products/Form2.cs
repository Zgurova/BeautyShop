using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace products
{
    public partial class Form2 : Form
    {
        private ProductBusiness productBusiness = new ProductBusiness();
        public Form2()
        {
            InitializeComponent();
        }
       
        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }        

        private void Order_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            var id = item[0].Value.ToString();
            CartRepository cartRepository = new CartRepository();
            cartRepository.Remove(id);
            dataGridView1.Update();
            UpdateGrid();
            ResetSelect();


        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
