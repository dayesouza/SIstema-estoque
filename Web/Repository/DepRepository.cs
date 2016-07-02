using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Web.Repository {
  public class DepRepository {
    private SqlConnection con;
    //To Handle connection related activities    
    private void connection() {
      string constr = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
      con = new SqlConnection(constr);
    }

    public bool AddDeposito(Models.DepositoModel obj) {
      connection();
      SqlCommand com = new SqlCommand("AddDeposito", con);
      com.CommandType = CommandType.StoredProcedure;

      com.Parameters.AddWithValue("@cod_deposito", obj.cod_deposito);
      com.Parameters.AddWithValue("@qtde_produto", obj.quantidade);
      com.Parameters.AddWithValue("@sku_produto", obj.sku_produto);
      com.Parameters.AddWithValue("@data_validade", obj.data_validade);

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

    public List<Models.DepositoModel> GetDeposito() {
      connection();
      List<Models.DepositoModel> DepList = new List<Models.DepositoModel>();


      SqlCommand com = new SqlCommand("GetDeposito", con);
      com.CommandType = CommandType.StoredProcedure;
      SqlDataAdapter da = new SqlDataAdapter(com);
      DataTable dt = new DataTable();

      con.Open();
      da.Fill(dt);
      con.Close();
      //Bind EmpModel generic list using dataRow     
      foreach (DataRow dr in dt.Rows) {

        DepList.Add(

            new Models.DepositoModel {

              cod_deposito = Convert.ToInt32(dr["cod_deposito"]),
              sku_produto = Convert.ToInt32(dr["sku_produto"]),
              data_validade = Convert.ToDateTime(dr["data_validade"]),
              quantidade = Convert.ToInt32(dr["quantidade"])
            }


            );


      }

      return DepList;


    }

  }
}