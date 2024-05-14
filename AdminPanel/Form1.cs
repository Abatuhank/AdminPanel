using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Google.Protobuf.WellKnownTypes;

namespace AdminPanel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        ProductDal _productDal = new ProductDal();
        string imgName = "default.png";

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        /// <summary>
        /// dataGridView1'i ProductDal Sınıfındaki GettAll Metodunu çağırarak doldur
        /// </summary>
        private void LoadProduct()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }
        private void LoadProductName()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }
        private void SearchLoadProducts(string key)
        {
            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            dataGridView1.DataSource = _productDal.GetByName(key);
        }

        /// <summary>
        /// Ekleme Butonuna Tıkladığında Add Metodunu çalıştır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                product_title = tbxTitle.Text,
                product_price = Convert.ToInt32(tbxPricing.Text),
                product_desc = tbxDesc.Text,
                product_cat = Convert.ToInt32(tbxCategory.Text),
                product_image = string.IsNullOrEmpty(imgName) ? "default.png" : imgName,
                product_keywords = tbxKey.Text,
                product_stock = Convert.ToInt32(tbxStock.Text)

            });
            CopyImage(tbxImgIsim.Text, "C:\\xampp\\htdocs\\product_images");
            LoadProduct();
            MessageBox.Show("Product Added!");
        }

        private void btn_CategoryForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        /// <summary>
        /// DataGridView in Satırlarından birine tıklandığında ilgili değerlerin ekrana gelmesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxTitleUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxDescUpdate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxPricingUpdate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxCategoryUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxKeywordsUpdate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxImgIsim.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxStockUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Ekrana gelen değerlerin değiştirilebilip Update Butona tıklandığında Güncellenmesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                product_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                product_title = tbxTitleUpdate.Text,
                product_desc = tbxDescUpdate.Text,
                product_price = Convert.ToInt32(tbxPricingUpdate.Text),
                product_cat = Convert.ToInt32(tbxCategoryUpdate.Text),
                product_image = tbxImgIsim.Text,
                product_keywords = tbxKeywordsUpdate.Text,
                product_stock = Convert.ToInt32(tbxStockUpdate.Text)
            };
            _productDal.Update(product);
            LoadProduct();
            MessageBox.Show("Updated!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            _productDal.Delete(id);
            LoadProduct();
            MessageBox.Show("Product Deleted!");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchLoadProducts(txbSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;
            tbxImgIsim.Text = openFileDialog.FileName;
            imgName = openFileDialog.SafeFileName;

        }

        private void CopyImage(string sourceFilePath, string destinationFolderPath)
        {
            try
            {
                // Kaynak dosyanın varlığını kontrol etme
                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException("Kaynak dosya bulunamadı.", sourceFilePath);
                }

                // Hedef klasörün varlığını kontrol etme ve yoksa oluşturma
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                // Dosya adını alırken aynı isimde dosya varsa, üzerine yazılsın mı kontrolü
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

                // Dosyayı hedef klasöre kopyala
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch (Exception)
            {

                MessageBox.Show("Fotoğraf Seçilmediği İçin Default Değer Gönderildi!");
            }


        }

        private void tbxImgIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SiparisForm_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
