using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productComparison.Model;

namespace productComparison.Data
{
    public class CompanyRepo
    {
        private SqlConnection _connection;

        public CompanyRepo(SqlConnection connection)
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

        public void CompanyInsert(Company company)
        {
            string query = "insert into Company (CompanyName) values (@p1)";
            SqlCommand cmd = new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@p1",company.CompanyName);
            cmd.ExecuteNonQuery();
            _connection.Close();

        }

        public DataTable CompanyListele() {
            string query = "select * from Company";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable HasProduct(int id)
        {
            string query = "select * from Product where CompanyId=@p1";
            SqlCommand cmd= new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@p1",id);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        } 

        public void DeleteCompany(int id)
        {
           MyconnectionState();
            string query = "DELETE FROM Company WHERE CompanyId = @id ";
            SqlCommand cmd =new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id",id );
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateCompany(int id,string CompanyName)
        {
            MyconnectionState();
            string query = "update Company set CompanyName=@p1 where CompanyId=@id ";
            SqlCommand cmd =new SqlCommand(query,_connection);
            cmd.Parameters.AddWithValue("@p1", CompanyName);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
