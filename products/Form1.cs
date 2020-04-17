using Business;
using Data;
using System;
using System.Windows.Forms;

namespace products
{
    public partial class Form1 : Form
    {
       
        private ProductBusiness productBusiness = new ProductBusiness();
        public Form1()
        {
            InitializeComponent();          
        }
        private void UpdateGrid()
        {
            dataGridView2.DataSource = productBusiness.GetAll();
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ResetSelect()
        {
            dataGridView2.ClearSelection();
            dataGridView2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Perfumes_Click(object sender, EventArgs e)
        {
            PerfumeRepository perfumeRepository = new PerfumeRepository();
            dataGridView2.DataSource = perfumeRepository.GetAll();

        }

        private void Creams_Click(object sender, EventArgs e)
        {
            CreamRepository creamRepository = new CreamRepository();
            dataGridView2.DataSource = creamRepository.GetAll();
        }

        private void MakeUp_Click(object sender, EventArgs e)
        {
            MakeUpRepository makeUpRepository = new MakeUpRepository();
            dataGridView2.DataSource = makeUpRepository.GetAll();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            CartRepository cartRepository = new CartRepository();

            //dataGridView2.DataSource = cartRepository.Add();
            // var perfume = new Perfume();

            if (dataGridView2.SelectedRows.Count > 0)
            {
                var item = dataGridView2.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                cartRepository.Add(item);
                // UpdateGrid();
                //ResetSelect();            
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {
          /*  Form2 f2 = new Form2();
            f2.Show();*/
            CartRepository cartRepository = new CartRepository();
            dataGridView2.DataSource = cartRepository.GetAll();
        }
    }
}
