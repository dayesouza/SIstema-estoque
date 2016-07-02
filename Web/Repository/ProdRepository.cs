using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web.Repository {
  public class ProdRepository {
    private SqlConnection con;
    //To Handle connection related activities    
    private void connection() {
      string constr = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
      con = new SqlConnection(constr);
    }
    //To Add Employee details    
    public bool AddProducts(Models.ProdutoModel obj) {
      connection();
      SqlCommand com = new SqlCommand("AddProducts", con);
      com.CommandType = CommandType.StoredProcedure;
      
      com.Parameters.AddWithValue("@descricao", obj.descricao);
      com.Parameters.AddWithValue("@tamanho", obj.tamanho);
      com.Parameters.AddWithValue("@cor", obj.cor);

      con.Open();
      int i = com.ExecuteNonQuery();
      con.Close();
      if (i >= 1) {
        return true;
      }
      else {
        return false;
      }
    }
    //To view employee details with generic list     
    public List<Models.ProdutoModel> GetProducts() {
      connection();
      List<Models.ProdutoModel> ProdList = new List<Models.ProdutoModel>();


      SqlCommand com = new SqlCommand("GetProducts", con);
      com.CommandType = CommandType.StoredProcedure;
      SqlDataAdapter da = new SqlDataAdapter(com);
      DataTable dt = new DataTable();

      con.Open();
      da.Fill(dt);
      con.Close();
      //Bind EmpModel generic list using dataRow     
      foreach (DataRow dr in dt.Rows) {

        ProdList.Add(

            new Models.ProdutoModel {
              sku = Convert.ToInt32(dr["sku"]),
              descricao = Convert.ToString(dr["descricao"]),
              tamanho = Convert.ToString(dr["tamanho"]),
              cor = Convert.ToString(dr["cor"])
            }


            );


      }

      return ProdList;


    }
    //To Update Products details    
    public bool UpdateProducts(Models.ProdutoModel obj) {

      connection();
      SqlCommand com = new SqlCommand("UpdateProducts", con);

      com.CommandType = CommandType.StoredProcedure;
      com.Parameters.AddWithValue("@descricao", obj.descricao);
      com.Parameters.AddWithValue("@tamanho", obj.tamanho);
      com.Parameters.AddWithValue("@cor", obj.cor);
      com.Parameters.AddWithValue("@sku", obj.sku);
      con.Open();
      int i = com.ExecuteNonQuery();
      con.Close();
      if (i >= 1) {

        return true;

      }
      else {

        return false;
      }


    }
    //To delete Employee details    
    public bool DeleteProducts(int sku) {

      connection();
      SqlCommand com = new SqlCommand("DeleteProducts", con);

      com.CommandType = CommandType.StoredProcedure;
      com.Parameters.AddWithValue("@sku", sku);

      con.Open();
      int i = com.ExecuteNonQuery();
      con.Close();
      if (i >= 1) {

        return true;

      }
      else {

        return false;
      }


    }
  }
}
