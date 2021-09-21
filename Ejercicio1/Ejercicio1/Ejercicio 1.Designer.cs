
namespace Ejercicio1
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
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.NumeroParLabel = new System.Windows.Forms.Label();
            this.NumeroImparLabel = new System.Windows.Forms.Label();
            this.NumeroPrimoLabel = new System.Windows.Forms.Label();
            this.ResultadoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número entero: ";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTextBox.Location = new System.Drawing.Point(396, 65);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(69, 27);
            this.NumeroTextBox.TabIndex = 1;
            // 
            // NumeroParLabel
            // 
            this.NumeroParLabel.AutoSize = true;
            this.NumeroParLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroParLabel.Location = new System.Drawing.Point(171, 107);
            this.NumeroParLabel.Name = "NumeroParLabel";
            this.NumeroParLabel.Size = new System.Drawing.Size(13, 21);
            this.NumeroParLabel.TabIndex = 2;
            this.NumeroParLabel.Text = "\'";
            // 
            // NumeroImparLabel
            // 
            this.NumeroImparLabel.AutoSize = true;
            this.NumeroImparLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroImparLabel.Location = new System.Drawing.Point(171, 142);
            this.NumeroImparLabel.Name = "NumeroImparLabel";
            this.NumeroImparLabel.Size = new System.Drawing.Size(13, 21);
            this.NumeroImparLabel.TabIndex = 3;
            this.NumeroImparLabel.Text = "\'";
            // 
            // NumeroPrimoLabel
            // 
            this.NumeroPrimoLabel.AutoSize = true;
            this.NumeroPrimoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroPrimoLabel.Location = new System.Drawing.Point(171, 175);
            this.NumeroPrimoLabel.Name = "NumeroPrimoLabel";
            this.NumeroPrimoLabel.Size = new System.Drawing.Size(13, 21);
            this.NumeroPrimoLabel.TabIndex = 4;
            this.NumeroPrimoLabel.Text = "\'";
            // 
            // ResultadoButton
            // 
            this.ResultadoButton.BackColor = System.Drawing.Color.Purple;
            this.ResultadoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultadoButton.Location = new System.Drawing.Point(175, 218);
            this.ResultadoButton.Name = "ResultadoButton";
            this.ResultadoButton.Size = new System.Drawing.Size(173, 40);
            this.ResultadoButton.TabIndex = 5;
            this.ResultadoButton.Text = "Mostrar resultados";
            this.ResultadoButton.UseVisualStyleBackColor = false;
            this.ResultadoButton.Click += new System.EventHandler(this.ResultadoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "¡Bienvenido! Vamos a determinar  si el valor ingresado es par, impar o primo";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.Color.Purple;
            this.LimpiarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LimpiarButton.Location = new System.Drawing.Point(374, 218);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(91, 40);
            this.LimpiarButton.TabIndex = 7;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 275);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoButton);
            this.Controls.Add(this.NumeroPrimoLabel);
            this.Controls.Add(this.NumeroImparLabel);
            this.Controls.Add(this.NumeroParLabel);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label NumeroParLabel;
        private System.Windows.Forms.Label NumeroImparLabel;
        private System.Windows.Forms.Label NumeroPrimoLabel;
        private System.Windows.Forms.Button ResultadoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LimpiarButton;
    }
}

