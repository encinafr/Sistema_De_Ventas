using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SistemaDeVentas
{
    public partial class VentanaUser : FormBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.codigo;
            DataSet dataSet = Utilidades.Ejecutar(cmd);
            lblAdmi2.Text = dataSet.Tables[0].Rows[0]["Nombre_usu"].ToString();
            LblUsuario2.Text = dataSet.Tables[0].Rows[0]["account"].ToString();
            LblCodigo2.Text = dataSet.Tables[0].Rows[0]["id_usuario"].ToString();
            string url = dataSet.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedorPrincipal = new ContenedorPrincipal();
            this.Hide();
            contenedorPrincipal.Show();
        }
    }
}
