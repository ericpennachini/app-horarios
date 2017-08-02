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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.labelAlerta = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbHorasTrabajadasDescDetalle = new System.Windows.Forms.TextBox();
            this.tbHorasTrabajadasDetalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbObservacionesDetalle = new System.Windows.Forms.TextBox();
            this.tbTiempoDescDetalle = new System.Windows.Forms.TextBox();
            this.tbHoraSalidaDetalle = new System.Windows.Forms.TextBox();
            this.tbHoraEntradaDetalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.comboBoxMeses = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAvgHoraSalida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAvgHoraEntrada = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAvgDescanso = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAvgHoras2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAvgHoras1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabListado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEstadisticas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabNuevo.Controls.Add(this.labelAlerta);
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
            // labelAlerta
            // 
            this.labelAlerta.BackColor = System.Drawing.Color.DarkRed;
            this.labelAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAlerta.Location = new System.Drawing.Point(180, 25);
            this.labelAlerta.Name = "labelAlerta";
            this.labelAlerta.Size = new System.Drawing.Size(143, 28);
            this.labelAlerta.TabIndex = 9;
            this.labelAlerta.Text = "No permitido";
            this.labelAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAlerta.Visible = false;
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
            this.buttonGuardar.TabIndex = 6;
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
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.checkBox1);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(375, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Invalidar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpTiempoDescanso
            // 
            this.dtpTiempoDescanso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTiempoDescanso.Enabled = false;
            this.dtpTiempoDescanso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTiempoDescanso.Location = new System.Drawing.Point(194, 117);
            this.dtpTiempoDescanso.Name = "dtpTiempoDescanso";
            this.dtpTiempoDescanso.Size = new System.Drawing.Size(170, 20);
            this.dtpTiempoDescanso.TabIndex = 4;
            this.dtpTiempoDescanso.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHoraSalida.Enabled = false;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(194, 91);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(247, 20);
            this.dtpHoraSalida.TabIndex = 3;
            this.dtpHoraSalida.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(194, 65);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(247, 20);
            this.dtpHoraEntrada.TabIndex = 2;
            this.dtpHoraEntrada.Value = new System.DateTime(2017, 7, 25, 0, 0, 0, 0);
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComentarios.Enabled = false;
            this.textBoxComentarios.Location = new System.Drawing.Point(194, 146);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.Size = new System.Drawing.Size(247, 53);
            this.textBoxComentarios.TabIndex = 5;
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
            this.dtpFechaRegistro.Location = new System.Drawing.Point(194, 27);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(247, 20);
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
            // 
            // tabListado
            // 
            this.tabListado.BackColor = System.Drawing.Color.Transparent;
            this.tabListado.Controls.Add(this.groupBox1);
            this.tabListado.Controls.Add(this.listView1);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(502, 335);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Ver registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tbHorasTrabajadasDescDetalle);
            this.groupBox1.Controls.Add(this.tbHorasTrabajadasDetalle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbObservacionesDetalle);
            this.groupBox1.Controls.Add(this.tbTiempoDescDetalle);
            this.groupBox1.Controls.Add(this.tbHoraSalidaDetalle);
            this.groupBox1.Controls.Add(this.tbHoraEntradaDetalle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(248, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(139, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar todo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbHorasTrabajadasDescDetalle
            // 
            this.tbHorasTrabajadasDescDetalle.Location = new System.Drawing.Point(139, 180);
            this.tbHorasTrabajadasDescDetalle.Name = "tbHorasTrabajadasDescDetalle";
            this.tbHorasTrabajadasDescDetalle.ReadOnly = true;
            this.tbHorasTrabajadasDescDetalle.Size = new System.Drawing.Size(103, 20);
            this.tbHorasTrabajadasDescDetalle.TabIndex = 21;
            // 
            // tbHorasTrabajadasDetalle
            // 
            this.tbHorasTrabajadasDetalle.Location = new System.Drawing.Point(9, 180);
            this.tbHorasTrabajadasDetalle.Name = "tbHorasTrabajadasDetalle";
            this.tbHorasTrabajadasDetalle.ReadOnly = true;
            this.tbHorasTrabajadasDetalle.Size = new System.Drawing.Size(103, 20);
            this.tbHorasTrabajadasDetalle.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hs. trabajadas (desc.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hs. trabajadas";
            // 
            // tbObservacionesDetalle
            // 
            this.tbObservacionesDetalle.Location = new System.Drawing.Point(9, 227);
            this.tbObservacionesDetalle.Multiline = true;
            this.tbObservacionesDetalle.Name = "tbObservacionesDetalle";
            this.tbObservacionesDetalle.ReadOnly = true;
            this.tbObservacionesDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservacionesDetalle.Size = new System.Drawing.Size(233, 46);
            this.tbObservacionesDetalle.TabIndex = 17;
            // 
            // tbTiempoDescDetalle
            // 
            this.tbTiempoDescDetalle.Location = new System.Drawing.Point(9, 131);
            this.tbTiempoDescDetalle.Name = "tbTiempoDescDetalle";
            this.tbTiempoDescDetalle.ReadOnly = true;
            this.tbTiempoDescDetalle.Size = new System.Drawing.Size(233, 20);
            this.tbTiempoDescDetalle.TabIndex = 16;
            // 
            // tbHoraSalidaDetalle
            // 
            this.tbHoraSalidaDetalle.Location = new System.Drawing.Point(9, 84);
            this.tbHoraSalidaDetalle.Name = "tbHoraSalidaDetalle";
            this.tbHoraSalidaDetalle.ReadOnly = true;
            this.tbHoraSalidaDetalle.Size = new System.Drawing.Size(233, 20);
            this.tbHoraSalidaDetalle.TabIndex = 15;
            // 
            // tbHoraEntradaDetalle
            // 
            this.tbHoraEntradaDetalle.Location = new System.Drawing.Point(9, 39);
            this.tbHoraEntradaDetalle.Name = "tbHoraEntradaDetalle";
            this.tbHoraEntradaDetalle.ReadOnly = true;
            this.tbHoraEntradaDetalle.Size = new System.Drawing.Size(233, 20);
            this.tbHoraEntradaDetalle.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tiempo de descanso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hora de salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora de entrada";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(235, 323);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Controls.Add(this.comboBoxMeses);
            this.tabEstadisticas.Controls.Add(this.groupBox3);
            this.tabEstadisticas.Controls.Add(this.button2);
            this.tabEstadisticas.Controls.Add(this.groupBox2);
            this.tabEstadisticas.Controls.Add(this.button1);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Size = new System.Drawing.Size(502, 335);
            this.tabEstadisticas.TabIndex = 2;
            this.tabEstadisticas.Text = "Estadísticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // comboBoxMeses
            // 
            this.comboBoxMeses.Enabled = false;
            this.comboBoxMeses.FormattingEnabled = true;
            this.comboBoxMeses.Items.AddRange(new object[] {
            "Mayo 2017",
            "Junio 2017",
            "Julio 2017",
            "Agosto 2017"});
            this.comboBoxMeses.Location = new System.Drawing.Point(387, 93);
            this.comboBoxMeses.Name = "comboBoxMeses";
            this.comboBoxMeses.Size = new System.Drawing.Size(99, 21);
            this.comboBoxMeses.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(387, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mensual";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Totales";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAvgHoraSalida);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.labelAvgHoraEntrada);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelAvgDescanso);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labelAvgHoras2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelAvgHoras1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 324);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // labelAvgHoraSalida
            // 
            this.labelAvgHoraSalida.AutoSize = true;
            this.labelAvgHoraSalida.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgHoraSalida.ForeColor = System.Drawing.Color.Gray;
            this.labelAvgHoraSalida.Location = new System.Drawing.Point(207, 274);
            this.labelAvgHoraSalida.Name = "labelAvgHoraSalida";
            this.labelAvgHoraSalida.Size = new System.Drawing.Size(70, 25);
            this.labelAvgHoraSalida.TabIndex = 16;
            this.labelAvgHoraSalida.Text = "--:--:--";
            this.labelAvgHoraSalida.TextChanged += new System.EventHandler(this.labelAvgHoraSalida_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Horario de salida promedio";
            // 
            // labelAvgHoraEntrada
            // 
            this.labelAvgHoraEntrada.AutoSize = true;
            this.labelAvgHoraEntrada.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgHoraEntrada.ForeColor = System.Drawing.Color.Gray;
            this.labelAvgHoraEntrada.Location = new System.Drawing.Point(6, 274);
            this.labelAvgHoraEntrada.Name = "labelAvgHoraEntrada";
            this.labelAvgHoraEntrada.Size = new System.Drawing.Size(70, 25);
            this.labelAvgHoraEntrada.TabIndex = 14;
            this.labelAvgHoraEntrada.Text = "--:--:--";
            this.labelAvgHoraEntrada.TextChanged += new System.EventHandler(this.labelAvgHoraEntrada_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Horario de entrada promedio";
            // 
            // labelAvgDescanso
            // 
            this.labelAvgDescanso.AutoSize = true;
            this.labelAvgDescanso.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgDescanso.ForeColor = System.Drawing.Color.Gray;
            this.labelAvgDescanso.Location = new System.Drawing.Point(4, 202);
            this.labelAvgDescanso.Name = "labelAvgDescanso";
            this.labelAvgDescanso.Size = new System.Drawing.Size(70, 25);
            this.labelAvgDescanso.TabIndex = 12;
            this.labelAvgDescanso.Text = "--:--:--";
            this.labelAvgDescanso.TextChanged += new System.EventHandler(this.labelAvgDescanso_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tiempo de descanso promedio";
            // 
            // labelAvgHoras2
            // 
            this.labelAvgHoras2.AutoSize = true;
            this.labelAvgHoras2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgHoras2.ForeColor = System.Drawing.Color.Gray;
            this.labelAvgHoras2.Location = new System.Drawing.Point(4, 129);
            this.labelAvgHoras2.Name = "labelAvgHoras2";
            this.labelAvgHoras2.Size = new System.Drawing.Size(70, 25);
            this.labelAvgHoras2.TabIndex = 10;
            this.labelAvgHoras2.Text = "--:--:--";
            this.labelAvgHoras2.TextChanged += new System.EventHandler(this.labelAvgHoras2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Promedio de horas trabajadas (con descansos, por día)";
            // 
            // labelAvgHoras1
            // 
            this.labelAvgHoras1.AutoSize = true;
            this.labelAvgHoras1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgHoras1.ForeColor = System.Drawing.Color.Gray;
            this.labelAvgHoras1.Location = new System.Drawing.Point(6, 53);
            this.labelAvgHoras1.Name = "labelAvgHoras1";
            this.labelAvgHoras1.Size = new System.Drawing.Size(70, 25);
            this.labelAvgHoras1.TabIndex = 8;
            this.labelAvgHoras1.Text = "--:--:--";
            this.labelAvgHoras1.TextChanged += new System.EventHandler(this.labelAvgHoras1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Promedio de horas trabajadas (por día)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
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
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 460);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de horarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEstadisticas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.DateTimePicker dtpTiempoDescanso;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label labelAlerta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbObservacionesDetalle;
        private System.Windows.Forms.TextBox tbTiempoDescDetalle;
        private System.Windows.Forms.TextBox tbHoraSalidaDetalle;
        private System.Windows.Forms.TextBox tbHoraEntradaDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAvgDescanso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAvgHoras2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAvgHoras1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelAvgHoraEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHorasTrabajadasDescDetalle;
        private System.Windows.Forms.TextBox tbHorasTrabajadasDetalle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelAvgHoraSalida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxMeses;
    }
}

