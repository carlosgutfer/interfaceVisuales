
namespace gestionDonantes
{
    partial class formularioBaja
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
            this.lbl_error = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.tb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_activo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_factor = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_resultadoBusqueda = new System.Windows.Forms.ListBox();
            this.bt_baja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el nombre del usuario que quiere dar de baja: ";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(59, 85);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 1;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(368, 85);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 2;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(620, 85);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(75, 23);
            this.bt_volver.TabIndex = 3;
            this.bt_volver.Text = "Volver";
            this.bt_volver.UseVisualStyleBackColor = true;
            // 
            // tb_nombreUsuario
            // 
            this.tb_nombreUsuario.Location = new System.Drawing.Point(368, 51);
            this.tb_nombreUsuario.Name = "tb_nombreUsuario";
            this.tb_nombreUsuario.Size = new System.Drawing.Size(327, 20);
            this.tb_nombreUsuario.TabIndex = 4;
            // 
            // lbl_activo
            // 
            this.lbl_activo.AutoSize = true;
            this.lbl_activo.Location = new System.Drawing.Point(392, 280);
            this.lbl_activo.Name = "lbl_activo";
            this.lbl_activo.Size = new System.Drawing.Size(0, 13);
            this.lbl_activo.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Activo";
            // 
            // lbl_factor
            // 
            this.lbl_factor.AutoSize = true;
            this.lbl_factor.Location = new System.Drawing.Point(392, 249);
            this.lbl_factor.Name = "lbl_factor";
            this.lbl_factor.Size = new System.Drawing.Size(0, 13);
            this.lbl_factor.TabIndex = 29;
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Location = new System.Drawing.Point(392, 222);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(0, 13);
            this.lbl_grupo.TabIndex = 28;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(392, 194);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(0, 13);
            this.lbl_direccion.TabIndex = 27;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(392, 169);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(0, 13);
            this.lbl_telefono.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Factor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Teléfono";
            // 
            // lb_resultadoBusqueda
            // 
            this.lb_resultadoBusqueda.FormattingEnabled = true;
            this.lb_resultadoBusqueda.Location = new System.Drawing.Point(62, 173);
            this.lb_resultadoBusqueda.Name = "lb_resultadoBusqueda";
            this.lb_resultadoBusqueda.Size = new System.Drawing.Size(120, 95);
            this.lb_resultadoBusqueda.TabIndex = 21;
            this.lb_resultadoBusqueda.SelectedIndexChanged += new System.EventHandler(this.lb_resultadoBusqueda_SelectedIndexChanged);
            // 
            // bt_baja
            // 
            this.bt_baja.Location = new System.Drawing.Point(325, 335);
            this.bt_baja.Name = "bt_baja";
            this.bt_baja.Size = new System.Drawing.Size(75, 23);
            this.bt_baja.TabIndex = 32;
            this.bt_baja.Text = "Dar de baja";
            this.bt_baja.UseVisualStyleBackColor = true;
            this.bt_baja.Click += new System.EventHandler(this.bt_baja_Click);
            // 
            // formularioBaja
            // 
            this.AcceptButton = this.bt_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_volver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_baja);
            this.Controls.Add(this.lbl_activo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_factor);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_resultadoBusqueda);
            this.Controls.Add(this.tb_nombreUsuario);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label1);
            this.Name = "formularioBaja";
            this.Text = "Baja usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.TextBox tb_nombreUsuario;
        private System.Windows.Forms.Label lbl_activo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_factor;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_resultadoBusqueda;
        private System.Windows.Forms.Button bt_baja;
    }
}