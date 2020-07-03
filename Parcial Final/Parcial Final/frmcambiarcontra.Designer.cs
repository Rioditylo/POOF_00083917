using System.ComponentModel;

namespace FinalParcial
{
    partial class frmcambiarcontra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(frmcambiarcontra));
            this.cmbUsuarioCambiarcontra = new System.Windows.Forms.ComboBox();
            this.txtContrasenactual = new System.Windows.Forms.TextBox();
            this.txtContrasenanueva = new System.Windows.Forms.TextBox();
            this.txtRepetirnueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangepassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUsuarioCambiarcontra
            // 
            this.cmbUsuarioCambiarcontra.FormattingEnabled = true;
            this.cmbUsuarioCambiarcontra.Location = new System.Drawing.Point(386, 62);
            this.cmbUsuarioCambiarcontra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsuarioCambiarcontra.Name = "cmbUsuarioCambiarcontra";
            this.cmbUsuarioCambiarcontra.Size = new System.Drawing.Size(159, 28);
            this.cmbUsuarioCambiarcontra.TabIndex = 5;
            // 
            // txtContrasenactual
            // 
            this.txtContrasenactual.Location = new System.Drawing.Point(386, 168);
            this.txtContrasenactual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasenactual.Name = "txtContrasenactual";
            this.txtContrasenactual.Size = new System.Drawing.Size(159, 27);
            this.txtContrasenactual.TabIndex = 6;
            // 
            // txtContrasenanueva
            // 
            this.txtContrasenanueva.Location = new System.Drawing.Point(386, 266);
            this.txtContrasenanueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasenanueva.Name = "txtContrasenanueva";
            this.txtContrasenanueva.Size = new System.Drawing.Size(159, 27);
            this.txtContrasenanueva.TabIndex = 7;
            // 
            // txtRepetirnueva
            // 
            this.txtRepetirnueva.Location = new System.Drawing.Point(386, 362);
            this.txtRepetirnueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepetirnueva.Name = "txtRepetirnueva";
            this.txtRepetirnueva.Size = new System.Drawing.Size(159, 27);
            this.txtRepetirnueva.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(202, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "USUARIO:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(222, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "ACTUAL CONTRA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(222, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONTRA NUEVA:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(222, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "REPITA CONTRA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 449);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 61);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnChangepassword
            // 
            this.btnChangepassword.Location = new System.Drawing.Point(123, 449);
            this.btnChangepassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangepassword.Name = "btnChangepassword";
            this.btnChangepassword.Size = new System.Drawing.Size(138, 61);
            this.btnChangepassword.TabIndex = 14;
            this.btnChangepassword.Text = "Cambiar contrasena";
            this.btnChangepassword.UseVisualStyleBackColor = true;
            this.btnChangepassword.Click += new System.EventHandler(this.btnChangepassword_Click_1);
            // 
            // frmcambiarcontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(614, 572);
            this.Controls.Add(this.btnChangepassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepetirnueva);
            this.Controls.Add(this.txtContrasenanueva);
            this.Controls.Add(this.txtContrasenactual);
            this.Controls.Add(this.cmbUsuarioCambiarcontra);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmcambiarcontra";
            this.Text = "HOSPITAL DE EL SALVADOR";
            this.Load += new System.EventHandler(this.frmcambiarcontra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangepassword;
        private System.Windows.Forms.ComboBox cmbUsuarioCambiarcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasenactual;
        private System.Windows.Forms.TextBox txtContrasenanueva;
        private System.Windows.Forms.TextBox txtRepetirnueva;

        #endregion
    }
}