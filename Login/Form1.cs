using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string nombre = cbxnombre.SelectedItem.ToString();
            string clave = txtclave.Text;
            
            CD_Usuariosistema oCD_Usuariosistema = new CD_Usuariosistema();
            DataTable dtUsuariosistema = new DataTable();
            dtUsuariosistema = oCD_Usuariosistema.leerUsuarioSistema(nombre);
            //MessageBox.Show(dtUsuariosistema.Rows[0]["clave"].ToString());
            if (clave == dtUsuariosistema.Rows[0]["clave"].ToString())
            {
                if (nombre == "DOCENTES" || nombre == "ESTUDIANTES" || nombre == "EXTERNOS")
                {
                    MessageBox.Show("Mostrar formulario publico");
                }
                else if(nombre == "ADMIN")
                {
                    MessageBox.Show("Mostrar formulario administrador");
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = MessageBox.Show("Desea salir de la app?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2).ToString();
            if (resultado == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
