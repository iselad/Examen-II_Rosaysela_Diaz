using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConectaDatos;
using ConectaDatos.Motor;//clase accesoMotor 
using ConectaDatos.Entidades;//clase Entidad

namespace Rosaysela_Examen_II_seccion_1400
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            //crear objetos de la clase usuario 
            //UuarioDA es el que accede al motor de base de datos
            UsuarioDA usuarioBD = new UsuarioDA();

            Usuario usuario = new Usuario();
            usuario = usuarioBD.login(UsuariotextBox1.Text, ClavetextBox2.Text);



            if (usuario == null)
            {
                MessageBox.Show("Datos Erroneos");
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario inactivo");
                return;
            }

            //Llamar formulario mostrar datos

          Menu mostrarDatos = new Menu();
          mostrarDatos.Show();
            this.Hide();


        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void ClavetextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuariotextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

