
namespace gestionBilletes
{
    partial class ComprarBilleteForm
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
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_elegir = new System.Windows.Forms.Button();
            this.tb_numAsiento = new System.Windows.Forms.TextBox();
            this.lb_asiento = new System.Windows.Forms.Label();
            this.lb_asientos = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(116, 44);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(173, 20);
            this.tb_DNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprobar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_elegir
            // 
            this.bt_elegir.Location = new System.Drawing.Point(15, 223);
            this.bt_elegir.Name = "bt_elegir";
            this.bt_elegir.Size = new System.Drawing.Size(119, 37);
            this.bt_elegir.TabIndex = 4;
            this.bt_elegir.Text = "Elegir";
            this.bt_elegir.UseVisualStyleBackColor = true;
            this.bt_elegir.Visible = false;
            this.bt_elegir.Click += new System.EventHandler(this.bt_elegir_Click);
            // 
            // tb_numAsiento
            // 
            this.tb_numAsiento.Location = new System.Drawing.Point(15, 197);
            this.tb_numAsiento.Name = "tb_numAsiento";
            this.tb_numAsiento.Size = new System.Drawing.Size(173, 20);
            this.tb_numAsiento.TabIndex = 3;
            this.tb_numAsiento.Visible = false;
            // 
            // lb_asiento
            // 
            this.lb_asiento.AutoSize = true;
            this.lb_asiento.Location = new System.Drawing.Point(12, 167);
            this.lb_asiento.Name = "lb_asiento";
            this.lb_asiento.Size = new System.Drawing.Size(79, 13);
            this.lb_asiento.TabIndex = 5;
            this.lb_asiento.Text = "Elige tu asiento";
            this.lb_asiento.Visible = false;
            // 
            // lb_asientos
            // 
            this.lb_asientos.Location = new System.Drawing.Point(254, 158);
            this.lb_asientos.Name = "lb_asientos";
            this.lb_asientos.Size = new System.Drawing.Size(99, 153);
            this.lb_asientos.TabIndex = 6;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Location = new System.Drawing.Point(12, 282);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 13);
            this.lb_error.TabIndex = 7;
            // 
            // ComprarBilleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lb_asientos);
            this.Controls.Add(this.lb_asiento);
            this.Controls.Add(this.tb_numAsiento);
            this.Controls.Add(this.bt_elegir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_DNI);
            this.Name = "ComprarBilleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ComprarBilleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_elegir;
        private System.Windows.Forms.TextBox tb_numAsiento;
        private System.Windows.Forms.Label lb_asiento;
        private System.Windows.Forms.Label lb_asientos;
        private System.Windows.Forms.Label lb_error;
    }
}