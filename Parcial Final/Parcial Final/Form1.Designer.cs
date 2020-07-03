namespace FinalParcial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelcontra = new System.Windows.Forms.Label();
            this.btnIniciarsesion = new System.Windows.Forms.Button();
            this.btnCambiarcontrasena = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 259);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 1;
            // 
            // labelusuario
            // 
            this.labelusuario.Location = new System.Drawing.Point(89, 76);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(127, 29);
            this.labelusuario.TabIndex = 2;
            this.labelusuario.Text = "DEPARTAMENTO\r\n";
            this.labelusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcontra
            // 
            this.labelcontra.Location = new System.Drawing.Point(89, 260);
            this.labelcontra.Name = "labelcontra";
            this.labelcontra.Size = new System.Drawing.Size(127, 29);
            this.labelcontra.TabIndex = 3;
            this.labelcontra.Text = "CONTRASENA: \r\n";
            this.labelcontra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.Location = new System.Drawing.Point(323, 351);
            this.btnIniciarsesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.Size = new System.Drawing.Size(163, 72);
            this.btnIniciarsesion.TabIndex = 6;
            this.btnIniciarsesion.Text = "Iniciar sesion";
            this.btnIniciarsesion.UseVisualStyleBackColor = true;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click);
            // 
            // btnCambiarcontrasena
            // 
            this.btnCambiarcontrasena.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarcontrasena.Location = new System.Drawing.Point(67, 351);
            this.btnCambiarcontrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCambiarcontrasena.Name = "btnCambiarcontrasena";
            this.btnCambiarcontrasena.Size = new System.Drawing.Size(171, 72);
            this.btnCambiarcontrasena.TabIndex = 7;
            this.btnCambiarcontrasena.Text = "Cambiar contrasena";
            this.btnCambiarcontrasena.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(311, 174);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(89, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "USUARIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(563, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnCambiarcontrasena);
            this.Controls.Add(this.btnIniciarsesion);
            this.Controls.Add(this.labelcontra);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hospital de El Salvador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCambiarcontrasena;
        private System.Windows.Forms.Button btnIniciarsesion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelcontra;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.TextBox textBox1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}