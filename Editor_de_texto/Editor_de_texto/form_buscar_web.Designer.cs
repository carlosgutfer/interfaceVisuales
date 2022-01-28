
namespace Editor_de_texto
{
    partial class form_buscar_web
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
            this.bt_buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.web1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(342, 52);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(81, 32);
            this.bt_buscar.TabIndex = 0;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 1;
            // 
            // web1
            // 
            this.web1.Location = new System.Drawing.Point(71, 90);
            this.web1.MinimumSize = new System.Drawing.Size(20, 20);
            this.web1.Name = "web1";
            this.web1.Size = new System.Drawing.Size(503, 324);
            this.web1.TabIndex = 2;
            this.web1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.web1_Navigated);
            // 
            // form_buscar_web
            // 
            this.AcceptButton = this.bt_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 438);
            this.Controls.Add(this.web1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_buscar);
            this.Name = "form_buscar_web";
            this.Text = "Buscar en web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser web1;
    }
}