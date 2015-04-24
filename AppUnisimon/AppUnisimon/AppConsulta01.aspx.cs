using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AppUnisimon
{
    public partial class AppConsulta01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Conexion con Base De Datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename= c:\users\lab104bpc8\documents\visual studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185032.mdf ;Initial Catalog=aspnet-AppUnisimon-20150423185032;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand = "INSERT INTO Usuarios(nombre, apellido, edad, correo) VALUES ('Maggie', 'Simpsons', 45, 'Maggie_simpsons@hotmail.com')";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}
