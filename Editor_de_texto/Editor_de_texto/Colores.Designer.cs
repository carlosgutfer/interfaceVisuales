
namespace Editor_de_texto
{
    partial class Colores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_colorFuente = new System.Windows.Forms.RadioButton();
            this.rb_colorFondo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_colores = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_colorFuente);
            this.groupBox1.Controls.Add(this.rb_colorFondo);
            this.groupBox1.Location = new System.Drawing.Point(38, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colores";
            // 
            // rb_colorFuente
            // 
            this.rb_colorFuente.AutoSize = true;
            this.rb_colorFuente.Location = new System.Drawing.Point(7, 55);
            this.rb_colorFuente.Name = "rb_colorFuente";
            this.rb_colorFuente.Size = new System.Drawing.Size(82, 17);
            this.rb_colorFuente.TabIndex = 1;
            this.rb_colorFuente.Text = "Color fuente";
            this.rb_colorFuente.UseVisualStyleBackColor = true;
            // 
            // rb_colorFondo
            // 
            this.rb_colorFondo.AutoSize = true;
            this.rb_colorFondo.Checked = true;
            this.rb_colorFondo.Location = new System.Drawing.Point(7, 20);
            this.rb_colorFondo.Name = "rb_colorFondo";
            this.rb_colorFondo.Size = new System.Drawing.Size(79, 17);
            this.rb_colorFondo.TabIndex = 0;
            this.rb_colorFondo.TabStop = true;
            this.rb_colorFondo.Text = "Color fondo";
            this.rb_colorFondo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_colores
            // 
            this.tb_colores.Location = new System.Drawing.Point(204, 117);
            this.tb_colores.Name = "tb_colores";
            this.tb_colores.Size = new System.Drawing.Size(100, 20);
            this.tb_colores.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(314, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Colores
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(409, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_colores);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Colores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_colorFuente;
        private System.Windows.Forms.RadioButton rb_colorFondo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tb_colores;
        private System.Windows.Forms.Button button1;
    }
}