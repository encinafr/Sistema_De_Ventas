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
    public partial class Consulta : FormBase
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public DataSet LlenarDataDV(string table)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + table);

            DS = Utilidades.Ejecutar(cmd);

            return DS;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
