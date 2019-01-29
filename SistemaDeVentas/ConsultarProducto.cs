using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class ConsultarProducto : Consulta
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                string cmd = string.Format("SELECT * FROM Articulo WHERE Nom_pro LIKE('%" + textBox1.Text.Trim() + "%')");
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataDV("Articulo").Tables[0];
        }
    }
}
