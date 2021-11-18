
namespace gestionDonantes
{
    partial class NuevoDonante
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
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.ck_grupo = new System.Windows.Forms.CheckedListBox();
            this.rb_negativo = new System.Windows.Forms.RadioButton();
            this.rb_positivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_menor = new System.Windows.Forms.RadioButton();
            this.rb_mayor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(51, 274);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 0;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelar.Location = new System.Drawing.Point(157, 274);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 1;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_salir.Location = new System.Drawing.Point(286, 274);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 23);
            this.bt_salir.TabIndex = 2;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono: ";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(132, 51);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 8;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(132, 81);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(100, 20);
            this.tb_direccion.TabIndex = 9;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(132, 111);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_telefono.TabIndex = 10;
            // 
            // ck_grupo
            // 
            this.ck_grupo.FormattingEnabled = true;
            this.ck_grupo.Items.AddRange(new object[] {
            "A",
            "B",
            "0"});
            this.ck_grupo.Location = new System.Drawing.Point(51, 154);
            this.ck_grupo.Name = "ck_grupo";
            this.ck_grupo.Size = new System.Drawing.Size(120, 94);
            this.ck_grupo.TabIndex = 11;
            this.ck_grupo.SelectedIndexChanged += new System.EventHandler(this.ck_grupo_SelectedIndexChanged);
            // 
            // rb_negativo
            // 
            this.rb_negativo.AutoSize = true;
            this.rb_negativo.Location = new System.Drawing.Point(6, 19);
            this.rb_negativo.Name = "rb_negativo";
            this.rb_negativo.Size = new System.Drawing.Size(28, 17);
            this.rb_negativo.TabIndex = 12;
            this.rb_negativo.Text = "-";
            this.rb_negativo.UseVisualStyleBackColor = true;
            this.rb_negativo.CheckedChanged += new System.EventHandler(this.rb_negativo_CheckedChanged);
            // 
            // rb_positivo
            // 
            this.rb_positivo.AutoSize = true;
            this.rb_positivo.Location = new System.Drawing.Point(6, 42);
            this.rb_positivo.Name = "rb_positivo";
            this.rb_positivo.Size = new System.Drawing.Size(31, 17);
            this.rb_positivo.TabIndex = 13;
            this.rb_positivo.TabStop = true;
            this.rb_positivo.Text = "+";
            this.rb_positivo.UseVisualStyleBackColor = true;
            this.rb_positivo.CheckedChanged += new System.EventHandler(this.rb_negativo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grupo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_negativo);
            this.groupBox1.Controls.Add(this.rb_positivo);
            this.groupBox1.Location = new System.Drawing.Point(197, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_menor);
            this.groupBox2.Controls.Add(this.rb_mayor);
            this.groupBox2.Location = new System.Drawing.Point(451, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mayor edad";
            // 
            // rb_menor
            // 
            this.rb_menor.AutoSize = true;
            this.rb_menor.Location = new System.Drawing.Point(6, 42);
            this.rb_menor.Name = "rb_menor";
            this.rb_menor.Size = new System.Drawing.Size(46, 17);
            this.rb_menor.TabIndex = 1;
            this.rb_menor.TabStop = true;
            this.rb_menor.Text = "< 18";
            this.rb_menor.UseVisualStyleBackColor = true;
            this.rb_menor.CheckedChanged += new System.EventHandler(this.rb_menor_CheckedChanged);
            // 
            // rb_mayor
            // 
            this.rb_mayor.AutoSize = true;
            this.rb_mayor.Location = new System.Drawing.Point(6, 19);
            this.rb_mayor.Name = "rb_mayor";
            this.rb_mayor.Size = new System.Drawing.Size(49, 17);
            this.rb_mayor.TabIndex = 0;
            this.rb_mayor.Text = " > 18";
            this.rb_mayor.UseVisualStyleBackColor = true;
            this.rb_mayor.CheckedChanged += new System.EventHandler(this.rb_menor_CheckedChanged);
            // 
            // NuevoDonante
            // 
            this.AcceptButton = this.bt_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_salir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ck_grupo);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Name = "NuevoDonante";
            this.Text = "Nuevo donante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.CheckedListBox ck_grupo;
        private System.Windows.Forms.RadioButton rb_negativo;
        private System.Windows.Forms.RadioButton rb_positivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_menor;
        private System.Windows.Forms.RadioButton rb_mayor;
    }
}