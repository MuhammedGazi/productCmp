namespace productComparison
{
    partial class Form2
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnNextProductForm = new System.Windows.Forms.Button();
            this.btnHasProduct = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(105, 22);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(90, 31);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(5, 22);
            this.btnProductSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(96, 31);
            this.btnProductSave.TabIndex = 17;
            this.btnProductSave.Text = "kaydet";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(80, 58);
            this.txtCompanyID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(76, 20);
            this.txtCompanyID.TabIndex = 14;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(80, 29);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(76, 20);
            this.txtCompanyName.TabIndex = 13;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(21, 61);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(49, 15);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.Text = "şirket Id";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(21, 29);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(56, 15);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "şirket adı";
            // 
            // btnNextProductForm
            // 
            this.btnNextProductForm.Location = new System.Drawing.Point(9, 337);
            this.btnNextProductForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextProductForm.Name = "btnNextProductForm";
            this.btnNextProductForm.Size = new System.Drawing.Size(146, 19);
            this.btnNextProductForm.TabIndex = 20;
            this.btnNextProductForm.Text = "ürün ekleme sayfası -->";
            this.btnNextProductForm.UseVisualStyleBackColor = true;
            this.btnNextProductForm.Click += new System.EventHandler(this.btnNextProductForm_Click);
            // 
            // btnHasProduct
            // 
            this.btnHasProduct.Location = new System.Drawing.Point(8, 57);
            this.btnHasProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHasProduct.Name = "btnHasProduct";
            this.btnHasProduct.Size = new System.Drawing.Size(93, 27);
            this.btnHasProduct.TabIndex = 21;
            this.btnHasProduct.Text = "sahip ürünleri getir";
            this.btnHasProduct.UseVisualStyleBackColor = true;
            this.btnHasProduct.Click += new System.EventHandler(this.btnHasProduct_Click);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(105, 88);
            this.btnDeleteCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(90, 24);
            this.btnDeleteCompany.TabIndex = 22;
            this.btnDeleteCompany.Text = "şirket sil";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.Location = new System.Drawing.Point(11, 89);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnCompanyUpdate.TabIndex = 23;
            this.btnCompanyUpdate.Text = "güncelle";
            this.btnCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductSave);
            this.groupBox1.Controls.Add(this.btnDeleteCompany);
            this.groupBox1.Controls.Add(this.btnCompanyUpdate);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnHasProduct);
            this.groupBox1.Location = new System.Drawing.Point(1, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(206, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(374, 307);
            this.dataGridView2.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNextProductForm);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnNextProductForm;
        private System.Windows.Forms.Button btnHasProduct;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnCompanyUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}