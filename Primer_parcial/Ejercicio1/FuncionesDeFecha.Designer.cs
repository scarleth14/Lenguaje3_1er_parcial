
namespace Ejercicio1
{
    partial class FuncionesDeFecha
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
            this.components = new System.ComponentModel.Container();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroDiaTextBox = new System.Windows.Forms.TextBox();
            this.NumeroMesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NuevaFechaConDiasTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AgregarDiasTextBox = new System.Windows.Forms.TextBox();
            this.RestarDiasTextBox = new System.Windows.Forms.TextBox();
            this.NuevaFechaRestadaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HoraLabel = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(200, 28);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(125, 22);
            this.FechadateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ejecutarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton.Location = new System.Drawing.Point(393, 107);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(122, 48);
            this.Ejecutarbutton.TabIndex = 2;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = false;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de día: ";
            // 
            // NumeroDiaTextBox
            // 
            this.NumeroDiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDiaTextBox.Location = new System.Drawing.Point(196, 66);
            this.NumeroDiaTextBox.Name = "NumeroDiaTextBox";
            this.NumeroDiaTextBox.ReadOnly = true;
            this.NumeroDiaTextBox.Size = new System.Drawing.Size(152, 22);
            this.NumeroDiaTextBox.TabIndex = 4;
            // 
            // NumeroMesTextBox
            // 
            this.NumeroMesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroMesTextBox.Location = new System.Drawing.Point(196, 100);
            this.NumeroMesTextBox.Name = "NumeroMesTextBox";
            this.NumeroMesTextBox.ReadOnly = true;
            this.NumeroMesTextBox.Size = new System.Drawing.Size(152, 22);
            this.NumeroMesTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de mes: ";
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnioTextBox.Location = new System.Drawing.Point(196, 135);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.ReadOnly = true;
            this.AnioTextBox.Size = new System.Drawing.Size(152, 22);
            this.AnioTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año: ";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraTextBox.Location = new System.Drawing.Point(196, 172);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.ReadOnly = true;
            this.HoraTextBox.Size = new System.Drawing.Size(152, 22);
            this.HoraTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora: ";
            // 
            // MesTextBox
            // 
            this.MesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesTextBox.Location = new System.Drawing.Point(196, 207);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.ReadOnly = true;
            this.MesTextBox.Size = new System.Drawing.Size(152, 22);
            this.MesTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre del mes: ";
            // 
            // NuevaFechaConDiasTextBox
            // 
            this.NuevaFechaConDiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaFechaConDiasTextBox.Location = new System.Drawing.Point(242, 247);
            this.NuevaFechaConDiasTextBox.Name = "NuevaFechaConDiasTextBox";
            this.NuevaFechaConDiasTextBox.ReadOnly = true;
            this.NuevaFechaConDiasTextBox.Size = new System.Drawing.Size(106, 22);
            this.NuevaFechaConDiasTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Agregar días a la fecha ";
            // 
            // AgregarDiasTextBox
            // 
            this.AgregarDiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarDiasTextBox.Location = new System.Drawing.Point(196, 247);
            this.AgregarDiasTextBox.Name = "AgregarDiasTextBox";
            this.AgregarDiasTextBox.Size = new System.Drawing.Size(40, 22);
            this.AgregarDiasTextBox.TabIndex = 15;
            // 
            // RestarDiasTextBox
            // 
            this.RestarDiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestarDiasTextBox.Location = new System.Drawing.Point(196, 281);
            this.RestarDiasTextBox.Name = "RestarDiasTextBox";
            this.RestarDiasTextBox.Size = new System.Drawing.Size(40, 22);
            this.RestarDiasTextBox.TabIndex = 18;
            // 
            // NuevaFechaRestadaTextBox
            // 
            this.NuevaFechaRestadaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaFechaRestadaTextBox.Location = new System.Drawing.Point(242, 281);
            this.NuevaFechaRestadaTextBox.Name = "NuevaFechaRestadaTextBox";
            this.NuevaFechaRestadaTextBox.ReadOnly = true;
            this.NuevaFechaRestadaTextBox.Size = new System.Drawing.Size(106, 22);
            this.NuevaFechaRestadaTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restar días a la fecha ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HoraLabel.Location = new System.Drawing.Point(390, 66);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(51, 16);
            this.HoraLabel.TabIndex = 19;
            this.HoraLabel.Text = "label9";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadTextBox.Location = new System.Drawing.Point(196, 316);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.ReadOnly = true;
            this.EdadTextBox.Size = new System.Drawing.Size(152, 22);
            this.EdadTextBox.TabIndex = 21;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(41, 322);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(47, 16);
            this.Edad.TabIndex = 20;
            this.Edad.Text = "Edad: ";
            // 
            // FuncionesDeFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 355);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.HoraLabel);
            this.Controls.Add(this.RestarDiasTextBox);
            this.Controls.Add(this.NuevaFechaRestadaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AgregarDiasTextBox);
            this.Controls.Add(this.NuevaFechaConDiasTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumeroMesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumeroDiaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Name = "FuncionesDeFecha";
            this.Text = "FuncionesDeFecha";
            this.Load += new System.EventHandler(this.FuncionesDeFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroDiaTextBox;
        private System.Windows.Forms.TextBox NumeroMesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NuevaFechaConDiasTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AgregarDiasTextBox;
        private System.Windows.Forms.TextBox RestarDiasTextBox;
        private System.Windows.Forms.TextBox NuevaFechaRestadaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label Edad;
    }
}