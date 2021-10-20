
namespace Empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_incorporacion = new System.Windows.Forms.DateTimePicker();
            this.dt_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.rb_operarios = new System.Windows.Forms.RadioButton();
            this.rb_Jefe = new System.Windows.Forms.RadioButton();
            this.rb_mantenimiento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_mantenimiento = new System.Windows.Forms.Button();
            this.bt_jefe = new System.Windows.Forms.Button();
            this.bt_Operario = new System.Windows.Forms.Button();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Incorporación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puesto: ";
            // 
            // dt_incorporacion
            // 
            this.dt_incorporacion.Location = new System.Drawing.Point(204, 160);
            this.dt_incorporacion.MaxDate = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dt_incorporacion.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dt_incorporacion.Name = "dt_incorporacion";
            this.dt_incorporacion.Size = new System.Drawing.Size(200, 20);
            this.dt_incorporacion.TabIndex = 8;
            this.dt_incorporacion.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            // 
            // dt_nacimiento
            // 
            this.dt_nacimiento.Location = new System.Drawing.Point(204, 131);
            this.dt_nacimiento.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dt_nacimiento.MinDate = new System.DateTime(1965, 1, 1, 0, 0, 0, 0);
            this.dt_nacimiento.Name = "dt_nacimiento";
            this.dt_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dt_nacimiento.TabIndex = 9;
            this.dt_nacimiento.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(94, 30);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(310, 20);
            this.tb_nombre.TabIndex = 10;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(94, 53);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(310, 20);
            this.tb_apellido.TabIndex = 11;
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(94, 83);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(310, 20);
            this.tb_DNI.TabIndex = 12;
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(94, 107);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(310, 20);
            this.tb_correo.TabIndex = 13;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aceptar.Location = new System.Drawing.Point(466, 12);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(92, 38);
            this.bt_aceptar.TabIndex = 14;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // BT_cancelar
            // 
            this.BT_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cancelar.Location = new System.Drawing.Point(466, 56);
            this.BT_cancelar.Name = "BT_cancelar";
            this.BT_cancelar.Size = new System.Drawing.Size(92, 38);
            this.BT_cancelar.TabIndex = 15;
            this.BT_cancelar.Text = "Cancelar";
            this.BT_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Location = new System.Drawing.Point(13, 356);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(0, 13);
            this.lbl_informacion.TabIndex = 16;
            // 
            // rb_operarios
            // 
            this.rb_operarios.AutoSize = true;
            this.rb_operarios.Location = new System.Drawing.Point(16, 248);
            this.rb_operarios.Name = "rb_operarios";
            this.rb_operarios.Size = new System.Drawing.Size(65, 17);
            this.rb_operarios.TabIndex = 17;
            this.rb_operarios.TabStop = true;
            this.rb_operarios.Text = "Operario";
            this.rb_operarios.UseVisualStyleBackColor = true;
            this.rb_operarios.CheckedChanged += new System.EventHandler(this.rb_operarios_CheckedChanged);
            // 
            // rb_Jefe
            // 
            this.rb_Jefe.AutoSize = true;
            this.rb_Jefe.Location = new System.Drawing.Point(16, 273);
            this.rb_Jefe.Name = "rb_Jefe";
            this.rb_Jefe.Size = new System.Drawing.Size(45, 17);
            this.rb_Jefe.TabIndex = 18;
            this.rb_Jefe.TabStop = true;
            this.rb_Jefe.Text = "Jefe";
            this.rb_Jefe.UseVisualStyleBackColor = true;
            this.rb_Jefe.CheckedChanged += new System.EventHandler(this.rb_Jefe_CheckedChanged);
            // 
            // rb_mantenimiento
            // 
            this.rb_mantenimiento.AutoSize = true;
            this.rb_mantenimiento.Location = new System.Drawing.Point(16, 296);
            this.rb_mantenimiento.Name = "rb_mantenimiento";
            this.rb_mantenimiento.Size = new System.Drawing.Size(94, 17);
            this.rb_mantenimiento.TabIndex = 19;
            this.rb_mantenimiento.TabStop = true;
            this.rb_mantenimiento.Text = "Mantenimiento";
            this.rb_mantenimiento.UseVisualStyleBackColor = true;
            this.rb_mantenimiento.CheckedChanged += new System.EventHandler(this.rb_mantenimiento_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_mantenimiento);
            this.groupBox1.Controls.Add(this.bt_jefe);
            this.groupBox1.Controls.Add(this.bt_Operario);
            this.groupBox1.Location = new System.Drawing.Point(466, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // bt_mantenimiento
            // 
            this.bt_mantenimiento.Location = new System.Drawing.Point(7, 71);
            this.bt_mantenimiento.Name = "bt_mantenimiento";
            this.bt_mantenimiento.Size = new System.Drawing.Size(94, 23);
            this.bt_mantenimiento.TabIndex = 2;
            this.bt_mantenimiento.Text = "Mantenimiento";
            this.bt_mantenimiento.UseVisualStyleBackColor = true;
            this.bt_mantenimiento.Click += new System.EventHandler(this.bt_mantenimiento_Click);
            // 
            // bt_jefe
            // 
            this.bt_jefe.Location = new System.Drawing.Point(7, 47);
            this.bt_jefe.Name = "bt_jefe";
            this.bt_jefe.Size = new System.Drawing.Size(94, 23);
            this.bt_jefe.TabIndex = 1;
            this.bt_jefe.Text = "Jefe";
            this.bt_jefe.UseVisualStyleBackColor = true;
            this.bt_jefe.Click += new System.EventHandler(this.bt_jefe_Click);
            // 
            // bt_Operario
            // 
            this.bt_Operario.Location = new System.Drawing.Point(7, 20);
            this.bt_Operario.Name = "bt_Operario";
            this.bt_Operario.Size = new System.Drawing.Size(94, 23);
            this.bt_Operario.TabIndex = 0;
            this.bt_Operario.Text = "Operario";
            this.bt_Operario.UseVisualStyleBackColor = true;
            this.bt_Operario.Click += new System.EventHandler(this.bt_Operario_Click);
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.Location = new System.Drawing.Point(466, 248);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(0, 13);
            this.lbl_busqueda.TabIndex = 21;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_busqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rb_mantenimiento);
            this.Controls.Add(this.rb_Jefe);
            this.Controls.Add(this.rb_operarios);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.BT_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.dt_nacimiento);
            this.Controls.Add(this.dt_incorporacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_incorporacion;
        private System.Windows.Forms.DateTimePicker dt_nacimiento;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.RadioButton rb_operarios;
        private System.Windows.Forms.RadioButton rb_Jefe;
        private System.Windows.Forms.RadioButton rb_mantenimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_mantenimiento;
        private System.Windows.Forms.Button bt_jefe;
        private System.Windows.Forms.Button bt_Operario;
        private System.Windows.Forms.Label lbl_busqueda;
    }
}

