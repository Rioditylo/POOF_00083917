using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FinalParcial.ClaseBD;

using FinalParcial.Model;
using FinalParcial.Strategy;

namespace FinalParcial
{
    public partial class frmVigilant : Form
    {
        private User u;
        private Registry R;
        private IStrategy mainStrategy = new SEmployee();
        List<string> keys = new List<string>();
        public frmVigilant()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = false;
            timer1.Start();
            tabPage1.Text = "Control";
            tabPage2.Text = "Historial";
            foreach (DataRow row in mainStrategy.show().Rows)
            {
                comboBox1.Items.Add(row[0].ToString()+" - "+row[3].ToString());
                keys.Add(row[0].ToString());
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToLongDateString();
            dataGridView1.DataSource = Connection.Query("select * from registro");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No puede estar vacia la temperatura");
                return;
            }
            
            if (Convert.ToDouble(textBox1.Text)<=37 )
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label3.Text = "Hora de entrada = "+DateTime.Now.ToString("hh:mm:ss")+" Temperatura:"+textBox1.Text;
                            RegisterController.add(Convert.ToInt32(keys[comboBox1.SelectedIndex]),DateTime.Now.ToString("hh:mm:ss")+
                                                                                                  "-"+DateTime.Now.ToShortDateString(),
                                Convert.ToInt32(textBox1.Text),true);
            }
            else
            {
                MessageBox.Show("Tienes la temperatura muy alta no puedes entrar asi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("No puede estar vacia la temperatura");
                return;
            }
            if (Convert.ToDouble(textBox2.Text)<=37 )
            {
                button2.Enabled = false;
                MessageBox.Show("Se registro tu hora de salida con exito "+DateTime.Now.ToString("hh:mm:ss"));
                RegisterController.add(Convert.ToInt32(keys[comboBox1.SelectedIndex]),DateTime.Now.ToString("hh:mm:ss")+
                                                                                      "-"+DateTime.Now.ToShortDateString(),
                    Convert.ToInt32(textBox2.Text),false);
            }
            else
            {
                MessageBox.Show("Tienes la temperatura muy alta no puedes entrar asi.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(
                RegisterController.count(Convert.ToInt32(keys[comboBox1.SelectedIndex])).Rows[0][0]
                    .ToString());
            if (num % 2 ==0)
            {
                button1.Enabled = true;
                //textBox1.Enabled = true;
                button2.Enabled = false;
                //textBox2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
                //textBox1.Enabled = false;
            }
        }
    }
    
}