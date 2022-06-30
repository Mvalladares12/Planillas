namespace Formulario
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtbNIT = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDepa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISSSP = new System.Windows.Forms.TextBox();
            this.txtAFPL = new System.Windows.Forms.TextBox();
            this.txtISSSL = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeduccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAFPP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHE = new System.Windows.Forms.TextBox();
            this.txtHN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formulario.Properties.Resources.nt;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLANILLA MENSUAL DE SALARIOS";
            // 
            // gpb1
            // 
            this.gpb1.Controls.Add(this.label13);
            this.gpb1.Controls.Add(this.mtbNIT);
            this.gpb1.Controls.Add(this.label12);
            this.gpb1.Controls.Add(this.cmbDepa);
            this.gpb1.Controls.Add(this.label11);
            this.gpb1.Controls.Add(this.label10);
            this.gpb1.Controls.Add(this.label9);
            this.gpb1.Controls.Add(this.txtISSSP);
            this.gpb1.Controls.Add(this.txtAFPL);
            this.gpb1.Controls.Add(this.txtISSSL);
            this.gpb1.Controls.Add(this.txtTotal);
            this.gpb1.Controls.Add(this.label8);
            this.gpb1.Controls.Add(this.txtDeduccion);
            this.gpb1.Controls.Add(this.label7);
            this.gpb1.Controls.Add(this.txtAFPP);
            this.gpb1.Controls.Add(this.label6);
            this.gpb1.Controls.Add(this.txtHE);
            this.gpb1.Controls.Add(this.txtHN);
            this.gpb1.Controls.Add(this.label5);
            this.gpb1.Controls.Add(this.label4);
            this.gpb1.Controls.Add(this.txtSueldo);
            this.gpb1.Controls.Add(this.label3);
            this.gpb1.Controls.Add(this.txtNombre);
            this.gpb1.Controls.Add(this.label2);
            this.gpb1.Location = new System.Drawing.Point(13, 152);
            this.gpb1.Name = "gpb1";
            this.gpb1.Size = new System.Drawing.Size(1259, 104);
            this.gpb1.TabIndex = 2;
            this.gpb1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "NIT";
            // 
            // mtbNIT
            // 
            this.mtbNIT.Location = new System.Drawing.Point(205, 47);
            this.mtbNIT.Mask = "0000-000000-000-0";
            this.mtbNIT.Name = "mtbNIT";
            this.mtbNIT.Size = new System.Drawing.Size(100, 20);
            this.mtbNIT.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Departamento";
            // 
            // cmbDepa
            // 
            this.cmbDepa.FormattingEnabled = true;
            this.cmbDepa.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Contabilidad",
            "Impuestos",
            "Mantenimiento",
            "Tecnologia"});
            this.cmbDepa.Location = new System.Drawing.Point(323, 45);
            this.cmbDepa.Name = "cmbDepa";
            this.cmbDepa.Size = new System.Drawing.Size(111, 21);
            this.cmbDepa.TabIndex = 20;
            this.cmbDepa.Text = "Seleccione...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(888, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "AFP Laboral";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(801, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "ISSS Patronal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ISSS Laboral";
            // 
            // txtISSSP
            // 
            this.txtISSSP.Enabled = false;
            this.txtISSSP.Location = new System.Drawing.Point(807, 46);
            this.txtISSSP.MaxLength = 40;
            this.txtISSSP.Name = "txtISSSP";
            this.txtISSSP.Size = new System.Drawing.Size(67, 20);
            this.txtISSSP.TabIndex = 16;
            // 
            // txtAFPL
            // 
            this.txtAFPL.Enabled = false;
            this.txtAFPL.Location = new System.Drawing.Point(891, 46);
            this.txtAFPL.MaxLength = 40;
            this.txtAFPL.Name = "txtAFPL";
            this.txtAFPL.Size = new System.Drawing.Size(67, 20);
            this.txtAFPL.TabIndex = 15;
            // 
            // txtISSSL
            // 
            this.txtISSSL.Enabled = false;
            this.txtISSSL.Location = new System.Drawing.Point(718, 47);
            this.txtISSSL.MaxLength = 40;
            this.txtISSSL.Name = "txtISSSL";
            this.txtISSSL.Size = new System.Drawing.Size(67, 20);
            this.txtISSSL.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1171, 47);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1168, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Salario Neto";
            // 
            // txtDeduccion
            // 
            this.txtDeduccion.Enabled = false;
            this.txtDeduccion.Location = new System.Drawing.Point(1069, 47);
            this.txtDeduccion.Name = "txtDeduccion";
            this.txtDeduccion.Size = new System.Drawing.Size(81, 20);
            this.txtDeduccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1066, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total deduccion";
            // 
            // txtAFPP
            // 
            this.txtAFPP.Enabled = false;
            this.txtAFPP.Location = new System.Drawing.Point(980, 46);
            this.txtAFPP.MaxLength = 40;
            this.txtAFPP.Name = "txtAFPP";
            this.txtAFPP.Size = new System.Drawing.Size(67, 20);
            this.txtAFPP.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(977, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "AFP Patrono";
            // 
            // txtHE
            // 
            this.txtHE.Location = new System.Drawing.Point(628, 47);
            this.txtHE.Name = "txtHE";
            this.txtHE.Size = new System.Drawing.Size(63, 20);
            this.txtHE.TabIndex = 7;
            // 
            // txtHN
            // 
            this.txtHN.Location = new System.Drawing.Point(538, 47);
            this.txtHN.Name = "txtHN";
            this.txtHN.Size = new System.Drawing.Size(63, 20);
            this.txtHN.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horas extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horas jornada";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(451, 46);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(63, 20);
            this.txtSueldo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo base";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre empleado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 279);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 25);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(121, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 25);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 25);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(228, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 25);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 314);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla General";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb1.ResumeLayout(false);
            this.gpb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb1;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHE;
        private System.Windows.Forms.TextBox txtHN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeduccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAFPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISSSP;
        private System.Windows.Forms.TextBox txtAFPL;
        private System.Windows.Forms.TextBox txtISSSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDepa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtbNIT;
    }
}