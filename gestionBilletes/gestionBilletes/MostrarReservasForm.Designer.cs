
namespace gestionBilletes
{
    partial class mostrarReservasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_numPlaza = new System.Windows.Forms.Label();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Plaza";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(33, 62);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(0, 13);
            this.lb_nombre.TabIndex = 2;
            // 
            // lb_numPlaza
            // 
            this.lb_numPlaza.AutoSize = true;
            this.lb_numPlaza.Location = new System.Drawing.Point(157, 62);
            this.lb_numPlaza.Name = "lb_numPlaza";
            this.lb_numPlaza.Size = new System.Drawing.Size(0, 13);
            this.lb_numPlaza.TabIndex = 3;
            // 
            // bt_volver
            // 
            this.bt_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_volver.Location = new System.Drawing.Point(288, 23);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(75, 23);
            this.bt_volver.TabIndex = 4;
            this.bt_volver.Text = "Volver";
            this.bt_volver.UseVisualStyleBackColor = true;
            // 
            // mostrarReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_volver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.lb_numPlaza);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mostrarReservasForm";
            this.Text = "Plazas ocupadas";
            this.Load += new System.EventHandler(this.Plazas_vendidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_numPlaza;
        private System.Windows.Forms.Button bt_volver;
    }
}