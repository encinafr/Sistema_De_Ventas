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
    public partial class ConsultarCliente : Consulta
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataDV("Cliente").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim())==false)
            {
                try
                {
                    DataSet ds;
                    string cmd = string.Format("SELECT * FROM CLIENTE WHERE Nom_cli LIKE('%" + textBox1.Text.Trim() + "%')");
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }
    }
}
