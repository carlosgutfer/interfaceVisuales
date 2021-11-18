
namespace Editor_de_texto
{
    partial class Fuentes
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
            this.tb_prueba = new System.Windows.Forms.TextBox();
            this.rb_f1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_f4 = new System.Windows.Forms.RadioButton();
            this.rb_f3 = new System.Windows.Forms.RadioButton();
            this.rb_f2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_tachado = new System.Windows.Forms.RadioButton();
            this.rb_subrayado = new System.Windows.Forms.RadioButton();
            this.rb_cursiva = new System.Windows.Forms.RadioButton();
            this.rb_negrita = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_12 = new System.Windows.Forms.RadioButton();
            this.rb_10 = new System.Windows.Forms.RadioButton();
            this.rb_8 = new System.Windows.Forms.RadioButton();
            this.Volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_prueba
            // 
            this.tb_prueba.Location = new System.Drawing.Point(55, 39);
            this.tb_prueba.Name = "tb_prueba";
            this.tb_prueba.Size = new System.Drawing.Size(500, 20);
            this.tb_prueba.TabIndex = 0;
            // 
            // rb_f1
            // 
            this.rb_f1.AutoSize = true;
            this.rb_f1.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_f1.Location = new System.Drawing.Point(6, 19);
            this.rb_f1.Name = "rb_f1";
            this.rb_f1.Size = new System.Drawing.Size(61, 17);
            this.rb_f1.TabIndex = 1;
            this.rb_f1.TabStop = true;
            this.rb_f1.Text = "Fuente 1";
            this.rb_f1.UseVisualStyleBackColor = true;
            this.rb_f1.CheckedChanged += new System.EventHandler(this.rb_f1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_f4);
            this.groupBox1.Controls.Add(this.rb_f3);
            this.groupBox1.Controls.Add(this.rb_f2);
            this.groupBox1.Controls.Add(this.rb_f1);
            this.groupBox1.Location = new System.Drawing.Point(36, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuentes";
            // 
            // rb_f4
            // 
            this.rb_f4.AutoSize = true;
            this.rb_f4.Location = new System.Drawing.Point(6, 88);
            this.rb_f4.Name = "rb_f4";
            this.rb_f4.Size = new System.Drawing.Size(67, 17);
            this.rb_f4.TabIndex = 4;
            this.rb_f4.TabStop = true;
            this.rb_f4.Text = "Fuente 4";
            this.rb_f4.UseVisualStyleBackColor = true;
            this.rb_f4.CheckedChanged += new System.EventHandler(this.rb_f1_CheckedChanged);
            // 
            // rb_f3
            // 
            this.rb_f3.AutoSize = true;
            this.rb_f3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_f3.Location = new System.Drawing.Point(6, 65);
            this.rb_f3.Name = "rb_f3";
            this.rb_f3.Size = new System.Drawing.Size(65, 18);
            this.rb_f3.TabIndex = 3;
            this.rb_f3.TabStop = true;
            this.rb_f3.Text = "Fuente 3";
            this.rb_f3.UseVisualStyleBackColor = true;
            this.rb_f3.CheckedChanged += new System.EventHandler(this.rb_f1_CheckedChanged);
            // 
            // rb_f2
            // 
            this.rb_f2.AutoSize = true;
            this.rb_f2.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_f2.Location = new System.Drawing.Point(6, 42);
            this.rb_f2.Name = "rb_f2";
            this.rb_f2.Size = new System.Drawing.Size(73, 16);
            this.rb_f2.TabIndex = 2;
            this.rb_f2.TabStop = true;
            this.rb_f2.Text = "Fuente 2";
            this.rb_f2.UseVisualStyleBackColor = true;
            this.rb_f2.CheckedChanged += new System.EventHandler(this.rb_f1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_tachado);
            this.groupBox2.Controls.Add(this.rb_subrayado);
            this.groupBox2.Controls.Add(this.rb_cursiva);
            this.groupBox2.Controls.Add(this.rb_negrita);
            this.groupBox2.Location = new System.Drawing.Point(251, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estilo";
            // 
            // rb_tachado
            // 
            this.rb_tachado.AutoSize = true;
            this.rb_tachado.Location = new System.Drawing.Point(6, 98);
            this.rb_tachado.Name = "rb_tachado";
            this.rb_tachado.Size = new System.Drawing.Size(68, 17);
            this.rb_tachado.TabIndex = 3;
            this.rb_tachado.TabStop = true;
            this.rb_tachado.Text = "Tachado";
            this.rb_tachado.UseVisualStyleBackColor = true;
            this.rb_tachado.CheckedChanged += new System.EventHandler(this.rb_negrita_CheckedChanged);
            // 
            // rb_subrayado
            // 
            this.rb_subrayado.AutoSize = true;
            this.rb_subrayado.Location = new System.Drawing.Point(6, 66);
            this.rb_subrayado.Name = "rb_subrayado";
            this.rb_subrayado.Size = new System.Drawing.Size(76, 17);
            this.rb_subrayado.TabIndex = 2;
            this.rb_subrayado.TabStop = true;
            this.rb_subrayado.Text = "Subrayado";
            this.rb_subrayado.UseVisualStyleBackColor = true;
            this.rb_subrayado.CheckedChanged += new System.EventHandler(this.rb_negrita_CheckedChanged);
            // 
            // rb_cursiva
            // 
            this.rb_cursiva.AutoSize = true;
            this.rb_cursiva.Location = new System.Drawing.Point(6, 43);
            this.rb_cursiva.Name = "rb_cursiva";
            this.rb_cursiva.Size = new System.Drawing.Size(60, 17);
            this.rb_cursiva.TabIndex = 1;
            this.rb_cursiva.TabStop = true;
            this.rb_cursiva.Text = "Cursiva";
            this.rb_cursiva.UseVisualStyleBackColor = true;
            this.rb_cursiva.CheckedChanged += new System.EventHandler(this.rb_negrita_CheckedChanged);
            // 
            // rb_negrita
            // 
            this.rb_negrita.AutoSize = true;
            this.rb_negrita.Location = new System.Drawing.Point(7, 20);
            this.rb_negrita.Name = "rb_negrita";
            this.rb_negrita.Size = new System.Drawing.Size(59, 17);
            this.rb_negrita.TabIndex = 0;
            this.rb_negrita.TabStop = true;
            this.rb_negrita.Text = "Negrita";
            this.rb_negrita.UseVisualStyleBackColor = true;
            this.rb_negrita.CheckedChanged += new System.EventHandler(this.rb_negrita_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_12);
            this.groupBox3.Controls.Add(this.rb_10);
            this.groupBox3.Controls.Add(this.rb_8);
            this.groupBox3.Location = new System.Drawing.Point(450, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 144);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamaño";
            // 
            // rb_12
            // 
            this.rb_12.AutoSize = true;
            this.rb_12.Location = new System.Drawing.Point(19, 98);
            this.rb_12.Name = "rb_12";
            this.rb_12.Size = new System.Drawing.Size(37, 17);
            this.rb_12.TabIndex = 6;
            this.rb_12.TabStop = true;
            this.rb_12.Text = "12";
            this.rb_12.UseVisualStyleBackColor = true;
            this.rb_12.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Location = new System.Drawing.Point(19, 60);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(37, 17);
            this.rb_10.TabIndex = 5;
            this.rb_10.TabStop = true;
            this.rb_10.Text = "10";
            this.rb_10.UseVisualStyleBackColor = true;
            this.rb_10.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_8
            // 
            this.rb_8.AutoSize = true;
            this.rb_8.Location = new System.Drawing.Point(19, 20);
            this.rb_8.Name = "rb_8";
            this.rb_8.Size = new System.Drawing.Size(31, 17);
            this.rb_8.TabIndex = 4;
            this.rb_8.TabStop = true;
            this.rb_8.Text = "8";
            this.rb_8.UseVisualStyleBackColor = true;
            this.rb_8.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Volver
            // 
            this.Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Volver.Location = new System.Drawing.Point(36, 337);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // Fuentes
            // 
            this.AcceptButton = this.Volver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Volver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_prueba);
            this.Name = "Fuentes";
            this.Text = "Fuentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_prueba;
        private System.Windows.Forms.RadioButton rb_f1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_f4;
        private System.Windows.Forms.RadioButton rb_f3;
        private System.Windows.Forms.RadioButton rb_f2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tachado;
        private System.Windows.Forms.RadioButton rb_subrayado;
        private System.Windows.Forms.RadioButton rb_cursiva;
        private System.Windows.Forms.RadioButton rb_negrita;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_12;
        private System.Windows.Forms.RadioButton rb_10;
        private System.Windows.Forms.RadioButton rb_8;
        private System.Windows.Forms.Button Volver;
    }
}