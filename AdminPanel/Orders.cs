using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class Orders
    {
        MySqlConnection conn = new MySqlConnection("server = localhost;Database = etic; Uid = root; Pwd ='';");
        DataTable dt;
        public DataTable GetAll()
        {
            ConnectionControl();
            dt = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(
                "SELECT O.order_id , O.f_name 'Kullanıcı Adı', O.email, O.address Adres, O.city Şehir, O.state Mahalle, P.product_title 'Urun', OP.create_date 'Sipariş Tarihi' FROM orders_info O  INNER JOIN order_products OP ON O.order_id = OP.order_id INNER JOIN products P ON OP.product_id = P.product_id ORDER BY order_id DESC", conn);
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
    }
}
