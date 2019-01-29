using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Entidades
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection sqlconexion = new SqlConnection(Properties.Settings.Default.Conexion);//Me devuelve la cadena de conexion
            sqlconexion.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd, sqlconexion);
            da.Fill(ds);
            sqlconexion.Close();

            return ds;
        }

        public static bool ValidarFormulario(Control obj, ErrorProvider errorProvider)
        {
            bool error = false;
            foreach (Control item in obj.Controls)
            {
                if (item is ErrorTxtBox)
                {
                    ErrorTxtBox errorTxtBox = (ErrorTxtBox)item;
                    if (errorTxtBox.Validar == true)
                    {
                        if (string.IsNullOrEmpty(errorTxtBox.Text.Trim()))
                        {
                            errorProvider.SetError(errorTxtBox, "Este campo no puede estar vacio");
                            error = true;
                        }
                    }
                    else
                    {
                        errorProvider.SetError(errorTxtBox, "");
                    }
                }
            }
            return error;
        }
    }

   
}
