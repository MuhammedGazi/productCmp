using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productComparison
{
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-GLCB4AC;Initial Catalog=productComparisonDB;Integrated Security=True";
        private SqlConnection connection;

        // Yapıcı metot (constructor) - Bağlantıyı burada başlatıyoruz
        public Database()
        {
            connection = new SqlConnection(connectionString);
        }

        // Bağlantıyı açma
        public void OpenConnection()
        {
            try
            {
                connection.Open();  // Bağlantıyı aç
                Console.WriteLine("Bağlantı başarılı!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }

        // Bağlantıyı kapama
        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Bağlantı kapatıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }


    }
}
