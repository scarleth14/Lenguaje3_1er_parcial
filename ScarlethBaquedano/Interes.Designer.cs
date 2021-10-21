
namespace ScarlethBaquedano
{
    partial class Interes
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
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaDeposito = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TasaInteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbx_siguiente = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lvw_interes = new System.Windows.Forms.ListView();
            this.Mes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbx_siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Déposito inicial";
            // 
            // txt_deposito
            // 
            this.txt_deposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deposito.Location = new System.Drawing.Point(246, 201);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.Size = new System.Drawing.Size(120, 27);
            this.txt_deposito.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha déposito";
            // 
            // dtp_fechaDeposito
            // 
            this.dtp_fechaDeposito.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaDeposito.Location = new System.Drawing.Point(246, 153);
            this.dtp_fechaDeposito.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaDeposito.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaDeposito.Name = "dtp_fechaDeposito";
            this.dtp_fechaDeposito.Size = new System.Drawing.Size(120, 27);
            this.dtp_fechaDeposito.TabIndex = 3;
            this.dtp_fechaDeposito.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Los intereses ganados de enero a diciembre son los siguientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tasa de interés";
            // 
            // txt_TasaInteres
            // 
            this.txt_TasaInteres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TasaInteres.Location = new System.Drawing.Point(520, 170);
            this.txt_TasaInteres.Name = "txt_TasaInteres";
            this.txt_TasaInteres.Size = new System.Drawing.Size(78, 27);
            this.txt_TasaInteres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Milasian Circa Bold PERSONAL", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 43);
            this.label5.TabIndex = 11;
            this.label5.Text = "Institución Financiera \"RBS\"";
            // 
            // pbx_siguiente
            // 
            this.pbx_siguiente.BackgroundImage = global::ScarlethBaquedano.Properties.Resources.icons8_flecha_adelante_100;
            this.pbx_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_siguiente.Location = new System.Drawing.Point(623, 153);
            this.pbx_siguiente.Name = "pbx_siguiente";
            this.pbx_siguiente.Size = new System.Drawing.Size(108, 109);
            this.pbx_siguiente.TabIndex = 25;
            this.pbx_siguiente.TabStop = false;
            this.pbx_siguiente.Click += new System.EventHandler(this.pbx_siguiente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ScarlethBaquedano.Properties.Resources.InstitucionFinanciera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(99, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 121);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpiar.Image = global::ScarlethBaquedano.Properties.Resources.bin_trash_delete_remove_recycle_icon_146878;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(555, 383);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(176, 115);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar ";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.btn_mostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.Image = global::ScarlethBaquedano.Properties.Resources.view_show_icon_124811;
            this.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mostrar.Location = new System.Drawing.Point(555, 278);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(176, 84);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar ";
            this.btn_mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lvw_interes
            // 
            this.lvw_interes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mes,
            this.columnHeader1});
            this.lvw_interes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_interes.HideSelection = false;
            this.lvw_interes.Location = new System.Drawing.Point(23, 278);
            this.lvw_interes.Name = "lvw_interes";
            this.lvw_interes.Size = new System.Drawing.Size(510, 193);
            this.lvw_interes.TabIndex = 27;
            this.lvw_interes.UseCompatibleStateImageBehavior = false;
            this.lvw_interes.View = System.Windows.Forms.View.Details;
            // 
            // Mes
            // 
            this.Mes.Text = "Mes";
            this.Mes.Width = 250;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Interés ganado";
            this.columnHeader1.Width = 250;
            // 
            // Interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(751, 510);
            this.Controls.Add(this.lvw_interes);
            this.Controls.Add(this.pbx_siguiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_TasaInteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fechaDeposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_deposito);
            this.Controls.Add(this.label1);
            this.Name = "Interes";
            this.Text = "Interés";
            this.Load += new System.EventHandler(this.Interes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_deposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TasaInteres;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbx_siguiente;
        private System.Windows.Forms.ListView lvw_interes;
        private System.Windows.Forms.ColumnHeader Mes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

