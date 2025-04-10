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
using productComparison.Data;
using productComparison.Model;

namespace productComparison
{
    public partial class Form1: Form
    {
        Form2 _form2;

        public Form1(Form2 form2):this()
        {
            _form2 = form2; // Aldığımız referansı saklıyoruz
        }


        private Database db;
        private ProductRepo productRepo;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
            productRepo= new ProductRepo(db.GetConnection());

        }
        


        private void btnProductSave_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            productRepo.ProductInsert(new Product { ProductName = txtProductName.Text, ProductPrice = int.Parse(txtProductPrice.Text), CompanyId = int.Parse(txtCompanyId.Text) });
            MessageBox.Show("ürün kaydedildi");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            db.CloseConnection();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = productRepo.ProductListele();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBackCompanyForm_Click(object sender, EventArgs e)
        {
            _form2.Show(); 
            this.Close();
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            DataTable dt = productRepo.ProductGetir(id);
            dataGridView1.DataSource=dt;
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtProductID.Text);
            productRepo.ProductDelete(id);
            dataGridView1.DataSource=productRepo.ProductListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productRepo.ProductUpdate(new Product { ProductName = txtProductName.Text, ProductPrice = int.Parse(txtProductPrice.Text),CompanyId=int.Parse(txtCompanyId.Text),ProductId=int.Parse(txtProductID.Text) });
            dataGridView1.DataSource=productRepo.ProductListele();

        }
    }
}
