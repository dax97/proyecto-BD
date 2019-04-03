namespace proyecto_dare_diseño
{
    partial class almacen_Dare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(almacen_Dare));
            this.searchdata = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.generarPDF = new System.Windows.Forms.Button();
            this.alta = new System.Windows.Forms.Button();
            this.baja = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // searchdata
            // 
            this.searchdata.Location = new System.Drawing.Point(283, 213);
            this.searchdata.Name = "searchdata";
            this.searchdata.Size = new System.Drawing.Size(270, 22);
            this.searchdata.TabIndex = 0;
            this.searchdata.TextChanged += new System.EventHandler(this.searchdata_TextChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(574, 212);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(149, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // generarPDF
            // 
            this.generarPDF.Location = new System.Drawing.Point(658, 490);
            this.generarPDF.Name = "generarPDF";
            this.generarPDF.Size = new System.Drawing.Size(145, 43);
            this.generarPDF.TabIndex = 3;
            this.generarPDF.Text = "generar pdf";
            this.generarPDF.UseVisualStyleBackColor = true;
            this.generarPDF.Click += new System.EventHandler(this.generarPDF_Click);
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(361, 490);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(75, 23);
            this.alta.TabIndex = 6;
            this.alta.Text = "alta";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(493, 490);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(75, 23);
            this.baja.TabIndex = 7;
            this.baja.Text = "baja";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // panel
            // 
            this.panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel.Location = new System.Drawing.Point(12, 262);
            this.panel.Name = "panel";
            this.panel.RowTemplate.Height = 24;
            this.panel.Size = new System.Drawing.Size(824, 173);
            this.panel.TabIndex = 8;
            this.panel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panel_CellContentClick);
            // 
            // almacen_Dare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 545);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.alta);
            this.Controls.Add(this.generarPDF);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.searchdata);
            this.Name = "almacen_Dare";
            this.Text = "almacen_Dare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.almacen_Dare_FormClosed);
            this.Load += new System.EventHandler(this.almacen_Dare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchdata;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button generarPDF;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.DataGridView panel;
    }
}