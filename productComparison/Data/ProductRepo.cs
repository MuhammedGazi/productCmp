using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productComparison.Model;
using System.Diagnostics;

namespace productComparison.Data
{
    public class ProductRepo
    {
        private SqlConnection _connection;

        public ProductRepo(SqlConnection connection)
        {
            _connection = connection;
        }
        private void MyconnectionState()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
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
            MyconnectionState();
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
            MyconnectionState();
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

        private string IdtoCompanyNameConvert(string companyId)
        {
            string query = "select CompanyName from Company where CompanyId=@companyId";
            SqlCommand cmd=new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@companyId",companyId);

            object result = cmd.ExecuteScalar(); //ilk gelen tek değeri döner.

            // null kontrolü
            return result != null ? result.ToString() : string.Empty;

        }
        public (Dictionary<string, int>,string) ProductList(string id)
        {
            MyconnectionState();
            string query = "select * from Product where ProductName=@id";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Dictionary<string ,int> productDic = new Dictionary<string ,int>();
            foreach (DataRow row in dt.Rows)
            {

                string companyName = IdtoCompanyNameConvert(row["CompanyId"].ToString());
                int price = Convert.ToInt32(row["ProductPrice"]);
                productDic[companyName] = price;
            }
            string name = dt.Rows[0]["ProductName"].ToString();
            return (productDic,name);
        }

    }
}
