namespace appHorarios.LiveReg
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnMarcarEntrada = new System.Windows.Forms.Button();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxTotalDescanso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxHorarioAproxSalida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTiempoDescansoCompensado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHorascompensar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMarcarEntrada
            // 
            this.btnMarcarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarEntrada.Location = new System.Drawing.Point(6, 50);
            this.btnMarcarEntrada.Name = "btnMarcarEntrada";
            this.btnMarcarEntrada.Size = new System.Drawing.Size(110, 30);
            this.btnMarcarEntrada.TabIndex = 0;
            this.btnMarcarEntrada.Text = "Marcar entrada";
            this.btnMarcarEntrada.UseVisualStyleBackColor = true;
            this.btnMarcarEntrada.Click += new System.EventHandler(this.btnMarcarEntrada_Click);
            // 
            // btnDescanso
            // 
            this.btnDescanso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescanso.Enabled = false;
            this.btnDescanso.Location = new System.Drawing.Point(137, 50);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(240, 30);
            this.btnDescanso.TabIndex = 1;
            this.btnDescanso.Text = "Inicio/fin últ. descanso";
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // btnMarcarSalida
            // 
            this.btnMarcarSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarSalida.Enabled = false;
            this.btnMarcarSalida.Location = new System.Drawing.Point(399, 50);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Size = new System.Drawing.Size(110, 30);
            this.btnMarcarSalida.TabIndex = 2;
            this.btnMarcarSalida.Text = "Marcar salida";
            this.btnMarcarSalida.UseVisualStyleBackColor = true;
            this.btnMarcarSalida.Click += new System.EventHandler(this.btnMarcarSalida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "--:--:--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(137, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "--:--:--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(248, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "--:--:--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(396, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "--:--:--";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFechaActual.Location = new System.Drawing.Point(12, 13);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(74, 23);
            this.lblFechaActual.TabIndex = 7;
            this.lblFechaActual.Text = "--/--/----";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbxTotalDescanso);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxHorarioAproxSalida);
            this.groupBox1.Controls.Add(this.btnDescanso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMarcarEntrada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnMarcarSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // tbxTotalDescanso
            // 
            this.tbxTotalDescanso.Location = new System.Drawing.Point(104, 103);
            this.tbxTotalDescanso.Name = "tbxTotalDescanso";
            this.tbxTotalDescanso.ReadOnly = true;
            this.tbxTotalDescanso.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalDescanso.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Descanso total";
            // 
            // tbxHorarioAproxSalida
            // 
            this.tbxHorarioAproxSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHorarioAproxSalida.Location = new System.Drawing.Point(383, 103);
            this.tbxHorarioAproxSalida.Name = "tbxHorarioAproxSalida";
            this.tbxHorarioAproxSalida.ReadOnly = true;
            this.tbxHorarioAproxSalida.Size = new System.Drawing.Size(120, 20);
            this.tbxHorarioAproxSalida.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Horario aproximado de salida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTiempoDescansoCompensado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblHorascompensar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lblTiempoDescansoCompensado
            // 
            this.lblTiempoDescansoCompensado.AutoSize = true;
            this.lblTiempoDescansoCompensado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDescansoCompensado.Location = new System.Drawing.Point(142, 100);
            this.lblTiempoDescansoCompensado.Name = "lblTiempoDescansoCompensado";
            this.lblTiempoDescansoCompensado.Size = new System.Drawing.Size(81, 19);
            this.lblTiempoDescansoCompensado.TabIndex = 6;
            this.lblTiempoDescansoCompensado.Text = "--:--:--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tiempo de descanso compensado";
            // 
            // lblHorascompensar
            // 
            this.lblHorascompensar.AutoSize = true;
            this.lblHorascompensar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorascompensar.Location = new System.Drawing.Point(19, 100);
            this.lblHorascompensar.Name = "lblHorascompensar";
            this.lblHorascompensar.Size = new System.Drawing.Size(81, 19);
            this.lblHorascompensar.TabIndex = 2;
            this.lblHorascompensar.Text = "--:--:--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horas a compensar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Semanal",
            "Mensual"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFechaActual);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live-Reg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcarEntrada;
        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbxHorarioAproxSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHorascompensar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTiempoDescansoCompensado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTotalDescanso;
        private System.Windows.Forms.Label label10;
    }
}

