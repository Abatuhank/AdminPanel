using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    //Veri Tabanındaki Product Tablosuna eş değer sınıf oluşturduk
    public class Product
    {
        public int product_id { get; set; }
        public int  product_cat { get; set; }
        public int product_stock { get; set; }
        public string product_title { get; set;}
        public int product_price { get; set;}
        public string product_desc { get; set;}
        public string product_image { get; set;}
        public string product_keywords { get; set;}
    }
}
