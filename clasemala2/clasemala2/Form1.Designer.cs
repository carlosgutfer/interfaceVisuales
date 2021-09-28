
namespace clasemala2
{
    partial class recuadro
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
            this.pb_fondo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.bt_location = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_fondo
            // 
            this.pb_fondo.Image = global::clasemala2.Properties.Resources.fondo;
            this.pb_fondo.Location = new System.Drawing.Point(58, 101);
            this.pb_fondo.Name = "pb_fondo";
            this.pb_fondo.Size = new System.Drawing.Size(100, 50);
            this.pb_fondo.TabIndex = 0;
            this.pb_fondo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(303, 85);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(38, 13);
            this.lbl_hora.TabIndex = 3;
            this.lbl_hora.Text = "HORA";
            this.lbl_hora.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_location
            // 
            this.bt_location.Location = new System.Drawing.Point(306, 257);
            this.bt_location.Name = "bt_location";
            this.bt_location.Size = new System.Drawing.Size(75, 23);
            this.bt_location.TabIndex = 4;
            this.bt_location.Text = "RANDOM";
            this.bt_location.UseVisualStyleBackColor = true;
            this.bt_location.Click += new System.EventHandler(this.bt_location_Click);
            // 
            // recuadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_location);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_fondo);
            this.Name = "recuadro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_fondo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button bt_location;
    }
}

