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
    public partial class ComparisonForm: Form
    {
        Form1 _form1;

        public ComparisonForm(Form1 form1) : this()
        {
            _form1 = form1; // Aldığımız referansı saklıyoruz
        }
        private void btnBackProductForm_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Close();
        }
        private Database db;
        private ProductRepo productRepo;
        public ComparisonForm()
        {
            InitializeComponent();
            db = new Database();
            productRepo = new ProductRepo(db.GetConnection());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (Dictionary<string, int> fiyatlar,string urunAdi) = productRepo.ProductList(txtProductCom.Text);

            // GroupBox (ürün başlığı için)
            GroupBox gb = new GroupBox();
            gb.Text = urunAdi;
            gb.Width = 500;
            gb.Height = 120;
            gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gb.Top = panel1.Controls.Count * (gb.Height + 10);

            int x = 10;
            foreach (var item in fiyatlar)
            {
                Panel firmaPanel = new Panel();
                firmaPanel.Width = 100;
                firmaPanel.Height = 60;
                firmaPanel.BackColor = Color.LightGray;
                firmaPanel.Location = new Point(x, 30);

                // Şirket adı
                Label lblFirma = new Label();
                lblFirma.Text = item.Key;
                lblFirma.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblFirma.Location = new Point(5, 5);
                lblFirma.AutoSize = true;

                // Fiyat
                Label lblFiyat = new Label();
                lblFiyat.Text = item.Value == 0 ? "Yok" : item.Value.ToString("0.00") + "₺";
                lblFiyat.ForeColor = Color.DarkGreen;
                lblFiyat.Location = new Point(5, 30);
                lblFiyat.AutoSize = true;

                // Panellere ekle
                firmaPanel.Controls.Add(lblFirma);
                firmaPanel.Controls.Add(lblFiyat);

                // GroupBox'a ekle
                gb.Controls.Add(firmaPanel);

                x += 110; // sonraki panelin konumu
            }

            panel1.Controls.Add(gb);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
