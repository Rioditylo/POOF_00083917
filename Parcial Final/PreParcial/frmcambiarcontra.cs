using System;
using System.Windows.Forms;
using FinalParcial.Clasescomunes;

namespace FinalParcial
{
    public partial class frmcambiarcontra : Form
    {
        public frmcambiarcontra()
        {
            InitializeComponent();
        }


        private void frmcambiarcontra_Load(object sender, EventArgs e)
        {
            cmbUsuarioCambiarcontra.DataSource = null;
            cmbUsuarioCambiarcontra.ValueMember = "contrasenia";
            cmbUsuarioCambiarcontra.DisplayMember = "name";
            cmbUsuarioCambiarcontra.DataSource = AddUsuario.GetLista();
        }

        

       

        private void btnChangepassword_Click_1(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuarioCambiarcontra.SelectedValue.Equals(txtContrasenactual.Text);
            bool nuevaIgual = txtContrasenanueva.Text.Equals(txtRepetirnueva.Text);
            bool nuevaValida = txtContrasenanueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    AddUsuario.Changepassword(cmbUsuarioCambiarcontra.Text, txtContrasenanueva.Text);
                    
                    MessageBox.Show("SE actualizo la contrasena", 
                        "Parcialfinal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Contrasena mas actualizada", 
                        "Parcialfinal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Verifique los datos!", 
                    "Parcialfinal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}