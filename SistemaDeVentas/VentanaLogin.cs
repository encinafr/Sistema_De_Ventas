using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;

namespace SistemaDeVentas
{
    public partial class VentanaLogin : FormBase
    {
        public static string codigo = "";
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'",
                                           txtAccout.Text.Trim(), txtPassword.Text.Trim());
                DataSet dataSet = Utilidades.Ejecutar(CMD);

                codigo = dataSet.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                string cuenta = dataSet.Tables[0].Rows[0]["account"].ToString().Trim();
                string passw = dataSet.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == txtAccout.Text.Trim() && passw == txtPassword.Text.Trim())
                {
                    if (Convert.ToBoolean(dataSet.Tables[0].Rows[0]["Status_admi"]))
                    {
                        VentanaAdmi ventanaAdmi = new VentanaAdmi();
                        this.Hide();
                        ventanaAdmi.Show();
                    }
                    else
                    {
                        VentanaUser ventanaUsu = new VentanaUser();
                        this.Hide();
                        ventanaUsu.Show();
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
           
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
