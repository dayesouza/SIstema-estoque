using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Web.Repository {
  public class MovRepository {
    private SqlConnection con;
    //To Handle connection related activities    
    private void connection() {
      string constr = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
      con = new SqlConnection(constr);
    }
  }
}