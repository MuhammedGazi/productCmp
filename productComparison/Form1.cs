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

namespace productComparison
{
    public partial class Form1: Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
        }


        private void btnProductSave_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            string productName;
            int productPrice;
            productName=txtProductName.Text;
            productPrice=int.Parse(txtProductPrice.Text);
            db.ProductInsert(productName, productPrice);
            MessageBox.Show("ürün kaydedildi");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            db.CloseConnection();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ProductListele();
            dataGridView1.DataSource = dt;
        }
    }
}
