
namespace Editor_de_texto
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_web = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_main = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.archivoToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.fuentesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuentesToolStripMenuItem.Text = "Fuentes";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.coloresToolStripMenuItem.Text = "Colores";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_cortar,
            this.mi_copiar,
            this.mi_pegar,
            this.mi_eliminar,
            this.toolStripMenuItem2,
            this.mi_buscar,
            this.mi_web});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // mi_cortar
            // 
            this.mi_cortar.Name = "mi_cortar";
            this.mi_cortar.ShortcutKeyDisplayString = "Ctrl + X";
            this.mi_cortar.Size = new System.Drawing.Size(165, 22);
            this.mi_cortar.Text = "Cortar";
            this.mi_cortar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // mi_copiar
            // 
            this.mi_copiar.Name = "mi_copiar";
            this.mi_copiar.ShortcutKeyDisplayString = "Ctrl + C";
            this.mi_copiar.Size = new System.Drawing.Size(165, 22);
            this.mi_copiar.Text = "Copiar";
            this.mi_copiar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // mi_pegar
            // 
            this.mi_pegar.Name = "mi_pegar";
            this.mi_pegar.ShortcutKeyDisplayString = "Ctrl + V";
            this.mi_pegar.Size = new System.Drawing.Size(165, 22);
            this.mi_pegar.Text = "Pegar";
            this.mi_pegar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // mi_eliminar
            // 
            this.mi_eliminar.Name = "mi_eliminar";
            this.mi_eliminar.ShortcutKeyDisplayString = "Ctrl + D";
            this.mi_eliminar.Size = new System.Drawing.Size(165, 22);
            this.mi_eliminar.Text = "Eliminar";
            this.mi_eliminar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_buscar
            // 
            this.mi_buscar.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mi_buscar.Name = "mi_buscar";
            this.mi_buscar.ShortcutKeyDisplayString = "Ctrl + F";
            this.mi_buscar.Size = new System.Drawing.Size(165, 22);
            this.mi_buscar.Text = "Buscar";
            this.mi_buscar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // mi_web
            // 
            this.mi_web.Name = "mi_web";
            this.mi_web.Size = new System.Drawing.Size(165, 22);
            this.mi_web.Text = "Buscar en ...";
            this.mi_web.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);

            // 
            // tb_main
            // 
            this.tb_main.Location = new System.Drawing.Point(12, 27);
            this.tb_main.Name = "tb_main";
            this.tb_main.Size = new System.Drawing.Size(714, 411);
            this.tb_main.TabIndex = 2;
            this.tb_main.Text = "";
            this.tb_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_main_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tb_main;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_cortar;
        private System.Windows.Forms.ToolStripMenuItem mi_copiar;
        private System.Windows.Forms.ToolStripMenuItem mi_pegar;
        private System.Windows.Forms.ToolStripMenuItem mi_eliminar;
        private System.Windows.Forms.ToolStripMenuItem mi_buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mi_web;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

