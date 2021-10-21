
namespace Ejercicio2
{
    partial class DespachoLegal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DespachoLegal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_codigoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpedienteClienteListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_EnviarSolicitud = new System.Windows.Forms.Button();
            this.cb_TrabajoSolicitado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SolicitudTrabajoListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigoCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_AgregarCliente);
            this.groupBox1.Controls.Add(this.txt_edad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_CorreoElectronico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_genero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_FechaNacimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(292, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación expediente cliente";
            // 
            // txt_codigoCliente
            // 
            this.txt_codigoCliente.Location = new System.Drawing.Point(199, 37);
            this.txt_codigoCliente.Name = "txt_codigoCliente";
            this.txt_codigoCliente.ReadOnly = true;
            this.txt_codigoCliente.Size = new System.Drawing.Size(67, 27);
            this.txt_codigoCliente.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Código";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(160)))), ((int)(((byte)(252)))));
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(475, 185);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 54);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar datos";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(160)))), ((int)(((byte)(252)))));
            this.btn_AgregarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(475, 115);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(98, 54);
            this.btn_AgregarCliente.TabIndex = 12;
            this.btn_AgregarCliente.Text = "Agregar cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(506, 34);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.ReadOnly = true;
            this.txt_edad.Size = new System.Drawing.Size(67, 27);
            this.txt_edad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edad";
            // 
            // txt_CorreoElectronico
            // 
            this.txt_CorreoElectronico.Location = new System.Drawing.Point(199, 212);
            this.txt_CorreoElectronico.Name = "txt_CorreoElectronico";
            this.txt_CorreoElectronico.Size = new System.Drawing.Size(207, 27);
            this.txt_CorreoElectronico.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo eléctronico";
            // 
            // cb_genero
            // 
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cb_genero.Location = new System.Drawing.Point(199, 167);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(207, 29);
            this.cb_genero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Género";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(199, 80);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(207, 27);
            this.dtp_FechaNacimiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(199, 124);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 27);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // ExpedienteClienteListBox
            // 
            this.ExpedienteClienteListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpedienteClienteListBox.FormattingEnabled = true;
            this.ExpedienteClienteListBox.ItemHeight = 21;
            this.ExpedienteClienteListBox.Location = new System.Drawing.Point(4, 294);
            this.ExpedienteClienteListBox.Name = "ExpedienteClienteListBox";
            this.ExpedienteClienteListBox.Size = new System.Drawing.Size(975, 151);
            this.ExpedienteClienteListBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rickon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "Despacho ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rickon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "\"LegisCorp\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_NombreCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_EnviarSolicitud);
            this.groupBox2.Controls.Add(this.cb_TrabajoSolicitado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 248);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solicitud trabajo cliente";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(116, 43);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(13, 21);
            this.lbl_NombreCliente.TabIndex = 15;
            this.lbl_NombreCliente.Text = "\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre: ";
            // 
            // btn_EnviarSolicitud
            // 
            this.btn_EnviarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(160)))), ((int)(((byte)(252)))));
            this.btn_EnviarSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarSolicitud.Location = new System.Drawing.Point(144, 175);
            this.btn_EnviarSolicitud.Name = "btn_EnviarSolicitud";
            this.btn_EnviarSolicitud.Size = new System.Drawing.Size(105, 56);
            this.btn_EnviarSolicitud.TabIndex = 2;
            this.btn_EnviarSolicitud.Text = "Enviar solicitud";
            this.btn_EnviarSolicitud.UseVisualStyleBackColor = false;
            this.btn_EnviarSolicitud.Click += new System.EventHandler(this.btn_EnviarSolicitud_Click);
            // 
            // cb_TrabajoSolicitado
            // 
            this.cb_TrabajoSolicitado.FormattingEnabled = true;
            this.cb_TrabajoSolicitado.Items.AddRange(new object[] {
            "Asesoría legal",
            "Elaboración de contratos",
            "Litigios",
            "Divorcios"});
            this.cb_TrabajoSolicitado.Location = new System.Drawing.Point(71, 119);
            this.cb_TrabajoSolicitado.Name = "cb_TrabajoSolicitado";
            this.cb_TrabajoSolicitado.Size = new System.Drawing.Size(261, 29);
            this.cb_TrabajoSolicitado.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccione el trabajo que solicita";
            // 
            // SolicitudTrabajoListBox
            // 
            this.SolicitudTrabajoListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolicitudTrabajoListBox.FormattingEnabled = true;
            this.SolicitudTrabajoListBox.ItemHeight = 21;
            this.SolicitudTrabajoListBox.Location = new System.Drawing.Point(505, 478);
            this.SolicitudTrabajoListBox.Name = "SolicitudTrabajoListBox";
            this.SolicitudTrabajoListBox.Size = new System.Drawing.Size(474, 235);
            this.SolicitudTrabajoListBox.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DespachoLegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(991, 782);
            this.Controls.Add(this.SolicitudTrabajoListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExpedienteClienteListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DespachoLegal";
            this.Text = "DespachoLegal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CorreoElectronico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ExpedienteClienteListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_EnviarSolicitud;
        private System.Windows.Forms.ComboBox cb_TrabajoSolicitado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox SolicitudTrabajoListBox;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_codigoCliente;
        private System.Windows.Forms.Label label10;
    }
}

