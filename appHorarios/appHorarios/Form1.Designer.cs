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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHoraSalida = new System.Windows.Forms.TextBox();
            this.textBoxDescanso = new System.Windows.Forms.TextBox();
            this.textBoxHoraEntrada = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelHoraSalida = new System.Windows.Forms.Label();
            this.labelDescanso = new System.Windows.Forms.Label();
            this.labelHoraEntrada = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.btnNuevoHabilitar = new System.Windows.Forms.Button();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(510, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNuevo
            // 
            this.tabNuevo.Controls.Add(this.buttonCancelar);
            this.tabNuevo.Controls.Add(this.panel1);
            this.tabNuevo.Controls.Add(this.btnNuevoHabilitar);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(502, 312);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nuevo registro";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Location = new System.Drawing.Point(191, 274);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 32);
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
            this.panel1.Controls.Add(this.textBoxHoraSalida);
            this.panel1.Controls.Add(this.textBoxDescanso);
            this.panel1.Controls.Add(this.textBoxHoraEntrada);
            this.panel1.Controls.Add(this.dtpFechaRegistro);
            this.panel1.Controls.Add(this.labelHoraSalida);
            this.panel1.Controls.Add(this.labelDescanso);
            this.panel1.Controls.Add(this.labelHoraEntrada);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 224);
            this.panel1.TabIndex = 1;
            // 
            // textBoxHoraSalida
            // 
            this.textBoxHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHoraSalida.Enabled = false;
            this.textBoxHoraSalida.Location = new System.Drawing.Point(211, 135);
            this.textBoxHoraSalida.Name = "textBoxHoraSalida";
            this.textBoxHoraSalida.Size = new System.Drawing.Size(227, 20);
            this.textBoxHoraSalida.TabIndex = 7;
            // 
            // textBoxDescanso
            // 
            this.textBoxDescanso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescanso.Enabled = false;
            this.textBoxDescanso.Location = new System.Drawing.Point(211, 100);
            this.textBoxDescanso.Name = "textBoxDescanso";
            this.textBoxDescanso.Size = new System.Drawing.Size(227, 20);
            this.textBoxDescanso.TabIndex = 6;
            // 
            // textBoxHoraEntrada
            // 
            this.textBoxHoraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHoraEntrada.Enabled = false;
            this.textBoxHoraEntrada.Location = new System.Drawing.Point(211, 64);
            this.textBoxHoraEntrada.Name = "textBoxHoraEntrada";
            this.textBoxHoraEntrada.Size = new System.Drawing.Size(227, 20);
            this.textBoxHoraEntrada.TabIndex = 5;
            this.textBoxHoraEntrada.Tag = "";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(211, 23);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(227, 20);
            this.dtpFechaRegistro.TabIndex = 4;
            // 
            // labelHoraSalida
            // 
            this.labelHoraSalida.AutoSize = true;
            this.labelHoraSalida.Location = new System.Drawing.Point(34, 138);
            this.labelHoraSalida.Name = "labelHoraSalida";
            this.labelHoraSalida.Size = new System.Drawing.Size(86, 13);
            this.labelHoraSalida.TabIndex = 3;
            this.labelHoraSalida.Text = "Horario de salida";
            // 
            // labelDescanso
            // 
            this.labelDescanso.AutoSize = true;
            this.labelDescanso.Location = new System.Drawing.Point(32, 103);
            this.labelDescanso.Name = "labelDescanso";
            this.labelDescanso.Size = new System.Drawing.Size(106, 13);
            this.labelDescanso.TabIndex = 2;
            this.labelDescanso.Text = "Tiempo de descanso";
            // 
            // labelHoraEntrada
            // 
            this.labelHoraEntrada.AutoSize = true;
            this.labelHoraEntrada.Location = new System.Drawing.Point(32, 67);
            this.labelHoraEntrada.Name = "labelHoraEntrada";
            this.labelHoraEntrada.Size = new System.Drawing.Size(95, 13);
            this.labelHoraEntrada.TabIndex = 1;
            this.labelHoraEntrada.Text = "Horario de entrada";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(34, 29);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // btnNuevoHabilitar
            // 
            this.btnNuevoHabilitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoHabilitar.Location = new System.Drawing.Point(191, 6);
            this.btnNuevoHabilitar.Name = "btnNuevoHabilitar";
            this.btnNuevoHabilitar.Size = new System.Drawing.Size(120, 32);
            this.btnNuevoHabilitar.TabIndex = 0;
            this.btnNuevoHabilitar.Text = "Nuevo";
            this.btnNuevoHabilitar.UseVisualStyleBackColor = true;
            this.btnNuevoHabilitar.Click += new System.EventHandler(this.btnNuevoHabilitar_Click);
            this.btnNuevoHabilitar.MouseEnter += new System.EventHandler(this.btnNuevoHabilitar_MouseEnter);
            this.btnNuevoHabilitar.MouseLeave += new System.EventHandler(this.btnNuevoHabilitar_MouseLeave);
            // 
            // tabListado
            // 
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(502, 312);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Ver registros";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Size = new System.Drawing.Size(502, 312);
            this.tabEstadisticas.TabIndex = 2;
            this.tabEstadisticas.Text = "Estadísticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
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
            this.ClientSize = new System.Drawing.Size(534, 392);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(540, 430);
            this.Name = "Form1";
            this.Text = "Control de horarios";
            this.tabControl1.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxHoraSalida;
        private System.Windows.Forms.TextBox textBoxDescanso;
        private System.Windows.Forms.TextBox textBoxHoraEntrada;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonCancelar;



    }
}

