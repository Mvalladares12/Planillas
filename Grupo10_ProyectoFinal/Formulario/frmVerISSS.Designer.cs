namespace Formulario
{
    partial class frmVerISSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerISSS));
            this.dgvIsss = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsss)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsss
            // 
            this.dgvIsss.AllowUserToAddRows = false;
            this.dgvIsss.AllowUserToDeleteRows = false;
            this.dgvIsss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsss.Location = new System.Drawing.Point(12, 65);
            this.dgvIsss.Name = "dgvIsss";
            this.dgvIsss.ReadOnly = true;
            this.dgvIsss.Size = new System.Drawing.Size(1245, 380);
            this.dgvIsss.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 496);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planilla ISSS";
            // 
            // frmVerISSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvIsss);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerISSS";
            this.Text = "Visualizacion planilla ISSS";
            this.Load += new System.EventHandler(this.frmVerISSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsss;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}