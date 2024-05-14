using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class CategoriesDal
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;Database = etic; Uid = root; Pwd ='';");
        DataTable dt;

        public DataTable GetKategori()
        {
            ConnectionControl();
            dt = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM Categories", conn);
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
        public void AddKategori(Categories categories)
        {
            //Veri tabanı açık mı kontrolü
            ConnectionControl();
            //MySqlCommand sınıfından bir command nesnesi oluşturuyoruz. Bu, MySQL veritabanına bir komut göndermek için kullanılacak.
            //cat_id otomatik sıralı artan olduğu için ona değer atamıyoruz
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO categories(cat_title) VALUES(@cat_title)", conn);
            command.Parameters.AddWithValue("@cat_title", categories.cat_title);
            command.ExecuteNonQuery();
            conn.Close();

        }
        public void UpdateKategori(Categories categories)
        {
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("UPDATE categories SET cat_title=@cat_title WHERE cat_id = @id ",conn);
            command.Parameters.AddWithValue("@cat_title",categories.cat_title);
            command.Parameters.AddWithValue("@id",categories.cat_id);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
