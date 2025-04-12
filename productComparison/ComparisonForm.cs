using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productComparison
{
    public partial class ComparisonForm: Form
    {
        public ComparisonForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi = "Coca Cola 2.5L";
            Dictionary<string, decimal> fiyatlar = new Dictionary<string, decimal>()
    {
        { "Şok", 59.90m },
        { "Migros", 62.50m },
        { "A101", 0 },
        { "BİM", 60.00m }
    };

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
