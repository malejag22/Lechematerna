namespace Lechematerna2
{
    partial class FrmIniciarPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bttonIngresarprograma = new System.Windows.Forms.Button();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.pctrHospital = new System.Windows.Forms.PictureBox();
            this.tlIniciar = new System.Windows.Forms.ToolTip(this.components);
            this.rrrPrvdrIniciar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrrPrvdrIniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // bttonIngresarprograma
            // 
            this.bttonIngresarprograma.BackColor = System.Drawing.Color.Khaki;
            this.bttonIngresarprograma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonIngresarprograma.Location = new System.Drawing.Point(139, 195);
            this.bttonIngresarprograma.Name = "bttonIngresarprograma";
            this.bttonIngresarprograma.Size = new System.Drawing.Size(86, 40);
            this.bttonIngresarprograma.TabIndex = 4;
            this.bttonIngresarprograma.Text = "Ingresar ";
            this.tlIniciar.SetToolTip(this.bttonIngresarprograma, "Pulsa para iniciar el programa");
            this.bttonIngresarprograma.UseVisualStyleBackColor = false;
            this.bttonIngresarprograma.Click += new System.EventHandler(this.buttonIngresarprograma_Click);
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(78, 153);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.Size = new System.Drawing.Size(204, 20);
            this.tbxContraseña.TabIndex = 3;
            this.tlIniciar.SetToolTip(this.tbxContraseña, "Ingresa la contraseña");
            this.tbxContraseña.UseSystemPasswordChar = true;
            this.tbxContraseña.TextChanged += new System.EventHandler(this.tbxContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(123, 114);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(120, 22);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña ";
            this.tlIniciar.SetToolTip(this.lblContraseña, "Contraseña");
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(140, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario ";
            this.tlIniciar.SetToolTip(this.lblUsuario, "Usuario");
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(78, 58);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(204, 20);
            this.txbUsuario.TabIndex = 1;
            this.tlIniciar.SetToolTip(this.txbUsuario, "Ingresa el usuario");
            this.txbUsuario.TextChanged += new System.EventHandler(this.UsuarioTxb_TextChanged);
            // 
            // pctrHospital
            // 
            this.pctrHospital.Image = global::Lechematerna2.Properties.Resources.descarga;
            this.pctrHospital.Location = new System.Drawing.Point(11, 253);
            this.pctrHospital.Margin = new System.Windows.Forms.Padding(2);
            this.pctrHospital.Name = "pctrHospital";
            this.pctrHospital.Size = new System.Drawing.Size(346, 146);
            this.pctrHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrHospital.TabIndex = 10;
            this.pctrHospital.TabStop = false;
            this.tlIniciar.SetToolTip(this.pctrHospital, "Logo Hospital General de Medellín");
            // 
            // rrrPrvdrIniciar
            // 
            this.rrrPrvdrIniciar.ContainerControl = this;
            // 
            // FrmIniciarPrograma
            // 
            this.AcceptButton = this.bttonIngresarprograma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(383, 407);
            this.Controls.Add(this.pctrHospital);
            this.Controls.Add(this.bttonIngresarprograma);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Name = "FrmIniciarPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Programa ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrrPrvdrIniciar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonIngresarprograma;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.PictureBox pctrHospital;
        private System.Windows.Forms.ToolTip tlIniciar;
        private System.Windows.Forms.ErrorProvider rrrPrvdrIniciar;
    }
}

