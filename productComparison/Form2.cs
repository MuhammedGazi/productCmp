using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productComparison.Data;
using productComparison.Model;

namespace productComparison
{
    public partial class Form2: Form
    {
        private Database db;
        private CompanyRepo companyRepo;
        public Form2()
        {
            InitializeComponent();
            db = new Database();
            companyRepo = new CompanyRepo(db.GetConnection());
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            companyRepo.CompanyInsert(new Company {CompanyName=txtCompanyName.Text});
            MessageBox.Show("şirket kaydedildi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
            DataTable dt=companyRepo.CompanyListele();
            dataGridView2.DataSource = dt;
        }

        private void btnNextProductForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);  
            form1.Show();               
            this.Hide();
        }
    }
}
