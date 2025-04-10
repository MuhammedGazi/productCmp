using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productComparison.Model;

namespace productComparison.Data
{
    public class ProductRepo
    {
        private SqlConnection _connection;

        public ProductRepo(SqlConnection connection)
        {
            _connection = connection;
        }
        public void ProductInsert(Product product)
        {
            SqlCommand cmd = new SqlCommand("insert into Product (ProductName,ProductPrice,CompanyId) values (@p1,@p2,@p3)", _connection);
            cmd.Parameters.AddWithValue("@p1",product.ProductName);
            cmd.Parameters.AddWithValue("@p2",product.ProductPrice);
            cmd.Parameters.AddWithValue("@p3", product.CompanyId);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public DataTable ProductListele()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string query = "select * from Product";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ProductGetir(int id)
        {
            string query = "select * from Product where ProductId = @id";
            SqlCommand cmd = new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void ProductDelete(int id)
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string query = "DELETE FROM Product WHERE ProductId = @id";
            SqlCommand cmd =new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void ProductUpdate(Product product)
        {
            string query = "update Product set ProductName=@p1,ProductPrice=@p2,CompanyId=@p3 where ProductId=@p4";
            SqlCommand cmd = new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@p1",product.ProductName);
            cmd.Parameters.AddWithValue("@p2", product.ProductPrice);
            cmd.Parameters.AddWithValue("@p3",product.CompanyId);
            cmd.Parameters.AddWithValue("@p4",product.ProductId);
            cmd.ExecuteNonQuery();
            _connection.Close();


        }
    }
}
