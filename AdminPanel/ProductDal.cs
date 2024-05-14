using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{

    public class ProductDal
    {
        /// <summary>
        /// Local'de MySql Bağlantı
        /// </summary>
        MySqlConnection conn = new MySqlConnection("server = localhost;Database = etic; Uid = root; Pwd ='';");
        DataTable dt;

        public DataTable GetAll()
        {
            ConnectionControl();
            dt = new DataTable();
            //MySqlCommand sınıfından bir command nesnesi oluşturuyoruz. Bu, MySQL veritabanına bir komut göndermek için kullanılacak.
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT P.*, C.cat_title FROM Products P INNER JOIN categories C ON P.product_cat = C.cat_id", conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;

        }
        //Aramaya Göre ürünleri Getirme Metodu
        public DataTable GetByName(string key)
        {
            //Bağlantı Kontrol
            ConnectionControl();
            dt = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT P.*, C.cat_title FROM Products P INNER JOIN categories C ON P.product_cat = C.cat_id WHERE product_title LIKE'%{key}%' ", conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;

        }
        /// <summary>
        /// Veri tabanı bağlantısı açık mı? açık değilse aç
        /// </summary>
        private void ConnectionControl()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// Product tablosuna veri ekleme
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            //Veri tabanı açık mı kontrolü
            ConnectionControl();
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO products(product_cat, product_stock, product_title,product_price,product_desc,product_image,product_keywords) VALUES(@product_cat,@product_stock ,@product_title,@product_price,@product_desc,@product_image,@product_keywords)", conn);
            command.Parameters.AddWithValue("@product_cat", product.product_cat);
            command.Parameters.AddWithValue("@product_stock", product.product_stock);
            command.Parameters.AddWithValue("@product_title", product.product_title);
            command.Parameters.AddWithValue("@product_price", product.product_price);
            command.Parameters.AddWithValue("@product_desc", product.product_desc);
            command.Parameters.AddWithValue("@product_image", product.product_image);
            command.Parameters.AddWithValue("@product_keywords", product.product_keywords);
            //ExecuteNonQuery metodu, sorguyu veritabanında yürütür ve etkilenen satır sayısını döndürür.
            command.ExecuteNonQuery();
            conn.Close();

        }
        /// <summary>
        /// Product tablosundaki verileri güncelleme
        /// </summary>
        /// <param name="product"></param>
        public void Update(Product product)
        {
            ConnectionControl();
            MySqlCommand command = new MySqlCommand(
                "UPDATE products SET product_title=@product_title, product_price=@product_price,product_cat=@product_cat ,product_stock=@product_stock ,product_desc=@product_desc,product_image=@product_image,product_keywords=@product_keywords WHERE product_id = @id", conn);

            command.Parameters.AddWithValue("@product_title", product.product_title);
            command.Parameters.AddWithValue("@product_price", product.product_price);
            command.Parameters.AddWithValue("@product_cat", product.product_cat);
            command.Parameters.AddWithValue("@product_stock", product.product_stock);
            command.Parameters.AddWithValue("@product_desc", product.product_desc);
            command.Parameters.AddWithValue("@product_image", product.product_image);
            command.Parameters.AddWithValue("@product_keywords", product.product_keywords);
            command.Parameters.AddWithValue("@id", product.product_id);
            command.ExecuteNonQuery();
            conn.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("DELETE FROM Products WHERE product_id=@id", conn);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
