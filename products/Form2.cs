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

        private void Creams_Click(object sender, EventArgs e)
        {
            CreamRepository creamRepository = new CreamRepository();
            dataGridView1.DataSource = creamRepository.GetAll();
        }

        private void MakeUp_Click(object sender, EventArgs e)
        {
            MakeUpRepository makeUpRepository = new MakeUpRepository();
            dataGridView1.DataSource = makeUpRepository.GetAll();
        }

        private void Perfumes_Click(object sender, EventArgs e)
        {
            PerfumeRepository perfumeRepository = new PerfumeRepository();
            dataGridView1.DataSource = perfumeRepository.GetAll();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
