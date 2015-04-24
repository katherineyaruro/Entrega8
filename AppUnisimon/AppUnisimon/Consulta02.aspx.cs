using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace AppUnisimon
{
    public partial class Consulta02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc7\documents\visual studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185023.mdf;Initial Catalog=aspnet-AppUnisimon-20150423185023;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
        
            string sqlCommand = "SELECT * FROM Usuarios";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            DataTable datatable = new DataTable();
            cn.Open();
            int recordsAffected = da.Fill(datatable);
            GridView1.DataSource = datatable;
            GridView1.DataBind();
            cn.Close();
      


        }
    }
}