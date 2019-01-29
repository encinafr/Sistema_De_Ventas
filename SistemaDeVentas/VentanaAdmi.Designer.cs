namespace SistemaDeVentas
{
    partial class VentanaAdmi
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
            this.LblAdmi = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lbl_Admi = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAdmiUsuarios = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(397, 261);
            this.btnSalir.Size = new System.Drawing.Size(276, 40);
            // 
            // LblAdmi
            // 
            this.LblAdmi.AutoSize = true;
            this.LblAdmi.Location = new System.Drawing.Point(51, 47);
            this.LblAdmi.Name = "LblAdmi";
            this.LblAdmi.Size = new System.Drawing.Size(30, 13);
            this.LblAdmi.TabIndex = 0;
            this.LblAdmi.Text = "Admi";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(51, 95);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(51, 154);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lbl_Admi
            // 
            this.lbl_Admi.AutoEllipsis = true;
            this.lbl_Admi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Admi.Location = new System.Drawing.Point(147, 33);
            this.lbl_Admi.Name = "lbl_Admi";
            this.lbl_Admi.Size = new System.Drawing.Size(171, 40);
            this.lbl_Admi.TabIndex = 3;
            this.lbl_Admi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Usuario.Location = new System.Drawing.Point(147, 87);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(171, 45);
            this.Lbl_Usuario.TabIndex = 4;
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo.Location = new System.Drawing.Point(147, 148);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(171, 40);
            this.Lbl_Codigo.TabIndex = 5;
            this.Lbl_Codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(397, 24);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(276, 48);
            this.btnMenuPrincipal.TabIndex = 6;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnAdmiUsuarios
            // 
            this.btnAdmiUsuarios.Location = new System.Drawing.Point(397, 86);
            this.btnAdmiUsuarios.Name = "btnAdmiUsuarios";
            this.btnAdmiUsuarios.Size = new System.Drawing.Size(276, 44);
            this.btnAdmiUsuarios.TabIndex = 7;
            this.btnAdmiUsuarios.Text = "Administrar Usuarios";
            this.btnAdmiUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(397, 147);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(276, 38);
            this.btnCambiarContraseña.TabIndex = 8;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(397, 202);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(276, 40);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnAdmiUsuarios);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.lbl_Admi);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblAdmi);
            this.Name = "VentanaAdmi";
            this.Text = "VentanaAdmi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaAdmi_FormClosed);
            this.Load += new System.EventHandler(this.VentanaAdmi_Load);
            this.Controls.SetChildIndex(this.LblAdmi, 0);
            this.Controls.SetChildIndex(this.LblUsuario, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lbl_Admi, 0);
            this.Controls.SetChildIndex(this.Lbl_Usuario, 0);
            this.Controls.SetChildIndex(this.Lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.btnMenuPrincipal, 0);
            this.Controls.SetChildIndex(this.btnAdmiUsuarios, 0);
            this.Controls.SetChildIndex(this.btnCambiarContraseña, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdmi;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lbl_Admi;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnAdmiUsuarios;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}