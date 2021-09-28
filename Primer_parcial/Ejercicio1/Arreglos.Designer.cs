
namespace Ejercicio1
{
    partial class Arreglos
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
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.OrdenarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(50, 33);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(121, 23);
            this.EjecutarButton.TabIndex = 0;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 186);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(250, 85);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(121, 186);
            this.listBox2.TabIndex = 3;
            // 
            // OrdenarButton
            // 
            this.OrdenarButton.Location = new System.Drawing.Point(250, 33);
            this.OrdenarButton.Name = "OrdenarButton";
            this.OrdenarButton.Size = new System.Drawing.Size(121, 23);
            this.OrdenarButton.TabIndex = 2;
            this.OrdenarButton.Text = "Ordenar";
            this.OrdenarButton.UseVisualStyleBackColor = true;
            this.OrdenarButton.Click += new System.EventHandler(this.OrdenarButton_Click);
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.OrdenarButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EjecutarButton);
            this.Name = "Arreglos";
            this.Text = "Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button OrdenarButton;
    }
}