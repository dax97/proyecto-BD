namespace proyecto_dare_diseño
{
    partial class NueUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NueUsuario));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.contraBox = new System.Windows.Forms.TextBox();
            this.Nusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarioBox
            // 
            this.usuarioBox.Location = new System.Drawing.Point(143, 61);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(275, 22);
            this.usuarioBox.TabIndex = 2;
            // 
            // contraBox
            // 
            this.contraBox.Location = new System.Drawing.Point(143, 127);
            this.contraBox.Name = "contraBox";
            this.contraBox.Size = new System.Drawing.Size(275, 22);
            this.contraBox.TabIndex = 3;
            this.contraBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraBox_KeyPress);
            // 
            // Nusuario
            // 
            this.Nusuario.AutoSize = true;
            this.Nusuario.Location = new System.Drawing.Point(140, 41);
            this.Nusuario.Name = "Nusuario";
            this.Nusuario.Size = new System.Drawing.Size(55, 17);
            this.Nusuario.TabIndex = 4;
            this.Nusuario.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "contraseña";
            // 
            // confirmBox
            // 
            this.confirmBox.Location = new System.Drawing.Point(143, 177);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(275, 22);
            this.confirmBox.TabIndex = 6;
            this.confirmBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "confirmar contraseña";
            // 
            // NueUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nusuario);
            this.Controls.Add(this.contraBox);
            this.Controls.Add(this.usuarioBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NueUsuario";
            this.Text = "administracion usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.TextBox contraBox;
        private System.Windows.Forms.Label Nusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.Label label1;
    }
}