namespace proyecto_dare_diseño
{
    partial class mainmenu
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
            this.inventario = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.Button();
            this.compras = new System.Windows.Forms.Button();
            this.desconectarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventario
            // 
            this.inventario.Location = new System.Drawing.Point(109, 73);
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(136, 49);
            this.inventario.TabIndex = 0;
            this.inventario.Text = "inventario";
            this.inventario.UseVisualStyleBackColor = true;
            this.inventario.Click += new System.EventHandler(this.inventario_Click);
            // 
            // ventas
            // 
            this.ventas.Location = new System.Drawing.Point(321, 73);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(143, 49);
            this.ventas.TabIndex = 1;
            this.ventas.Text = "ventas";
            this.ventas.UseVisualStyleBackColor = true;
            // 
            // compras
            // 
            this.compras.Location = new System.Drawing.Point(531, 73);
            this.compras.Name = "compras";
            this.compras.Size = new System.Drawing.Size(115, 49);
            this.compras.TabIndex = 2;
            this.compras.Text = "compras";
            this.compras.UseVisualStyleBackColor = true;
            // 
            // desconectarse
            // 
            this.desconectarse.Location = new System.Drawing.Point(316, 267);
            this.desconectarse.Name = "desconectarse";
            this.desconectarse.Size = new System.Drawing.Size(148, 55);
            this.desconectarse.TabIndex = 3;
            this.desconectarse.Text = "desconectarse";
            this.desconectarse.UseVisualStyleBackColor = true;
            this.desconectarse.Click += new System.EventHandler(this.desconectarse_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desconectarse);
            this.Controls.Add(this.compras);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.inventario);
            this.Name = "mainmenu";
            this.Text = "mainmenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventario;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button compras;
        private System.Windows.Forms.Button desconectarse;
    }
}