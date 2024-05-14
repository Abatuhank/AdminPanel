using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CategoriesDal _categoriesDal = new CategoriesDal();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dataGridView1.DataSource = _categoriesDal.GetKategori();
        }

        //Butona tıklandığında Categories Sınıfındaki AddKategori metodunu çalıştırır
        //metot içinde Categories nesnesi oluşturup belirtilen değerleri ilgili özelliklere verdik
        private void button2_Click(object sender, EventArgs e)
        {
            _categoriesDal.AddKategori(new Categories
            {
                cat_title = tbxCatTitle.Text

            });
            LoadCategories();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCattitleUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories()
            {
                cat_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                cat_title = tbxCattitleUpdate.Text
            };
            _categoriesDal.UpdateKategori(categories);
            LoadCategories();
            MessageBox.Show("Kategori Updated!");
        }
    }
}
