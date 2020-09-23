using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    public class Products
    {
        public static void AddNewProduct(string product_name, string product_price, string product_amount)
        {
            string sql = "INSERT INTO tb_products (PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_AMOUNT) VALUES('" + product_name + "', '"+ product_price + "', '"+ product_amount + "')"; ;
            database.DataBaseCommand(sql);
        }

        public static void UpdateProduct(string product_name, string new_product_name, string new_product_price, string new_product_amount)
        {
            string sql = sql = "UPDATE tb_products SET PRODUCT_NAME='" + new_product_name + "', PRODUCT_PRICE='" + new_product_price + "', PRODUCT_AMOUNT='"+ new_product_amount +"' WHERE PRODUCT_NAME='" + product_name + "'; ";
            database.DataBaseCommand(sql);
        }

        public static void RemoveProduct(string product_name)
        {
            string sql = "DELETE FROM tb_products WHERE PRODUCT_NAME='" + product_name + "';";
            database.DataBaseCommand(sql);
        }
    }
}
