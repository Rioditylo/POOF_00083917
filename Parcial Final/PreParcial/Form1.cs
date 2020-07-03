using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalParcial.ClaseBD;
using FinalParcial.Exception;
using FinalParcial.Model;

namespace FinalParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1. Administrador");
            comboBox1.Items.Add("2. Vigilante");
            comboBox1.Items.Add("3. Empleado");
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private List<User> list;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.Clear();
                    EmployeeController.Users(1).ForEach(f=>
                        comboBox2.Items.Add(f.name+" "+f.lastname+"-"+f.dui)
                        );
                    list = EmployeeController.Users(1);
                    break;
                case 1:
                    comboBox2.Items.Clear();
                    EmployeeController.Users(2).ForEach(f=>
                        comboBox2.Items.Add(f.name+" "+f.lastname+"-"+f.dui)
                    );
                    list = EmployeeController.Users(2);
                    break;
                case 2:
                    comboBox2.Items.Clear();
                    EmployeeController.Users(3).ForEach(f=>
                        comboBox2.Items.Add(f.name+" "+f.lastname+"-"+f.dui)
                    );
                    list = EmployeeController.Users(3);
                    break;
            }
            
            
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("El Campo no puede quedar vacio");
            }
            else
            {
                try
                {
                    User u=new User();
                    u=EmployeeController.Exist(list[comboBox2.SelectedIndex].name,textBox1.Text);
                    Form temp = this.FindForm();
                    temp.Hide();
                    //temp.Dispose();
                    if (u.idDepartament==1)
                    {
                        frmAdmi admin = new frmAdmi();
                        admin.ShowDialog();
                    }
                    if (u.idDepartament==3)
                    {
                        FrmEmployee employee = new FrmEmployee(u);
                        employee.ShowDialog();
                    }
                    if (u.idDepartament==2)
                    {
                        frmVigilant employeee = new frmVigilant(u);
                        employeee.ShowDialog();
                    }
                }
                catch (UserException)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}