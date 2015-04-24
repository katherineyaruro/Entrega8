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
    public partial class Consulta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtApellido0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre1, apellido1, correo1;
            int edad1;
            nombre1 = txtNombre.Text;
            apellido1 = txtApellido.Text;
            edad1 = int.Parse(txtEdad0.Text);
            correo1 = txtCorreo.Text;
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc7\documents\visual studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185023.mdf;Initial Catalog=aspnet-AppUnisimon-20150423185023;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            string sqlCommand = "INSERT INTO Usuarios(nombre, apellido, edad, correo)VALUES" + "('"+nombre1+"', '"+apellido1+"','"+edad1+"', '"+correo1+"')";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
          Response.Write("Regsitro Realizado");
           
            cn.Close();
        }
    }
}