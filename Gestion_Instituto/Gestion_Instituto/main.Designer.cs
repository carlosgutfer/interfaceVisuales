
namespace Gestion_Instituto
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_alta = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_baja = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_1dama = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_1damb = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_2dama = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_2damb = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_1damanotas = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_1dambnotas = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_2damanotas = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_2dambnotas = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrículaToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matrículaToolStripMenuItem
            // 
            this.matrículaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_alta,
            this.TS_baja,
            this.listadoToolStripMenuItem});
            this.matrículaToolStripMenuItem.Name = "matrículaToolStripMenuItem";
            this.matrículaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matrículaToolStripMenuItem.Text = "Matrícula";
            // 
            // TS_alta
            // 
            this.TS_alta.Name = "TS_alta";
            this.TS_alta.Size = new System.Drawing.Size(180, 22);
            this.TS_alta.Text = "Alta";
            this.TS_alta.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TS_baja
            // 
            this.TS_baja.Name = "TS_baja";
            this.TS_baja.Size = new System.Drawing.Size(180, 22);
            this.TS_baja.Text = "Baja";
            this.TS_baja.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_1dama,
            this.TS_1damb,
            this.TS_2dama,
            this.TS_2damb});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem.Text = "Listado ";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TS_1dama
            // 
            this.TS_1dama.Name = "TS_1dama";
            this.TS_1dama.Size = new System.Drawing.Size(180, 22);
            this.TS_1dama.Text = "1º DAM A";
            this.TS_1dama.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TS_1damb
            // 
            this.TS_1damb.Name = "TS_1damb";
            this.TS_1damb.Size = new System.Drawing.Size(180, 22);
            this.TS_1damb.Text = "1º DAM B";
            this.TS_1damb.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TS_2dama
            // 
            this.TS_2dama.Name = "TS_2dama";
            this.TS_2dama.Size = new System.Drawing.Size(180, 22);
            this.TS_2dama.Text = "2º DAM A";
            this.TS_2dama.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TS_2damb
            // 
            this.TS_2damb.Name = "TS_2damb";
            this.TS_2damb.Size = new System.Drawing.Size(180, 22);
            this.TS_2damb.Text = "2º DAM B";
            this.TS_2damb.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_1damanotas,
            this.TS_1dambnotas,
            this.TS_2dambnotas,
            this.TS_2damanotas});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // TS_1damanotas
            // 
            this.TS_1damanotas.Name = "TS_1damanotas";
            this.TS_1damanotas.Size = new System.Drawing.Size(180, 22);
            this.TS_1damanotas.Text = "1º DAM A";
            this.TS_1damanotas.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem2_Click);
            // 
            // TS_1dambnotas
            // 
            this.TS_1dambnotas.Name = "TS_1dambnotas";
            this.TS_1dambnotas.Size = new System.Drawing.Size(180, 22);
            this.TS_1dambnotas.Text = "1º DAM B";
            this.TS_1dambnotas.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem2_Click);
            // 
            // TS_2damanotas
            // 
            this.TS_2damanotas.Name = "TS_2damanotas";
            this.TS_2damanotas.Size = new System.Drawing.Size(180, 22);
            this.TS_2damanotas.Text = "2º DAM A";
            this.TS_2damanotas.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem2_Click);
            // 
            // TS_2dambnotas
            // 
            this.TS_2dambnotas.Name = "TS_2dambnotas";
            this.TS_2dambnotas.Size = new System.Drawing.Size(180, 22);
            this.TS_2dambnotas.Text = "2º DAM B";
            this.TS_2dambnotas.Click += new System.EventHandler(this.ºDAMAToolStripMenuItem2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_baja;
        private System.Windows.Forms.ToolStripMenuItem TS_alta;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_1dama;
        private System.Windows.Forms.ToolStripMenuItem TS_1damb;
        private System.Windows.Forms.ToolStripMenuItem TS_2dama;
        private System.Windows.Forms.ToolStripMenuItem TS_2damb;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_1damanotas;
        private System.Windows.Forms.ToolStripMenuItem TS_1dambnotas;
        private System.Windows.Forms.ToolStripMenuItem TS_2damanotas;
        private System.Windows.Forms.ToolStripMenuItem TS_2dambnotas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

