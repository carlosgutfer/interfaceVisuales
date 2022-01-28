
namespace Editor_de_texto
{
    partial class form_buscar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_buscarSiguiente = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bt_buscarSiguiente
            // 
            this.bt_buscarSiguiente.Location = new System.Drawing.Point(407, 60);
            this.bt_buscarSiguiente.Name = "bt_buscarSiguiente";
            this.bt_buscarSiguiente.Size = new System.Drawing.Size(136, 23);
            this.bt_buscarSiguiente.TabIndex = 1;
            this.bt_buscarSiguiente.Text = "Buscar siguiente";
            this.bt_buscarSiguiente.UseVisualStyleBackColor = true;
            this.bt_buscarSiguiente.Click += new System.EventHandler(this.bt_buscarSiguiente_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelar.Location = new System.Drawing.Point(407, 89);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // form_buscar
            // 
            this.AcceptButton = this.bt_buscarSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancelar;
            this.ClientSize = new System.Drawing.Size(556, 192);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_buscarSiguiente);
            this.Controls.Add(this.textBox1);
            this.Name = "form_buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_buscarSiguiente;
        private System.Windows.Forms.Button bt_cancelar;
    }
}