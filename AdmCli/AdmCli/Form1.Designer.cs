namespace AdmCli
{
    partial class FormAdmCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmCli));
            this.linkLabelBlog = new System.Windows.Forms.LinkLabel();
            this.linkLabelYoutube = new System.Windows.Forms.LinkLabel();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechNac = new System.Windows.Forms.DateTimePicker();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAp = new System.Windows.Forms.TextBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelFechNac = new System.Windows.Forms.Label();
            this.labelAp = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.toolStripBarra = new System.Windows.Forms.ToolStrip();
            this.tsbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorG = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorB = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorC = new System.Windows.Forms.ToolStripSeparator();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos.SuspendLayout();
            this.toolStripBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBlog
            // 
            this.linkLabelBlog.AutoSize = true;
            this.linkLabelBlog.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBlog.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBlog.Location = new System.Drawing.Point(2, 9);
            this.linkLabelBlog.Name = "linkLabelBlog";
            this.linkLabelBlog.Size = new System.Drawing.Size(73, 20);
            this.linkLabelBlog.TabIndex = 0;
            this.linkLabelBlog.TabStop = true;
            this.linkLabelBlog.Text = "Ir Al Blog";
            // 
            // linkLabelYoutube
            // 
            this.linkLabelYoutube.AutoSize = true;
            this.linkLabelYoutube.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelYoutube.LinkColor = System.Drawing.Color.Black;
            this.linkLabelYoutube.Location = new System.Drawing.Point(594, 9);
            this.linkLabelYoutube.Name = "linkLabelYoutube";
            this.linkLabelYoutube.Size = new System.Drawing.Size(115, 20);
            this.linkLabelYoutube.TabIndex = 1;
            this.linkLabelYoutube.TabStop = true;
            this.linkLabelYoutube.Text = "Canal Youtube";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBoxDatos.Controls.Add(this.textBoxDir);
            this.groupBoxDatos.Controls.Add(this.dateTimePickerFechNac);
            this.groupBoxDatos.Controls.Add(this.textBoxNom);
            this.groupBoxDatos.Controls.Add(this.textBoxAp);
            this.groupBoxDatos.Controls.Add(this.labelDir);
            this.groupBoxDatos.Controls.Add(this.labelFechNac);
            this.groupBoxDatos.Controls.Add(this.labelAp);
            this.groupBoxDatos.Controls.Add(this.labelNom);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatos.Location = new System.Drawing.Point(137, 29);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(425, 200);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Personales";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDir.Location = new System.Drawing.Point(200, 128);
            this.textBoxDir.Multiline = true;
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(200, 40);
            this.textBoxDir.TabIndex = 10;
            // 
            // dateTimePickerFechNac
            // 
            this.dateTimePickerFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechNac.Location = new System.Drawing.Point(200, 95);
            this.dateTimePickerFechNac.Name = "dateTimePickerFechNac";
            this.dateTimePickerFechNac.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechNac.TabIndex = 9;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(200, 37);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 8;
            // 
            // textBoxAp
            // 
            this.textBoxAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAp.Location = new System.Drawing.Point(200, 65);
            this.textBoxAp.Name = "textBoxAp";
            this.textBoxAp.Size = new System.Drawing.Size(200, 20);
            this.textBoxAp.TabIndex = 7;
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.BackColor = System.Drawing.Color.Transparent;
            this.labelDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDir.Location = new System.Drawing.Point(26, 129);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(78, 16);
            this.labelDir.TabIndex = 4;
            this.labelDir.Text = "Dirección:";
            // 
            // labelFechNac
            // 
            this.labelFechNac.AutoSize = true;
            this.labelFechNac.BackColor = System.Drawing.Color.Transparent;
            this.labelFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechNac.Location = new System.Drawing.Point(26, 99);
            this.labelFechNac.Name = "labelFechNac";
            this.labelFechNac.Size = new System.Drawing.Size(159, 16);
            this.labelFechNac.TabIndex = 3;
            this.labelFechNac.Text = "Fecha de Nacimiento:";
            // 
            // labelAp
            // 
            this.labelAp.AutoSize = true;
            this.labelAp.BackColor = System.Drawing.Color.Transparent;
            this.labelAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAp.Location = new System.Drawing.Point(26, 69);
            this.labelAp.Name = "labelAp";
            this.labelAp.Size = new System.Drawing.Size(70, 16);
            this.labelAp.TabIndex = 1;
            this.labelAp.Text = "Apellido:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(26, 41);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(67, 16);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nombre:";
            // 
            // toolStripBarra
            // 
            this.toolStripBarra.AutoSize = false;
            this.toolStripBarra.BackColor = System.Drawing.Color.OliveDrab;
            this.toolStripBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGuardar,
            this.toolStripSeparatorG,
            this.tsbtnBuscar,
            this.toolStripSeparatorB,
            this.tsbtnCancelar,
            this.toolStripSeparatorC});
            this.toolStripBarra.Location = new System.Drawing.Point(0, 431);
            this.toolStripBarra.Name = "toolStripBarra";
            this.toolStripBarra.Size = new System.Drawing.Size(709, 30);
            this.toolStripBarra.TabIndex = 3;
            this.toolStripBarra.Text = "toolStrip1";
            // 
            // tsbtnGuardar
            // 
            this.tsbtnGuardar.AutoSize = false;
            this.tsbtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnGuardar.Image = global::AdmCli.Properties.Resources.Save_37110;
            this.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGuardar.Name = "tsbtnGuardar";
            this.tsbtnGuardar.Size = new System.Drawing.Size(74, 27);
            this.tsbtnGuardar.Text = "&Guardar";
            this.tsbtnGuardar.Click += new System.EventHandler(this.tsbtnGuardar_Click);
            // 
            // toolStripSeparatorG
            // 
            this.toolStripSeparatorG.Name = "toolStripSeparatorG";
            this.toolStripSeparatorG.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnBuscar
            // 
            this.tsbtnBuscar.AutoSize = false;
            this.tsbtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnBuscar.Image = global::AdmCli.Properties.Resources.xmag_search_find_export_locate_5984;
            this.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBuscar.Name = "tsbtnBuscar";
            this.tsbtnBuscar.Size = new System.Drawing.Size(74, 27);
            this.tsbtnBuscar.Text = "&Buscar";
            this.tsbtnBuscar.Click += new System.EventHandler(this.tsbtnBuscar_Click);
            // 
            // toolStripSeparatorB
            // 
            this.toolStripSeparatorB.Name = "toolStripSeparatorB";
            this.toolStripSeparatorB.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCancelar.Image = global::AdmCli.Properties.Resources.cancel_stop_exit_1583;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(74, 27);
            this.tsbtnCancelar.Text = "&Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // toolStripSeparatorC
            // 
            this.toolStripSeparatorC.Name = "toolStripSeparatorC";
            this.toolStripSeparatorC.Size = new System.Drawing.Size(6, 30);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(137, 254);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(425, 150);
            this.dgvBuscar.TabIndex = 4;
            this.dgvBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellClick);
            // 
            // FormAdmCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdmCli.Properties.Resources.Abstract_Wallpaper_Background_Computers_Windows_2zyemowh9qrdjkq7p4cv0q;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.toolStripBarra);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.linkLabelYoutube);
            this.Controls.Add(this.linkLabelBlog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmCli";
            this.Text = "Administración de Clientes";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.toolStripBarra.ResumeLayout(false);
            this.toolStripBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBlog;
        private System.Windows.Forms.LinkLabel linkLabelYoutube;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label labelFechNac;
        private System.Windows.Forms.Label labelAp;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAp;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechNac;
        private System.Windows.Forms.ToolStrip toolStripBarra;
        private System.Windows.Forms.ToolStripButton tsbtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorG;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.ToolStripButton tsbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorB;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorC;
    }
}

