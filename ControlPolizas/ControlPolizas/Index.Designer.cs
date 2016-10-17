namespace ControlPolizas
{
    partial class FrmIndex
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compañíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.primasNuevasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalirIndex = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecibosPorVencer = new System.Windows.Forms.DataGridView();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.dgvCumpleaños = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgente = new System.Windows.Forms.Button();
            this.btnPoliza = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibosPorVencer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleaños)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.polizaToolStripMenuItem,
            this.agenteToolStripMenuItem,
            this.compañíaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.polizaToolStripMenuItem.Text = "Poliza";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // agenteToolStripMenuItem
            // 
            this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            this.agenteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.agenteToolStripMenuItem.Text = "Agente";
            this.agenteToolStripMenuItem.Click += new System.EventHandler(this.agenteToolStripMenuItem_Click);
            // 
            // compañíaToolStripMenuItem
            // 
            this.compañíaToolStripMenuItem.Name = "compañíaToolStripMenuItem";
            this.compañíaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.compañíaToolStripMenuItem.Text = "Compañía";
            this.compañíaToolStripMenuItem.Click += new System.EventHandler(this.compañíaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polizaToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // polizaToolStripMenuItem1
            // 
            this.polizaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primasNuevasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vigenciasToolStripMenuItem});
            this.polizaToolStripMenuItem1.Name = "polizaToolStripMenuItem1";
            this.polizaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.polizaToolStripMenuItem1.Text = "Polizas";
            this.polizaToolStripMenuItem1.Click += new System.EventHandler(this.polizaToolStripMenuItem1_Click);
            // 
            // primasNuevasToolStripMenuItem
            // 
            this.primasNuevasToolStripMenuItem.Name = "primasNuevasToolStripMenuItem";
            this.primasNuevasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.primasNuevasToolStripMenuItem.Text = "Primas acumuladas";
            this.primasNuevasToolStripMenuItem.Click += new System.EventHandler(this.primasNuevasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vigenciasToolStripMenuItem
            // 
            this.vigenciasToolStripMenuItem.Name = "vigenciasToolStripMenuItem";
            this.vigenciasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.vigenciasToolStripMenuItem.Text = "Vigencias";
            this.vigenciasToolStripMenuItem.Click += new System.EventHandler(this.vigenciasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // btnSalirIndex
            // 
            this.btnSalirIndex.Location = new System.Drawing.Point(847, 390);
            this.btnSalirIndex.Name = "btnSalirIndex";
            this.btnSalirIndex.Size = new System.Drawing.Size(75, 23);
            this.btnSalirIndex.TabIndex = 7;
            this.btnSalirIndex.Text = "Salir";
            this.btnSalirIndex.UseVisualStyleBackColor = true;
            this.btnSalirIndex.Click += new System.EventHandler(this.btnSalirIndex_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvRecibosPorVencer);
            this.groupBox1.Controls.Add(this.dgvPendientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(128, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 357);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Vencer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(221, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recibos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pólizas";
            // 
            // dgvRecibosPorVencer
            // 
            this.dgvRecibosPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibosPorVencer.Location = new System.Drawing.Point(6, 204);
            this.dgvRecibosPorVencer.Name = "dgvRecibosPorVencer";
            this.dgvRecibosPorVencer.Size = new System.Drawing.Size(529, 137);
            this.dgvRecibosPorVencer.TabIndex = 1;
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Location = new System.Drawing.Point(6, 44);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(529, 137);
            this.dgvPendientes.TabIndex = 0;
            this.dgvPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvCumpleaños
            // 
            this.dgvCumpleaños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCumpleaños.Location = new System.Drawing.Point(699, 71);
            this.dgvCumpleaños.Name = "dgvCumpleaños";
            this.dgvCumpleaños.Size = new System.Drawing.Size(223, 297);
            this.dgvCumpleaños.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(753, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cumpleaños de:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::ControlPolizas.Properties.Resources.people_1;
            this.button1.Location = new System.Drawing.Point(26, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Compañias");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgente
            // 
            this.btnAgente.AutoSize = true;
            this.btnAgente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgente.Image = global::ControlPolizas.Properties.Resources.businessman;
            this.btnAgente.Location = new System.Drawing.Point(26, 205);
            this.btnAgente.Name = "btnAgente";
            this.btnAgente.Size = new System.Drawing.Size(70, 70);
            this.btnAgente.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAgente, "Agentes");
            this.btnAgente.UseVisualStyleBackColor = false;
            this.btnAgente.Click += new System.EventHandler(this.btnAgente_Click);
            // 
            // btnPoliza
            // 
            this.btnPoliza.AutoSize = true;
            this.btnPoliza.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPoliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoliza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoliza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoliza.Image = global::ControlPolizas.Properties.Resources.business;
            this.btnPoliza.Location = new System.Drawing.Point(26, 114);
            this.btnPoliza.Name = "btnPoliza";
            this.btnPoliza.Size = new System.Drawing.Size(70, 70);
            this.btnPoliza.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPoliza, "Polizas");
            this.btnPoliza.UseVisualStyleBackColor = false;
            this.btnPoliza.Click += new System.EventHandler(this.btnPoliza_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.AutoSize = true;
            this.BtnCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCliente.Image = global::ControlPolizas.Properties.Resources.people1;
            this.BtnCliente.Location = new System.Drawing.Point(26, 27);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(70, 70);
            this.BtnCliente.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BtnCliente, "Clientes");
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCumpleaños);
            this.Controls.Add(this.btnSalirIndex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgente);
            this.Controls.Add(this.btnPoliza);
            this.Controls.Add(this.BtnCliente);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de polizas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibosPorVencer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleaños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPoliza;
        private System.Windows.Forms.Button btnAgente;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem compañíaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalirIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.ToolStripMenuItem primasNuevasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigenciasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvRecibosPorVencer;
        public System.Windows.Forms.DataGridView dgvCumpleaños;
        private System.Windows.Forms.Label label3;
    }
}

