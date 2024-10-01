using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2024_10_01
{
    public static class Database
    {
        static MySqlConnection Connection;
        static MySqlCommand SelectAllQuery;
        public static void OpenConnection()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            Connection = new MySqlConnection($"Host={host};User={user};Password={password}");
            try
            {
                Connection.Open();
                new MySqlCommand("CREATE DATABASE IF NOT EXISTS `products`", Connection).ExecuteNonQuery();
                new MySqlCommand("USE `products`", Connection).ExecuteNonQuery();
                new MySqlCommand("CREATE TABLE IF NOT EXISTS `products` (`id` INT AUTO_INCREMENT PRIMARY KEY, `name` VARCHAR(50), `quantity` INT, `price` INT)", Connection).ExecuteNonQuery();
                SelectAllQuery = new MySqlCommand("SELECT * FROM `products`", Connection);
            }
            catch (Exception e)
            {
                ErrorMessage(e);
            }
        }
        static void ErrorMessage(Exception e)
        {
            MessageBox.Show(e.Message, "Database error");
        }
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                MySqlDataReader reader = SelectAllQuery.ExecuteReader();
                while (reader.Read()) products.Add(new Product
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Quantity = reader.GetInt32("quantity"),
                    Price = reader.GetInt32("price")
                });
                reader.Close();
            }
            catch (Exception e)
            {
                ErrorMessage(e);
            }
            return products;
        }
        public static void AddProduct(Product product)
        {
            try
            {
                new MySqlCommand($"INSERT INTO `products` (`name`, `quantity`, `price`) VALUES ('{product.Name}', {product.Quantity}, {product.Price})", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorMessage(e);
            }
        }
        public static void DeleteById(int id)
        {
            try
            {
                new MySqlCommand($"DELETE FROM `products` WHERE `id`={id}", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorMessage(e);
            }
        }
        public static void DeleteAll()
        {
            try
            {
                new MySqlCommand($"DELETE FROM `products`", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorMessage(e);
            }
        }
    }
}
