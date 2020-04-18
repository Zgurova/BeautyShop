using Data;
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

            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
