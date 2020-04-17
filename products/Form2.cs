using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace products
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
       /* private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }*/

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CartRepository cartRepository = new CartRepository();
            dataGridView1.DataSource = cartRepository.GetAll();
        }        

        private void Order_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
           /* if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }*/
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
