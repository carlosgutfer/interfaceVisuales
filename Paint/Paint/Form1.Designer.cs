
namespace Paint
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_octal = new System.Windows.Forms.RadioButton();
            this.rb_decimal = new System.Windows.Forms.RadioButton();
            this.rb_binario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(116, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 206);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rb_octal
            // 
            this.rb_octal.AutoSize = true;
            this.rb_octal.Location = new System.Drawing.Point(89, 64);
            this.rb_octal.Name = "rb_octal";
            this.rb_octal.Size = new System.Drawing.Size(50, 17);
            this.rb_octal.TabIndex = 2;
            this.rb_octal.Text = "Octal";
            this.rb_octal.UseVisualStyleBackColor = true;
            this.rb_octal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_decimal
            // 
            this.rb_decimal.AutoSize = true;
            this.rb_decimal.Checked = true;
            this.rb_decimal.Location = new System.Drawing.Point(203, 64);
            this.rb_decimal.Name = "rb_decimal";
            this.rb_decimal.Size = new System.Drawing.Size(63, 17);
            this.rb_decimal.TabIndex = 3;
            this.rb_decimal.TabStop = true;
            this.rb_decimal.Text = "Decimal";
            this.rb_decimal.UseVisualStyleBackColor = true;
            this.rb_decimal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_binario
            // 
            this.rb_binario.AutoSize = true;
            this.rb_binario.Location = new System.Drawing.Point(311, 64);
            this.rb_binario.Name = "rb_binario";
            this.rb_binario.Size = new System.Drawing.Size(57, 17);
            this.rb_binario.TabIndex = 4;
            this.rb_binario.TabStop = true;
            this.rb_binario.Text = "Binario";
            this.rb_binario.UseVisualStyleBackColor = true;
            this.rb_binario.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_binario);
            this.Controls.Add(this.rb_decimal);
            this.Controls.Add(this.rb_octal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_octal;
        private System.Windows.Forms.RadioButton rb_decimal;
        private System.Windows.Forms.RadioButton rb_binario;
    }
}

