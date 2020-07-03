using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FinalParcial.ClaseBD;
using FinalParcial.Exception;
using FinalParcial.Strategy;

namespace FinalParcial
{
    public partial class frmAdmi : Form
    {
        private IStrategy mainStrategy= new SAdmin();
        
        public frmAdmi()
        {
            InitializeComponent();
        }

        private void frmAdmi_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("1-Administrador");
            list.Add("2-Vigilante");
            list.Add("3-Empleado");
            comboBoxDepAdd.DataSource = list;
            comboBoxView.DataSource = list;
            comboBoxDepModify.DataSource = list;
            comboBoxDeleteDep.DataSource = list;
            comboBoxNewDep.Items.Add("1-Administrador");
            comboBoxNewDep.Items.Add("2-Vigilante");
            comboBoxNewDep.Items.Add("3-Empleado");
            for (int i = 1940; i < 2021; i++)
            {
                comboBoxAño.Items.Add(i.ToString());
            }
            for (int i = 1; i < 13; i++)
            {
                comboBoxMonth.Items.Add(i.ToString());
            }
            dataGridView1.DataSource=Connection.Query("select * from registro");
            string query = Connection
                .Query(
                    "SELECT d.nombre, count(u.iddedepartamento) as frecuencia FROM REGISTRO r, DEPARTAMENTO d, usuario u WHERE r.idUsuario = u.idUsuario AND d.idDepartamento = u.iddedepartamento GROUP BY d.idDepartamento ORDER BY frecuencia DESC LIMIT 1;")
                .Rows[0][0].ToString();
            label15.Text = "Mas activa: " +query;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label18_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals("")||
                textBoxDUI.Text.Equals("")||
                textBoxLastName.Text.Equals("")||
                textBoxPSS.Text.Equals(""))
            {
                MessageBox.Show("El Campo no puede estar vacio");
            }
            else
            {
                List<string> listU = new List<string>();
                listU.Add(textBoxName.Text);
                listU.Add(textBoxLastName.Text);
                listU.Add(textBoxPSS.Text);
                listU.Add(textBoxDUI.Text);
                listU.Add(comboBoxAño.Text+"/"+comboBoxMonth.Text+"/"+comboBoxDay.Text);
                
                
                switch (comboBoxView.SelectedIndex)
                {
                    case 0:
                        mainStrategy = new SAdmin();
                        break;
                    case 1:
                        mainStrategy = new SVigilant();
                        break;
                    case 2:
                        mainStrategy = new SEmployee();
                        break;
                }

                try
                {
                    mainStrategy.add(listU);
                    MessageBox.Show("FUE AGREGADO CON EXITO!!!");
                }
                catch (System.Exception )
                {
                    MessageBox.Show("OCURRIO UN ERROR");
                }
            }
        }

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxView.SelectedIndex)
            {
                case 0:
                    mainStrategy = new SAdmin();
                    
                    break;
                case 1:
                    mainStrategy = new SVigilant();
                    break;
                case 2:
                    mainStrategy = new SEmployee();
                    break;
            }
            dataGridView.DataSource= mainStrategy.show();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDay.Items.Clear();
            if (comboBoxMonth.SelectedIndex==2)
            {
                for (int i = 1; i < 30; i++)
                { 
                    comboBoxDay.Items.Add(i.ToString()); 
                }
            }
            if (comboBoxMonth.SelectedIndex==1 || comboBoxMonth.SelectedIndex==3
                                               || comboBoxMonth.SelectedIndex==5
                                               || comboBoxMonth.SelectedIndex==7
                                               || comboBoxMonth.SelectedIndex==8
                                               || comboBoxMonth.SelectedIndex==10
                                               || comboBoxMonth.SelectedIndex==12)
            {
                for (int i = 1; i < 32; i++)
                { 
                    comboBoxDay.Items.Add(i.ToString()); 
                }
            }
            if (comboBoxMonth.SelectedIndex==1 || comboBoxMonth.SelectedIndex==4
                                               || comboBoxMonth.SelectedIndex==6
                                               || comboBoxMonth.SelectedIndex==11)
            {
                for (int i = 1; i < 31; i++)
                { 
                    comboBoxDay.Items.Add(i.ToString()); 
                }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private List<string> keys;
        private void comboBoxDepModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDepModify.SelectedIndex)
            {
                case 0:
                    mainStrategy = new SAdmin();
                    
                    break;
                case 1:
                    mainStrategy = new SVigilant();
                    break;
                case 2:
                    mainStrategy = new SEmployee();
                    break;
            }
            comboBox9.Items.Clear();
            keys = new List<string>();
            foreach (DataRow row in mainStrategy.show().Rows)
            {
                comboBox9.Items.Add(row[0].ToString()+" - "+row[3].ToString());
               keys.Add(row[0].ToString());
            }
            //comboBox9.DataSource= mainStrategy.show().Rows;
        }

        private void button2_Click(object sender, EventArgs e )
        {
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACIOS");
            }
            else
            {
                switch (comboBoxDepModify.SelectedIndex)
                {
                    case 0:
                        mainStrategy = new SAdmin();
                        break;
                    case 1:
                        mainStrategy = new SVigilant();
                        break;
                    case 2:
                        mainStrategy = new SEmployee();
                        break;
                }
                try
                {
                    mainStrategy.update((comboBoxNewDep.SelectedIndex+1).ToString(),textBox5.Text,keys[comboBox9.SelectedIndex]);
                    MessageBox.Show("SE ACTUALIZO CON EXITO! ");
                }
                catch (System.Exception )
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mainStrategy.delete(Convert.ToInt32(keys[comboBox5.SelectedIndex]));
                MessageBox.Show("Se elimino con exito");
            }
            catch ( System.Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBoxDeleteDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDeleteDep.SelectedIndex)
            {
                case 0:
                    mainStrategy = new SAdmin();
                    
                    break;
                case 1:
                    mainStrategy = new SVigilant();
                    break;
                case 2:
                    mainStrategy = new SEmployee();
                    break;
            }   
            keys.Clear();
            comboBox5.Items.Clear();
            foreach (DataRow row in mainStrategy.show().Rows)
            {
                comboBox5.Items.Add(row[0].ToString()+" - "+row[3].ToString());
                keys.Add(row[0].ToString());
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}