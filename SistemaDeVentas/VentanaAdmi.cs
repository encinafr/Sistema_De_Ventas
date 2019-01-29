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
    public partial class VentanaAdmi: FormBase
    {
        public VentanaAdmi()
        {
            InitializeComponent();
        }

        private void VentanaAdmi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmi_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.codigo;
            DataSet dataSet = Utilidades.Ejecutar(cmd);
            lbl_Admi.Text = dataSet.Tables[0].Rows[0]["Nombre_usu"].ToString();
            Lbl_Usuario.Text = dataSet.Tables[0].Rows[0]["account"].ToString();
            Lbl_Codigo.Text = dataSet.Tables[0].Rows[0]["id_usuario"].ToString();
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
