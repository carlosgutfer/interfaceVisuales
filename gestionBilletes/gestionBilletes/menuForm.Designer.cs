
namespace gestionBilletes
{
    partial class main_form
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
            this.bt_regUsu = new System.Windows.Forms.Button();
            this.bt_compBill = new System.Windows.Forms.Button();
            this.bt_compPlaz = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_regUsu
            // 
            this.bt_regUsu.Location = new System.Drawing.Point(254, 28);
            this.bt_regUsu.Name = "bt_regUsu";
            this.bt_regUsu.Size = new System.Drawing.Size(150, 75);
            this.bt_regUsu.TabIndex = 0;
            this.bt_regUsu.Text = "Registrar usuario";
            this.bt_regUsu.UseVisualStyleBackColor = true;
            this.bt_regUsu.Click += new System.EventHandler(this.bt_regUsu_Click);
            // 
            // bt_compBill
            // 
            this.bt_compBill.Location = new System.Drawing.Point(254, 109);
            this.bt_compBill.Name = "bt_compBill";
            this.bt_compBill.Size = new System.Drawing.Size(150, 75);
            this.bt_compBill.TabIndex = 1;
            this.bt_compBill.Text = "Comprar billetes";
            this.bt_compBill.UseVisualStyleBackColor = true;
            this.bt_compBill.Click += new System.EventHandler(this.bt_compBill_Click);
            // 
            // bt_compPlaz
            // 
            this.bt_compPlaz.Location = new System.Drawing.Point(254, 190);
            this.bt_compPlaz.Name = "bt_compPlaz";
            this.bt_compPlaz.Size = new System.Drawing.Size(150, 75);
            this.bt_compPlaz.TabIndex = 2;
            this.bt_compPlaz.Text = "Comprobar plazas";
            this.bt_compPlaz.UseVisualStyleBackColor = true;
            this.bt_compPlaz.Click += new System.EventHandler(this.bt_compPlaz_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_salir.Location = new System.Drawing.Point(254, 271);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(150, 75);
            this.bt_salir.TabIndex = 3;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // main_form
            // 
            this.AcceptButton = this.bt_regUsu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.bt_salir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_compPlaz);
            this.Controls.Add(this.bt_compBill);
            this.Controls.Add(this.bt_regUsu);
            this.Name = "main_form";
            this.Text = "Billetes autobús";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_regUsu;
        private System.Windows.Forms.Button bt_compBill;
        private System.Windows.Forms.Button bt_compPlaz;
        private System.Windows.Forms.Button bt_salir;
    }
}

