
namespace Gestion_Instituto
{
    partial class Alta
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CLB_asignaturas1 = new System.Windows.Forms.CheckedListBox();
            this.CLB_aignaturas2 = new System.Windows.Forms.CheckedListBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(187, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(184, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(187, 58);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(184, 20);
            this.tb_apellido.TabIndex = 1;
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(187, 84);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(184, 20);
            this.tb_dni.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(187, 110);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(184, 20);
            this.tb_email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1º DAM A",
            "1º DAM B",
            "2º DAM A",
            "2º DAM B"});
            this.listBox1.Location = new System.Drawing.Point(435, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Curso";
            // 
            // CLB_asignaturas1
            // 
            this.CLB_asignaturas1.FormattingEnabled = true;
            this.CLB_asignaturas1.Items.AddRange(new object[] {
            "1 - Programacion ",
            "2 - BBDD",
            "3 - FOL",
            "4 - Lenguaje de Marcas",
            "5 - Sistemas Informáticos",
            "6 - Entornos de desarrollo"});
            this.CLB_asignaturas1.Location = new System.Drawing.Point(26, 187);
            this.CLB_asignaturas1.Name = "CLB_asignaturas1";
            this.CLB_asignaturas1.Size = new System.Drawing.Size(120, 94);
            this.CLB_asignaturas1.TabIndex = 13;
            this.CLB_asignaturas1.Visible = false;
            // 
            // CLB_aignaturas2
            // 
            this.CLB_aignaturas2.FormattingEnabled = true;
            this.CLB_aignaturas2.Items.AddRange(new object[] {
            "7 - SGE",
            "8 - Interfaces",
            "9 - Móviles",
            "10 - Inglés",
            "11 - EIE",
            "12 - Acceso a datos",
            "13 - Procesos ",
            "14 - Prácticas",
            "15 - Proyecto final de grado"});
            this.CLB_aignaturas2.Location = new System.Drawing.Point(187, 187);
            this.CLB_aignaturas2.Name = "CLB_aignaturas2";
            this.CLB_aignaturas2.Size = new System.Drawing.Size(120, 94);
            this.CLB_aignaturas2.TabIndex = 14;
            this.CLB_aignaturas2.Visible = false;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(435, 258);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 15;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Asignaturas";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.CLB_aignaturas2);
            this.Controls.Add(this.CLB_asignaturas1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_name);
            this.Name = "Alta";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox CLB_asignaturas1;
        private System.Windows.Forms.CheckedListBox CLB_aignaturas2;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Label label5;
    }
}