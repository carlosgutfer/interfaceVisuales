
namespace ClaseMala3
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.lbl_mostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(97, 82);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(39, 13);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login: ";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(97, 114);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(36, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Pass: ";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(142, 75);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(229, 20);
            this.txt_login.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(142, 107);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(229, 20);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(296, 169);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 4;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // lbl_mostrar
            // 
            this.lbl_mostrar.AutoSize = true;
            this.lbl_mostrar.Location = new System.Drawing.Point(101, 266);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(0, 13);
            this.lbl_mostrar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_mostrar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_login;
        public System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Label lbl_mostrar;
    }
}

