
namespace clasesmalas
{
    partial class Form1
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
            this.fecha_cumple = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_cumpleaños = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_respuesta = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fecha_cumple
            // 
            this.fecha_cumple.Location = new System.Drawing.Point(150, 26);
            this.fecha_cumple.Name = "fecha_cumple";
            this.fecha_cumple.Size = new System.Drawing.Size(200, 20);
            this.fecha_cumple.TabIndex = 0;
            this.fecha_cumple.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_fecha_cumpleaños
            // 
            this.lbl_fecha_cumpleaños.AutoSize = true;
            this.lbl_fecha_cumpleaños.Location = new System.Drawing.Point(23, 32);
            this.lbl_fecha_cumpleaños.Name = "lbl_fecha_cumpleaños";
            this.lbl_fecha_cumpleaños.Size = new System.Drawing.Size(112, 13);
            this.lbl_fecha_cumpleaños.TabIndex = 1;
            this.lbl_fecha_cumpleaños.Text = "Fecha de cumpleaños";
            this.lbl_fecha_cumpleaños.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tu fecha de cumpleaños es:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_respuesta
            // 
            this.lbl_respuesta.AutoSize = true;
            this.lbl_respuesta.Location = new System.Drawing.Point(175, 71);
            this.lbl_respuesta.Name = "lbl_respuesta";
            this.lbl_respuesta.Size = new System.Drawing.Size(0, 13);
            this.lbl_respuesta.TabIndex = 3;
            this.lbl_respuesta.Click += new System.EventHandler(this.label2_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(26, 139);
            this.calendario.MaxSelectionCount = 10;
            this.calendario.Name = "calendario";
            this.calendario.ScrollChange = 10;
            this.calendario.TabIndex = 4;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elige un peridode vacaciones de 10 días";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(251, 191);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(0, 13);
            this.lbl_inicio.TabIndex = 6;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(254, 245);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(0, 13);
            this.lbl_fin.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.lbl_respuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha_cumpleaños);
            this.Controls.Add(this.fecha_cumple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_cumple;
        private System.Windows.Forms.Label lbl_fecha_cumpleaños;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_respuesta;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_fin;
    }
}

