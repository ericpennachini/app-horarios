namespace appHorarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Item 4");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Item N");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Item N");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTiempoDescanso = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelHoraSalida = new System.Windows.Forms.Label();
            this.labelDescanso = new System.Windows.Forms.Label();
            this.labelHoraEntrada = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.btnNuevoHabilitar = new System.Windows.Forms.Button();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabListado.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabNuevo);
            this.tabControl1.Controls.Add(this.tabListado);
            this.tabControl1.Controls.Add(this.tabEstadisticas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNuevo
            // 
            this.tabNuevo.Controls.Add(this.buttonGuardar);
            this.tabNuevo.Controls.Add(this.buttonCancelar);
            this.tabNuevo.Controls.Add(this.panel1);
            this.tabNuevo.Controls.Add(this.btnNuevoHabilitar);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(502, 335);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nuevo registro";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(250, 282);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 47);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.Location = new System.Drawing.Point(376, 282);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dtpTiempoDescanso);
            this.panel1.Controls.Add(this.dtpHoraSalida);
            this.panel1.Controls.Add(this.dtpHoraEntrada);
            this.panel1.Controls.Add(this.textBoxComentarios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaRegistro);
            this.panel1.Controls.Add(this.labelHoraSalida);
            this.panel1.Controls.Add(this.labelDescanso);
            this.panel1.Controls.Add(this.labelHoraEntrada);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Location = new System.Drawing.Point(6, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 217);
            this.panel1.TabIndex = 1;
            // 
            // dtpTiempoDescanso
            // 
            this.dtpTiempoDescanso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTiempoDescanso.Enabled = false;
            this.dtpTiempoDescanso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTiempoDescanso.Location = new System.Drawing.Point(211, 117);
            this.dtpTiempoDescanso.Name = "dtpTiempoDescanso";
            this.dtpTiempoDescanso.Size = new System.Drawing.Size(227, 20);
            this.dtpTiempoDescanso.TabIndex = 13;
            this.dtpTiempoDescanso.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHoraSalida.Enabled = false;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(211, 91);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(227, 20);
            this.dtpHoraSalida.TabIndex = 12;
            this.dtpHoraSalida.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(211, 65);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(227, 20);
            this.dtpHoraEntrada.TabIndex = 11;
            this.dtpHoraEntrada.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComentarios.Enabled = false;
            this.textBoxComentarios.Location = new System.Drawing.Point(211, 146);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.Size = new System.Drawing.Size(227, 53);
            this.textBoxComentarios.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Observaciones";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaRegistro.CustomFormat = "";
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(211, 27);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(227, 20);
            this.dtpFechaRegistro.TabIndex = 1;
            // 
            // labelHoraSalida
            // 
            this.labelHoraSalida.AutoSize = true;
            this.labelHoraSalida.Location = new System.Drawing.Point(32, 97);
            this.labelHoraSalida.Name = "labelHoraSalida";
            this.labelHoraSalida.Size = new System.Drawing.Size(86, 13);
            this.labelHoraSalida.TabIndex = 3;
            this.labelHoraSalida.Text = "Horario de salida";
            // 
            // labelDescanso
            // 
            this.labelDescanso.AutoSize = true;
            this.labelDescanso.Location = new System.Drawing.Point(32, 123);
            this.labelDescanso.Name = "labelDescanso";
            this.labelDescanso.Size = new System.Drawing.Size(106, 13);
            this.labelDescanso.TabIndex = 2;
            this.labelDescanso.Text = "Tiempo de descanso";
            // 
            // labelHoraEntrada
            // 
            this.labelHoraEntrada.AutoSize = true;
            this.labelHoraEntrada.Location = new System.Drawing.Point(32, 71);
            this.labelHoraEntrada.Name = "labelHoraEntrada";
            this.labelHoraEntrada.Size = new System.Drawing.Size(95, 13);
            this.labelHoraEntrada.TabIndex = 1;
            this.labelHoraEntrada.Text = "Horario de entrada";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(32, 33);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // btnNuevoHabilitar
            // 
            this.btnNuevoHabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoHabilitar.Image")));
            this.btnNuevoHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoHabilitar.Location = new System.Drawing.Point(6, 6);
            this.btnNuevoHabilitar.Name = "btnNuevoHabilitar";
            this.btnNuevoHabilitar.Size = new System.Drawing.Size(120, 47);
            this.btnNuevoHabilitar.TabIndex = 0;
            this.btnNuevoHabilitar.Text = "Nuevo";
            this.btnNuevoHabilitar.UseVisualStyleBackColor = true;
            this.btnNuevoHabilitar.Click += new System.EventHandler(this.btnNuevoHabilitar_Click);
            this.btnNuevoHabilitar.MouseEnter += new System.EventHandler(this.btnNuevoHabilitar_MouseEnter);
            this.btnNuevoHabilitar.MouseLeave += new System.EventHandler(this.btnNuevoHabilitar_MouseLeave);
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.listView1);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(502, 335);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Ver registros";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.StateImageIndex = 0;
            listViewItem20.StateImageIndex = 0;
            listViewItem21.StateImageIndex = 0;
            listViewItem22.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22});
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 323);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Size = new System.Drawing.Size(502, 335);
            this.tabEstadisticas.TabIndex = 2;
            this.tabEstadisticas.Text = "Estadísticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(550, 460);
            this.Name = "Form1";
            this.Text = "Control de horarios";
            this.tabControl1.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.Button btnNuevoHabilitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHoraSalida;
        private System.Windows.Forms.Label labelDescanso;
        private System.Windows.Forms.Label labelHoraEntrada;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.DateTimePicker dtpTiempoDescanso;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
    }
}

