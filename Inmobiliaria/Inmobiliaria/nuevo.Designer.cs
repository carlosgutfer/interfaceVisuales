
namespace Inmobiliaria
{
    partial class nuevo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_propietario = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_ventas = new System.Windows.Forms.RadioButton();
            this.rb_alquiler = new System.Windows.Forms.RadioButton();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_volver_menu_principal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Local",
            "Piso",
            "Chalet"});
            this.listBox1.Location = new System.Drawing.Point(160, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 30);
            this.listBox1.TabIndex = 0;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(160, 110);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(100, 20);
            this.tb_direccion.TabIndex = 2;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Location = new System.Drawing.Point(160, 155);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(100, 20);
            this.tb_localidad.TabIndex = 3;
            // 
            // tb_propietario
            // 
            this.tb_propietario.Location = new System.Drawing.Point(160, 200);
            this.tb_propietario.Name = "tb_propietario";
            this.tb_propietario.Size = new System.Drawing.Size(100, 20);
            this.tb_propietario.TabIndex = 4;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(160, 239);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_telefono.TabIndex = 5;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(160, 289);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Propietario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // rb_ventas
            // 
            this.rb_ventas.AutoSize = true;
            this.rb_ventas.Location = new System.Drawing.Point(416, 162);
            this.rb_ventas.Name = "rb_ventas";
            this.rb_ventas.Size = new System.Drawing.Size(53, 17);
            this.rb_ventas.TabIndex = 13;
            this.rb_ventas.TabStop = true;
            this.rb_ventas.Text = "Venta";
            this.rb_ventas.UseVisualStyleBackColor = true;
            this.rb_ventas.CheckedChanged += new System.EventHandler(this.rb_ventas_CheckedChanged);
            // 
            // rb_alquiler
            // 
            this.rb_alquiler.AutoSize = true;
            this.rb_alquiler.Location = new System.Drawing.Point(416, 220);
            this.rb_alquiler.Name = "rb_alquiler";
            this.rb_alquiler.Size = new System.Drawing.Size(59, 17);
            this.rb_alquiler.TabIndex = 14;
            this.rb_alquiler.TabStop = true;
            this.rb_alquiler.Text = "Alquiler";
            this.rb_alquiler.UseVisualStyleBackColor = true;
            this.rb_alquiler.CheckedChanged += new System.EventHandler(this.rb_ventas_CheckedChanged);
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(416, 294);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 15;
            this.bt_Aceptar.Text = "Guardar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_volver_menu_principal
            // 
            this.bt_volver_menu_principal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_volver_menu_principal.Location = new System.Drawing.Point(527, 294);
            this.bt_volver_menu_principal.Name = "bt_volver_menu_principal";
            this.bt_volver_menu_principal.Size = new System.Drawing.Size(140, 23);
            this.bt_volver_menu_principal.TabIndex = 16;
            this.bt_volver_menu_principal.Text = "Volver menú principal";
            this.bt_volver_menu_principal.UseVisualStyleBackColor = true;
            // 
            // nuevo
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_volver_menu_principal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_volver_menu_principal);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.rb_alquiler);
            this.Controls.Add(this.rb_ventas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_propietario);
            this.Controls.Add(this.tb_localidad);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.listBox1);
            this.Name = "nuevo";
            this.Text = "Nuevo registro";
            this.Load += new System.EventHandler(this.nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_localidad;
        private System.Windows.Forms.TextBox tb_propietario;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_ventas;
        private System.Windows.Forms.RadioButton rb_alquiler;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_volver_menu_principal;
    }
}