using Data;
using System;
using System.Windows.Forms;

namespace products
{
    public partial class Form1 : Form
    {
        private readonly ProductContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new ProductContext();
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
            /*var perfume = new Perfume();
            dbContext.Cart.Add(
            {
                
            });*/
        }

        /*private void Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var item = dataGridView2.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
            }
        }*/
    }
}
