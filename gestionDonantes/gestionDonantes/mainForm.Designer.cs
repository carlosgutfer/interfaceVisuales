
namespace gestionDonantes
{
    partial class mainForm
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
            this.registroDonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDonanteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDonanteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDonanteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaDonanteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDonanteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDisponibles = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadPorTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registroDonantesToolStripMenuItem
            // 
            this.registroDonantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDonanteToolStripMenuItem1,
            this.bajaDonanteToolStripMenuItem1});
            this.registroDonantesToolStripMenuItem.Name = "registroDonantesToolStripMenuItem";
            this.registroDonantesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.registroDonantesToolStripMenuItem.Text = "Gestion donantes";
            // 
            // nuevoDonanteToolStripMenuItem1
            // 
            this.nuevoDonanteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDonanteToolStripMenuItem2,
            this.bajaDonanteToolStripMenuItem2,
            this.búsquedaDonanteToolStripMenuItem1});
            this.nuevoDonanteToolStripMenuItem1.Name = "nuevoDonanteToolStripMenuItem1";
            this.nuevoDonanteToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.nuevoDonanteToolStripMenuItem1.Text = "Registro donantes";
            // 
            // nuevoDonanteToolStripMenuItem2
            // 
            this.nuevoDonanteToolStripMenuItem2.Name = "nuevoDonanteToolStripMenuItem2";
            this.nuevoDonanteToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.nuevoDonanteToolStripMenuItem2.Text = "Nuevo donante";
            this.nuevoDonanteToolStripMenuItem2.Click += new System.EventHandler(this.nuevoDonanteToolStripMenuItem2_Click);
            // 
            // bajaDonanteToolStripMenuItem2
            // 
            this.bajaDonanteToolStripMenuItem2.Name = "bajaDonanteToolStripMenuItem2";
            this.bajaDonanteToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.bajaDonanteToolStripMenuItem2.Text = "Baja donante";
            this.bajaDonanteToolStripMenuItem2.Click += new System.EventHandler(this.nuevoDonanteToolStripMenuItem2_Click);
            // 
            // búsquedaDonanteToolStripMenuItem1
            // 
            this.búsquedaDonanteToolStripMenuItem1.Name = "búsquedaDonanteToolStripMenuItem1";
            this.búsquedaDonanteToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.búsquedaDonanteToolStripMenuItem1.Text = "Busqueda donante";
            this.búsquedaDonanteToolStripMenuItem1.Click += new System.EventHandler(this.nuevoDonanteToolStripMenuItem2_Click);
            // 
            // bajaDonanteToolStripMenuItem1
            // 
            this.bajaDonanteToolStripMenuItem1.Name = "bajaDonanteToolStripMenuItem1";
            this.bajaDonanteToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.bajaDonanteToolStripMenuItem1.Text = "salir";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDisponibles,
            this.disponibilidadPorTipos});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // tiposDisponibles
            // 
            this.tiposDisponibles.Name = "tiposDisponibles";
            this.tiposDisponibles.Size = new System.Drawing.Size(200, 22);
            this.tiposDisponibles.Text = "Tipos disponibles";
            this.tiposDisponibles.Click += new System.EventHandler(this.tiposDisponiblesToolStripMenuItem1_Click);
            // 
            // disponibilidadPorTipos
            // 
            this.disponibilidadPorTipos.Name = "disponibilidadPorTipos";
            this.disponibilidadPorTipos.Size = new System.Drawing.Size(200, 22);
            this.disponibilidadPorTipos.Text = "Disponibilidad por tipos";
            this.disponibilidadPorTipos.Click += new System.EventHandler(this.tiposDisponiblesToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDonantesToolStripMenuItem,
            this.solicitudesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "mainForm";
            this.Text = "Menú donantes";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem registroDonantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDonanteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoDonanteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaDonanteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem búsquedaDonanteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaDonanteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDisponibles;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadPorTipos;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

