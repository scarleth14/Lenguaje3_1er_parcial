
namespace POO
{
    partial class CuentaBancaria
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
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrearCuentaButton = new System.Windows.Forms.Button();
            this.AgregarMovimientoButton = new System.Windows.Forms.Button();
            this.MovimientosListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdentidadTextBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(119, 38);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(143, 27);
            this.IdentidadTextBox.TabIndex = 10;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(119, 81);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(143, 27);
            this.NombreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumeroCuentaTextBox);
            this.groupBox2.Controls.Add(this.SaldoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // NumeroCuentaTextBox
            // 
            this.NumeroCuentaTextBox.Location = new System.Drawing.Point(156, 32);
            this.NumeroCuentaTextBox.Name = "NumeroCuentaTextBox";
            this.NumeroCuentaTextBox.Size = new System.Drawing.Size(143, 27);
            this.NumeroCuentaTextBox.TabIndex = 4;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(156, 81);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(143, 27);
            this.SaldoTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número cuenta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimientoComboBox);
            this.groupBox3.Controls.Add(this.MontoTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 95);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar movimiento";
            // 
            // TipoMovimientoComboBox
            // 
            this.TipoMovimientoComboBox.FormattingEnabled = true;
            this.TipoMovimientoComboBox.Items.AddRange(new object[] {
            "Depósito",
            "Retiro"});
            this.TipoMovimientoComboBox.Location = new System.Drawing.Point(510, 41);
            this.TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            this.TipoMovimientoComboBox.Size = new System.Drawing.Size(192, 29);
            this.TipoMovimientoComboBox.TabIndex = 5;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(102, 41);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(195, 27);
            this.MontoTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo de movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Monto";
            // 
            // CrearCuentaButton
            // 
            this.CrearCuentaButton.BackColor = System.Drawing.Color.Purple;
            this.CrearCuentaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCuentaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CrearCuentaButton.Location = new System.Drawing.Point(789, 63);
            this.CrearCuentaButton.Name = "CrearCuentaButton";
            this.CrearCuentaButton.Size = new System.Drawing.Size(161, 65);
            this.CrearCuentaButton.TabIndex = 7;
            this.CrearCuentaButton.Text = "Crear cuenta";
            this.CrearCuentaButton.UseVisualStyleBackColor = false;
            this.CrearCuentaButton.Click += new System.EventHandler(this.CrearCuentaButton_Click);
            // 
            // AgregarMovimientoButton
            // 
            this.AgregarMovimientoButton.BackColor = System.Drawing.Color.Purple;
            this.AgregarMovimientoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMovimientoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AgregarMovimientoButton.Location = new System.Drawing.Point(789, 196);
            this.AgregarMovimientoButton.Name = "AgregarMovimientoButton";
            this.AgregarMovimientoButton.Size = new System.Drawing.Size(161, 65);
            this.AgregarMovimientoButton.TabIndex = 8;
            this.AgregarMovimientoButton.Text = "Agregar movimiento";
            this.AgregarMovimientoButton.UseVisualStyleBackColor = false;
            // 
            // MovimientosListBox
            // 
            this.MovimientosListBox.BackColor = System.Drawing.Color.White;
            this.MovimientosListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovimientosListBox.FormattingEnabled = true;
            this.MovimientosListBox.ItemHeight = 21;
            this.MovimientosListBox.Location = new System.Drawing.Point(29, 295);
            this.MovimientosListBox.Name = "MovimientosListBox";
            this.MovimientosListBox.Size = new System.Drawing.Size(722, 214);
            this.MovimientosListBox.TabIndex = 9;
            // 
            // CuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(974, 551);
            this.Controls.Add(this.MovimientosListBox);
            this.Controls.Add(this.AgregarMovimientoButton);
            this.Controls.Add(this.CrearCuentaButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuentaBancaria";
            this.Text = "CuentaBancaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumeroCuentaTextBox;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CrearCuentaButton;
        private System.Windows.Forms.Button AgregarMovimientoButton;
        private System.Windows.Forms.ListBox MovimientosListBox;
        private System.Windows.Forms.ComboBox TipoMovimientoComboBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
    }
}