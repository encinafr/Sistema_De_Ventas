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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarArticulos'{0}','{1}','{2}'",
                        txtBoxIdPro.Text.Trim(), txtBoxDesc.Text.Trim(), txtBoxPrecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
                return false;
            
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtBoxIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtBoxDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
