namespace AdminPanel
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.tbxImgIsim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxPricing = new System.Windows.Forms.TextBox();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblPricing = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_CategoryForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxKeywordsUpdate = new System.Windows.Forms.TextBox();
            this.lblKeywordsUpdate = new System.Windows.Forms.Label();
            this.tbxCategoryUpdate = new System.Windows.Forms.TextBox();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.tbxPricingUpdate = new System.Windows.Forms.TextBox();
            this.tbxDescUpdate = new System.Windows.Forms.TextBox();
            this.tbxTitleUpdate = new System.Windows.Forms.TextBox();
            this.lblPricingUpdate = new System.Windows.Forms.Label();
            this.lblDescUpdate = new System.Windows.Forms.Label();
            this.lblTitleUpdate = new System.Windows.Forms.Label();
            this.btn_SiparisForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxStock);
            this.gbxAdd.Controls.Add(this.lblProductStock);
            this.gbxAdd.Controls.Add(this.tbxImgIsim);
            this.gbxAdd.Controls.Add(this.button1);
            this.gbxAdd.Controls.Add(this.pictureBox1);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxKey);
            this.gbxAdd.Controls.Add(this.lblKey);
            this.gbxAdd.Controls.Add(this.tbxCategory);
            this.gbxAdd.Controls.Add(this.lblCategory);
            this.gbxAdd.Controls.Add(this.tbxPricing);
            this.gbxAdd.Controls.Add(this.tbxDesc);
            this.gbxAdd.Controls.Add(this.tbxTitle);
            this.gbxAdd.Controls.Add(this.lblPricing);
            this.gbxAdd.Controls.Add(this.lblDesc);
            this.gbxAdd.Controls.Add(this.lblTitle);
            this.gbxAdd.Location = new System.Drawing.Point(12, 385);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(638, 294);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(440, 77);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(181, 22);
            this.tbxStock.TabIndex = 15;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Location = new System.Drawing.Point(319, 80);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(41, 16);
            this.lblProductStock.TabIndex = 14;
            this.lblProductStock.Text = "Stock";
            // 
            // tbxImgIsim
            // 
            this.tbxImgIsim.Location = new System.Drawing.Point(323, 255);
            this.tbxImgIsim.Name = "tbxImgIsim";
            this.tbxImgIsim.Size = new System.Drawing.Size(168, 22);
            this.tbxImgIsim.TabIndex = 13;
            this.tbxImgIsim.TextChanged += new System.EventHandler(this.tbxImgIsim_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Elephant", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(522, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(323, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(440, 36);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(181, 22);
            this.tbxKey.TabIndex = 10;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(319, 39);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(115, 16);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Product Keywords";
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(127, 157);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(181, 22);
            this.tbxCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 160);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(111, 16);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Product Category";
            // 
            // tbxPricing
            // 
            this.tbxPricing.Location = new System.Drawing.Point(127, 117);
            this.tbxPricing.Name = "tbxPricing";
            this.tbxPricing.Size = new System.Drawing.Size(181, 22);
            this.tbxPricing.TabIndex = 4;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(127, 77);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(181, 22);
            this.tbxDesc.TabIndex = 3;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(127, 33);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(181, 22);
            this.tbxTitle.TabIndex = 2;
            // 
            // lblPricing
            // 
            this.lblPricing.AutoSize = true;
            this.lblPricing.Location = new System.Drawing.Point(6, 120);
            this.lblPricing.Name = "lblPricing";
            this.lblPricing.Size = new System.Drawing.Size(48, 16);
            this.lblPricing.TabIndex = 2;
            this.lblPricing.Text = "Pricing";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 77);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Title";
            // 
            // btn_CategoryForm
            // 
            this.btn_CategoryForm.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CategoryForm.Location = new System.Drawing.Point(1136, 12);
            this.btn_CategoryForm.Name = "btn_CategoryForm";
            this.btn_CategoryForm.Size = new System.Drawing.Size(206, 93);
            this.btn_CategoryForm.TabIndex = 2;
            this.btn_CategoryForm.Text = "Categories";
            this.btn_CategoryForm.UseVisualStyleBackColor = true;
            this.btn_CategoryForm.Click += new System.EventHandler(this.btn_CategoryForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(83, 25);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(204, 22);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.tbxStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxKeywordsUpdate);
            this.gbxUpdate.Controls.Add(this.lblKeywordsUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPricingUpdate);
            this.gbxUpdate.Controls.Add(this.tbxDescUpdate);
            this.gbxUpdate.Controls.Add(this.tbxTitleUpdate);
            this.gbxUpdate.Controls.Add(this.lblPricingUpdate);
            this.gbxUpdate.Controls.Add(this.lblDescUpdate);
            this.gbxUpdate.Controls.Add(this.lblTitleUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(704, 385);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(638, 294);
            this.gbxUpdate.TabIndex = 11;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Products Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 38);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(441, 71);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxStockUpdate.TabIndex = 12;
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(320, 74);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(41, 16);
            this.lblStockUpdate.TabIndex = 11;
            this.lblStockUpdate.Text = "Stock";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(510, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxKeywordsUpdate
            // 
            this.tbxKeywordsUpdate.Location = new System.Drawing.Point(441, 36);
            this.tbxKeywordsUpdate.Name = "tbxKeywordsUpdate";
            this.tbxKeywordsUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxKeywordsUpdate.TabIndex = 10;
            // 
            // lblKeywordsUpdate
            // 
            this.lblKeywordsUpdate.AutoSize = true;
            this.lblKeywordsUpdate.Location = new System.Drawing.Point(320, 39);
            this.lblKeywordsUpdate.Name = "lblKeywordsUpdate";
            this.lblKeywordsUpdate.Size = new System.Drawing.Size(115, 16);
            this.lblKeywordsUpdate.TabIndex = 9;
            this.lblKeywordsUpdate.Text = "Product Keywords";
            // 
            // tbxCategoryUpdate
            // 
            this.tbxCategoryUpdate.Location = new System.Drawing.Point(127, 157);
            this.tbxCategoryUpdate.Name = "tbxCategoryUpdate";
            this.tbxCategoryUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxCategoryUpdate.TabIndex = 6;
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(6, 160);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(111, 16);
            this.lblCategoryUpdate.TabIndex = 5;
            this.lblCategoryUpdate.Text = "Product Category";
            // 
            // tbxPricingUpdate
            // 
            this.tbxPricingUpdate.Location = new System.Drawing.Point(127, 117);
            this.tbxPricingUpdate.Name = "tbxPricingUpdate";
            this.tbxPricingUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxPricingUpdate.TabIndex = 4;
            // 
            // tbxDescUpdate
            // 
            this.tbxDescUpdate.Location = new System.Drawing.Point(127, 77);
            this.tbxDescUpdate.Name = "tbxDescUpdate";
            this.tbxDescUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxDescUpdate.TabIndex = 3;
            // 
            // tbxTitleUpdate
            // 
            this.tbxTitleUpdate.Location = new System.Drawing.Point(127, 33);
            this.tbxTitleUpdate.Name = "tbxTitleUpdate";
            this.tbxTitleUpdate.Size = new System.Drawing.Size(181, 22);
            this.tbxTitleUpdate.TabIndex = 2;
            // 
            // lblPricingUpdate
            // 
            this.lblPricingUpdate.AutoSize = true;
            this.lblPricingUpdate.Location = new System.Drawing.Point(6, 120);
            this.lblPricingUpdate.Name = "lblPricingUpdate";
            this.lblPricingUpdate.Size = new System.Drawing.Size(48, 16);
            this.lblPricingUpdate.TabIndex = 2;
            this.lblPricingUpdate.Text = "Pricing";
            // 
            // lblDescUpdate
            // 
            this.lblDescUpdate.AutoSize = true;
            this.lblDescUpdate.Location = new System.Drawing.Point(6, 77);
            this.lblDescUpdate.Name = "lblDescUpdate";
            this.lblDescUpdate.Size = new System.Drawing.Size(75, 16);
            this.lblDescUpdate.TabIndex = 1;
            this.lblDescUpdate.Text = "Description";
            // 
            // lblTitleUpdate
            // 
            this.lblTitleUpdate.AutoSize = true;
            this.lblTitleUpdate.Location = new System.Drawing.Point(6, 36);
            this.lblTitleUpdate.Name = "lblTitleUpdate";
            this.lblTitleUpdate.Size = new System.Drawing.Size(82, 16);
            this.lblTitleUpdate.TabIndex = 0;
            this.lblTitleUpdate.Text = "Product Title";
            // 
            // btn_SiparisForm
            // 
            this.btn_SiparisForm.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SiparisForm.Location = new System.Drawing.Point(924, 12);
            this.btn_SiparisForm.Name = "btn_SiparisForm";
            this.btn_SiparisForm.Size = new System.Drawing.Size(206, 93);
            this.btn_SiparisForm.TabIndex = 12;
            this.btn_SiparisForm.Text = "Siparişler";
            this.btn_SiparisForm.UseVisualStyleBackColor = true;
            this.btn_SiparisForm.Click += new System.EventHandler(this.btn_SiparisForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 772);
            this.Controls.Add(this.btn_SiparisForm);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CategoryForm);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxPricing;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblPricing;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_CategoryForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxKeywordsUpdate;
        private System.Windows.Forms.Label lblKeywordsUpdate;
        private System.Windows.Forms.TextBox tbxCategoryUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.TextBox tbxPricingUpdate;
        private System.Windows.Forms.TextBox tbxDescUpdate;
        private System.Windows.Forms.TextBox tbxTitleUpdate;
        private System.Windows.Forms.Label lblPricingUpdate;
        private System.Windows.Forms.Label lblDescUpdate;
        private System.Windows.Forms.Label lblTitleUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxImgIsim;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_SiparisForm;
    }
}

