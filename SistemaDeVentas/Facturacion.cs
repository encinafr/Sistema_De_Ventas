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
    public partial class Facturacion : Procesos
    {
        public static int con_Fila = 0;
        public static double total;

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario=" + VentanaLogin.codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            txtLoAtiendeCli.Text = ds.Tables[0].Rows[0]["Nombre_usu"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("SELECT Nom_cli FROM Cliente WHERE id_clientes='{0}'", txtCodigoCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();
                    txtCodigoPro.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if(Utilidades.ValidarFormulario(this,errorProvider1)==false)
            {
                bool existe = false;
                int num_fila = 0;
                if(con_Fila==0)
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescPro.Text, txtPrecioPro.Text, txtCantidadPro.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[con_Fila].Cells[2].Value) *
                        Convert.ToDouble(dataGridView1.Rows[con_Fila].Cells[3].Value);

                    dataGridView1.Rows[con_Fila].Cells[4].Value = importe;
                    con_Fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if(Convert.ToInt32(fila.Cells[0].Value) == Convert.ToInt32(txtCodigoPro.Text))
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }

                    if(existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidadPro.Text) +
                            Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();

                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) *
                       Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescPro.Text, txtPrecioPro.Text, txtCantidadPro.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[con_Fila].Cells[2].Value) *
                            Convert.ToDouble(dataGridView1.Rows[con_Fila].Cells[3].Value);

                        dataGridView1.Rows[con_Fila].Cells[4].Value = importe;
                        con_Fila++;
                    }
                }

                total = 0;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                lblTotal.Text = total.ToString() + "$";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {    
            if(con_Fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = total.ToString() + "$";
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                con_Fila--;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente conCli = new ConsultarCliente();
            conCli.ShowDialog();

            if(conCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodigoPro.Focus();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProducto conPro = new ConsultarProducto();
            conPro.ShowDialog();

            if (conPro.DialogResult == DialogResult.OK)
            {
                txtCodigoPro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescPro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecioPro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantidadPro.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           this.Nuevo();
        }

        public override void Nuevo()
        {
            txtCodigoPro.Text = "";
            txtDescPro.Text="";
            txtCantidadPro.Text = "";
            txtCliente.Text = "";
            txtCodigoCli.Text = "";
            txtPrecioPro.Text = "";
            lblTotal.Text = "";
            dataGridView1.Rows.Clear();
            con_Fila = 0;
            total = 0;
            txtCodigoCli.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if(con_Fila !=0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizarFacturas '{0}'", txtCodigoCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string Numfac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        cmd = string.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}'",
                                            Numfac, item.Cells[0].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString());

                        ds = Utilidades.Ejecutar(cmd);
                        
                    }

                    cmd = "Exec DatosFactura " + Numfac;
                    ds = Utilidades.Ejecutar(cmd);
                    //Ventana Reporte

                    Reporte report = new Reporte();
                    report.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];

                    report.ShowDialog();

                    this.Nuevo();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
