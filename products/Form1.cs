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
            var item = dataGridView2.SelectedRows[0].Cells;
            var id = item[0].Value.ToString();
            var name = item[1].Value.ToString();
            decimal price = decimal.Parse(item[2].Value.ToString());

            Cart cart = new Cart(id, name, price);
            using (var context = new ProductContext())
            {
                context.Cart.Add(cart);
                context.SaveChanges();
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            CartRepository cartRepository = new CartRepository();
            dataGridView2.DataSource = cartRepository.GetAll();
        }
    }
}
   




       
