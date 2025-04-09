namespace productComparison
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblPoductPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(44, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(54, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ürün adı";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(44, 143);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(46, 16);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ürün Id";
            // 
            // lblPoductPrice
            // 
            this.lblPoductPrice.AutoSize = true;
            this.lblPoductPrice.Location = new System.Drawing.Point(44, 94);
            this.lblPoductPrice.Name = "lblPoductPrice";
            this.lblPoductPrice.Size = new System.Drawing.Size(62, 16);
            this.lblPoductPrice.TabIndex = 2;
            this.lblPoductPrice.Text = "ürün fiyatı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(122, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(122, 140);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(122, 94);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 378);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(122, 190);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductSave.TabIndex = 7;
            this.btnProductSave.Text = "kaydet";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(122, 248);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblPoductPrice);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblPoductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListele;
    }
}

