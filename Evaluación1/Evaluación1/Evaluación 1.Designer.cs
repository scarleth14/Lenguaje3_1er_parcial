
namespace Evaluación1
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
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.VentasPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AniosLaboralesLabel = new System.Windows.Forms.Label();
            this.AniosAntiguedadTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SalarioNuevoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.AumentoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalarioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(329, 144);
            this.FechaNacimientoDateTimePicker.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.FechaNacimientoDateTimePicker.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(126, 27);
            this.FechaNacimientoDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de nacimiento del empleado: ";
            // 
            // VentasPromedioTextBox
            // 
            this.VentasPromedioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasPromedioTextBox.Location = new System.Drawing.Point(329, 189);
            this.VentasPromedioTextBox.Name = "VentasPromedioTextBox";
            this.VentasPromedioTextBox.Size = new System.Drawing.Size(100, 27);
            this.VentasPromedioTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor de las ventas promedio: ";
            // 
            // AniosLaboralesLabel
            // 
            this.AniosLaboralesLabel.AutoSize = true;
            this.AniosLaboralesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AniosLaboralesLabel.Location = new System.Drawing.Point(25, 238);
            this.AniosLaboralesLabel.Name = "AniosLaboralesLabel";
            this.AniosLaboralesLabel.Size = new System.Drawing.Size(177, 21);
            this.AniosLaboralesLabel.TabIndex = 4;
            this.AniosLaboralesLabel.Text = "Años de antigüedad:";
            // 
            // AniosAntiguedadTextBox
            // 
            this.AniosAntiguedadTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AniosAntiguedadTextBox.Location = new System.Drawing.Point(329, 235);
            this.AniosAntiguedadTextBox.Name = "AniosAntiguedadTextBox";
            this.AniosAntiguedadTextBox.Size = new System.Drawing.Size(100, 27);
            this.AniosAntiguedadTextBox.TabIndex = 5;
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.Color.Orchid;
            this.CalcularButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(163, 365);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(106, 50);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LimpiarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(323, 365);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(106, 50);
            this.LimpiarButton.TabIndex = 7;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // SalarioNuevoLabel
            // 
            this.SalarioNuevoLabel.AutoSize = true;
            this.SalarioNuevoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioNuevoLabel.Location = new System.Drawing.Point(194, 286);
            this.SalarioNuevoLabel.Name = "SalarioNuevoLabel";
            this.SalarioNuevoLabel.Size = new System.Drawing.Size(13, 21);
            this.SalarioNuevoLabel.TabIndex = 9;
            this.SalarioNuevoLabel.Text = "\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edad:";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadTextBox.Location = new System.Drawing.Point(545, 146);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.ReadOnly = true;
            this.EdadTextBox.Size = new System.Drawing.Size(60, 27);
            this.EdadTextBox.TabIndex = 12;
            // 
            // AumentoLabel
            // 
            this.AumentoLabel.AutoSize = true;
            this.AumentoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AumentoLabel.Location = new System.Drawing.Point(194, 329);
            this.AumentoLabel.Name = "AumentoLabel";
            this.AumentoLabel.Size = new System.Drawing.Size(13, 21);
            this.AumentoLabel.TabIndex = 13;
            this.AumentoLabel.Text = "\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salario del empleado: ";
            // 
            // SalarioTextBox
            // 
            this.SalarioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioTextBox.Location = new System.Drawing.Point(329, 93);
            this.SalarioTextBox.Name = "SalarioTextBox";
            this.SalarioTextBox.Size = new System.Drawing.Size(100, 27);
            this.SalarioTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "¡Bienvenido! Vamos a determinar si un empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "tiene un aumento de salario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Evaluación1.Properties.Resources.moneda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(456, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 124);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(638, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalarioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AumentoLabel);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioNuevoLabel);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.AniosAntiguedadTextBox);
            this.Controls.Add(this.AniosLaboralesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VentasPromedioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Name = "Form1";
            this.Text = "Evaluación 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VentasPromedioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AniosLaboralesLabel;
        private System.Windows.Forms.TextBox AniosAntiguedadTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label SalarioNuevoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label AumentoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalarioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

