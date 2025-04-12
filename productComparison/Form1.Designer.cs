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
            this.btnBackCompanyForm = new System.Windows.Forms.Button();
            this.btnGetByID = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.btnNextComparisonForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 36);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ürün adı";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(33, 116);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(45, 15);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ürün Id";
            // 
            // lblPoductPrice
            // 
            this.lblPoductPrice.AutoSize = true;
            this.lblPoductPrice.Location = new System.Drawing.Point(33, 76);
            this.lblPoductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoductPrice.Name = "lblPoductPrice";
            this.lblPoductPrice.Size = new System.Drawing.Size(59, 15);
            this.lblPoductPrice.TabIndex = 2;
            this.lblPoductPrice.Text = "ürün fiyatı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(92, 36);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(76, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(92, 114);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(76, 20);
            this.txtProductID.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(92, 76);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(76, 20);
            this.txtProductPrice.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 281);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(96, 201);
            this.btnProductSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(72, 28);
            this.btnProductSave.TabIndex = 7;
            this.btnProductSave.Text = "kaydet";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 233);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 20);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(22, 233);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(70, 21);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnBackCompanyForm
            // 
            this.btnBackCompanyForm.Location = new System.Drawing.Point(3, 333);
            this.btnBackCompanyForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackCompanyForm.Name = "btnBackCompanyForm";
            this.btnBackCompanyForm.Size = new System.Drawing.Size(145, 23);
            this.btnBackCompanyForm.TabIndex = 10;
            this.btnBackCompanyForm.Text = "<-- şirket sayfasına dön";
            this.btnBackCompanyForm.UseVisualStyleBackColor = true;
            this.btnBackCompanyForm.Click += new System.EventHandler(this.btnBackCompanyForm_Click);
            // 
            // btnGetByID
            // 
            this.btnGetByID.Location = new System.Drawing.Point(23, 258);
            this.btnGetByID.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetByID.Name = "btnGetByID";
            this.btnGetByID.Size = new System.Drawing.Size(75, 24);
            this.btnGetByID.TabIndex = 11;
            this.btnGetByID.Text = "ürün getir ID";
            this.btnGetByID.UseVisualStyleBackColor = true;
            this.btnGetByID.Click += new System.EventHandler(this.btnGetByID_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(104, 257);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(64, 25);
            this.btnProductDelete.TabIndex = 12;
            this.btnProductDelete.Text = "ürün sil ID";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 201);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "güncelle ID";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "company ID";
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(92, 145);
            this.txtCompanyId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(76, 20);
            this.txtCompanyId.TabIndex = 15;
            // 
            // btnNextComparisonForm
            // 
            this.btnNextComparisonForm.Location = new System.Drawing.Point(204, 333);
            this.btnNextComparisonForm.Name = "btnNextComparisonForm";
            this.btnNextComparisonForm.Size = new System.Drawing.Size(144, 23);
            this.btnNextComparisonForm.TabIndex = 16;
            this.btnNextComparisonForm.Text = "ürün kıyaslama git-->";
            this.btnNextComparisonForm.UseVisualStyleBackColor = true;
            this.btnNextComparisonForm.Click += new System.EventHandler(this.btnNextComparisonForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNextComparisonForm);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnGetByID);
            this.Controls.Add(this.btnBackCompanyForm);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ürün sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnBackCompanyForm;
        private System.Windows.Forms.Button btnGetByID;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Button btnNextComparisonForm;
    }
}

