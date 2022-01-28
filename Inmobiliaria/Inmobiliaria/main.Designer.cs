
namespace Inmobiliaria
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SM_consulta_todos = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_consulta_n_registro = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_Alquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuebleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // nmuebleToolStripMenuItem
            // 
            this.nmuebleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_Nuevo,
            this.toolStripSeparator1,
            this.SM_consulta_todos,
            this.SM_consulta_n_registro,
            this.SM_Alquiler,
            this.SM_venta});
            this.nmuebleToolStripMenuItem.Name = "nmuebleToolStripMenuItem";
            this.nmuebleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nmuebleToolStripMenuItem.Text = "Inmueble";
            // 
            // SM_Nuevo
            // 
            this.SM_Nuevo.Name = "SM_Nuevo";
            this.SM_Nuevo.Size = new System.Drawing.Size(187, 22);
            this.SM_Nuevo.Text = "Nuevo";
            this.SM_Nuevo.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // SM_consulta_todos
            // 
            this.SM_consulta_todos.Name = "SM_consulta_todos";
            this.SM_consulta_todos.Size = new System.Drawing.Size(187, 22);
            this.SM_consulta_todos.Text = "Consulta (Todos)";
            this.SM_consulta_todos.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // SM_consulta_n_registro
            // 
            this.SM_consulta_n_registro.Name = "SM_consulta_n_registro";
            this.SM_consulta_n_registro.Size = new System.Drawing.Size(187, 22);
            this.SM_consulta_n_registro.Text = "Consulta (nº registro)";
            this.SM_consulta_n_registro.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // SM_Alquiler
            // 
            this.SM_Alquiler.Name = "SM_Alquiler";
            this.SM_Alquiler.Size = new System.Drawing.Size(187, 22);
            this.SM_Alquiler.Text = "Alquiler";
            this.SM_Alquiler.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // SM_venta
            // 
            this.SM_venta.Name = "SM_venta";
            this.SM_venta.Size = new System.Drawing.Size(187, 22);
            this.SM_venta.Text = "Venta";
            this.SM_venta.Click += new System.EventHandler(this.nmuebleToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem nmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SM_Nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SM_consulta_todos;
        private System.Windows.Forms.ToolStripMenuItem SM_consulta_n_registro;
        private System.Windows.Forms.ToolStripMenuItem SM_Alquiler;
        private System.Windows.Forms.ToolStripMenuItem SM_venta;
    }
}

