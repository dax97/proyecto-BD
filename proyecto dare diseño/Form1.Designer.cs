namespace proyecto_dare_diseño
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.validar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.Nusuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validar
            // 
            this.validar.Location = new System.Drawing.Point(173, 227);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(75, 23);
            this.validar.TabIndex = 0;
            this.validar.Text = "Validar";
            this.validar.UseVisualStyleBackColor = true;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(173, 101);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(173, 157);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 22);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(170, 68);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(57, 17);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Location = new System.Drawing.Point(170, 137);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(81, 17);
            this.contraseña.TabIndex = 4;
            this.contraseña.Text = "Contraseña";
            // 
            // Nusuario
            // 
            this.Nusuario.Location = new System.Drawing.Point(23, 214);
            this.Nusuario.Name = "Nusuario";
            this.Nusuario.Size = new System.Drawing.Size(99, 49);
            this.Nusuario.TabIndex = 5;
            this.Nusuario.Text = "administrar usuarios";
            this.Nusuario.UseVisualStyleBackColor = true;
            this.Nusuario.Click += new System.EventHandler(this.Nusuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 288);
            this.Controls.Add(this.Nusuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.validar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button Nusuario;
    }
}

