namespace Formulario
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.planillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaISSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaAFPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlanillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planillasToolStripMenuItem,
            this.verPlanillasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // planillasToolStripMenuItem
            // 
            this.planillasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planillaISSSToolStripMenuItem,
            this.planillaAFPToolStripMenuItem,
            this.planillaGeneralToolStripMenuItem});
            this.planillasToolStripMenuItem.Name = "planillasToolStripMenuItem";
            this.planillasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.planillasToolStripMenuItem.Text = "Crear planillas";
            // 
            // planillaISSSToolStripMenuItem
            // 
            this.planillaISSSToolStripMenuItem.Name = "planillaISSSToolStripMenuItem";
            this.planillaISSSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planillaISSSToolStripMenuItem.Text = "Planilla ISSS";
            this.planillaISSSToolStripMenuItem.Click += new System.EventHandler(this.planillaISSSToolStripMenuItem_Click);
            // 
            // planillaAFPToolStripMenuItem
            // 
            this.planillaAFPToolStripMenuItem.Name = "planillaAFPToolStripMenuItem";
            this.planillaAFPToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planillaAFPToolStripMenuItem.Text = "Planilla AFP";
            this.planillaAFPToolStripMenuItem.Click += new System.EventHandler(this.planillaAFPToolStripMenuItem_Click);
            // 
            // planillaGeneralToolStripMenuItem
            // 
            this.planillaGeneralToolStripMenuItem.Name = "planillaGeneralToolStripMenuItem";
            this.planillaGeneralToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planillaGeneralToolStripMenuItem.Text = "Planilla general";
            this.planillaGeneralToolStripMenuItem.Click += new System.EventHandler(this.planillaGeneralToolStripMenuItem_Click);
            // 
            // verPlanillasToolStripMenuItem
            // 
            this.verPlanillasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSSSToolStripMenuItem,
            this.aFPToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.verPlanillasToolStripMenuItem.Name = "verPlanillasToolStripMenuItem";
            this.verPlanillasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.verPlanillasToolStripMenuItem.Text = "Ver planillas";
            // 
            // iSSSToolStripMenuItem
            // 
            this.iSSSToolStripMenuItem.Name = "iSSSToolStripMenuItem";
            this.iSSSToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.iSSSToolStripMenuItem.Text = "ISSS";
            this.iSSSToolStripMenuItem.Click += new System.EventHandler(this.iSSSToolStripMenuItem_Click);
            // 
            // aFPToolStripMenuItem
            // 
            this.aFPToolStripMenuItem.Name = "aFPToolStripMenuItem";
            this.aFPToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aFPToolStripMenuItem.Text = "AFP";
            this.aFPToolStripMenuItem.Click += new System.EventHandler(this.aFPToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulario.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de creacion de planillas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem planillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaISSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaAFPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPlanillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
    }
}



