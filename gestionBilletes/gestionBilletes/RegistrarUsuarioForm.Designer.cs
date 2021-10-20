
namespace gestionBilletes
{
    partial class RegistrarUsuarioForm
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.tb_telf = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_borrar = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(65, 52);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(188, 20);
            this.tb_nombre.TabIndex = 0;
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(65, 93);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(188, 20);
            this.tb_DNI.TabIndex = 1;
            // 
            // tb_telf
            // 
            this.tb_telf.Location = new System.Drawing.Point(65, 136);
            this.tb_telf.Name = "tb_telf";
            this.tb_telf.Size = new System.Drawing.Size(188, 20);
            this.tb_telf.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(65, 176);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(188, 20);
            this.tb_email.TabIndex = 3;
            // 
            // bt_registrar
            // 
            this.bt_registrar.Location = new System.Drawing.Point(63, 222);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(75, 23);
            this.bt_registrar.TabIndex = 4;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // bt_borrar
            // 
            this.bt_borrar.Location = new System.Drawing.Point(157, 222);
            this.bt_borrar.Name = "bt_borrar";
            this.bt_borrar.Size = new System.Drawing.Size(75, 23);
            this.bt_borrar.TabIndex = 5;
            this.bt_borrar.Text = "Borrar";
            this.bt_borrar.UseVisualStyleBackColor = true;
            this.bt_borrar.Click += new System.EventHandler(this.bt_borrar_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_volver.Location = new System.Drawing.Point(253, 222);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(75, 23);
            this.bt_volver.TabIndex = 6;
            this.bt_volver.Text = "Volver inicio";
            this.bt_volver.UseVisualStyleBackColor = true;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(62, 291);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 13);
            this.lb_error.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teléfono: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "email";
            // 
            // RegistrarUsuarioForm
            // 
            this.AcceptButton = this.bt_registrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_volver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_borrar);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_telf);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.tb_nombre);
            this.Name = "RegistrarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.TextBox tb_telf;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_borrar;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}