namespace SistemaDeVentas
{
    partial class MantenimientoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxApeCLi = new System.Windows.Forms.TextBox();
            this.txtBoxNomCLi = new System.Windows.Forms.TextBox();
            this.txtBoxIdCli = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(431, 24);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(431, 77);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(431, 130);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(431, 197);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(431, 258);
            this.btnSalir.Size = new System.Drawing.Size(136, 27);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Cliente";
            // 
            // txtBoxApeCLi
            // 
            this.txtBoxApeCLi.Location = new System.Drawing.Point(174, 175);
            this.txtBoxApeCLi.Name = "txtBoxApeCLi";
            this.txtBoxApeCLi.Size = new System.Drawing.Size(167, 20);
            this.txtBoxApeCLi.TabIndex = 13;
            // 
            // txtBoxNomCLi
            // 
            this.txtBoxNomCLi.Location = new System.Drawing.Point(174, 113);
            this.txtBoxNomCLi.Name = "txtBoxNomCLi";
            this.txtBoxNomCLi.Size = new System.Drawing.Size(167, 20);
            this.txtBoxNomCLi.TabIndex = 12;
            // 
            // txtBoxIdCli
            // 
            this.txtBoxIdCli.Location = new System.Drawing.Point(174, 51);
            this.txtBoxIdCli.Name = "txtBoxIdCli";
            this.txtBoxIdCli.Size = new System.Drawing.Size(167, 20);
            this.txtBoxIdCli.TabIndex = 11;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxApeCLi);
            this.Controls.Add(this.txtBoxNomCLi);
            this.Controls.Add(this.txtBoxIdCli);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txtBoxIdCli, 0);
            this.Controls.SetChildIndex(this.txtBoxNomCLi, 0);
            this.Controls.SetChildIndex(this.txtBoxApeCLi, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxApeCLi;
        private System.Windows.Forms.TextBox txtBoxNomCLi;
        private System.Windows.Forms.TextBox txtBoxIdCli;
    }
}