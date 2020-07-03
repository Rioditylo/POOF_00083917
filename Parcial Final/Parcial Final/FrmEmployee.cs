using System;
using System.Windows.Forms;
using FinalParcial.ClaseBD;
using FinalParcial.Model;

namespace FinalParcial
{
    public partial class FrmEmployee : Form
    {
        private User u;
        public FrmEmployee(User u)
        {
            this.u = u;
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=Connection.Query($"select * from registro where idusuario={u.idUser} order by temperatura");
        }
    }
}