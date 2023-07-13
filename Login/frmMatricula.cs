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
    public partial class frmMatricula : Form
    {
        CD_Matricula oCD_Matricula;
        public frmMatricula()
        {
            InitializeComponent();
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            oCD_Matricula = new CD_Matricula();
            cbxestudiantes.DataSource = oCD_Matricula.leerEstudiantes();
            cbxestudiantes.DisplayMember = "nombre";
            cbxestudiantes.ValueMember = "id";

            cbxasignatura.DataSource = oCD_Matricula.leerAsignaturas();
            cbxasignatura.DisplayMember = "nombre";
            cbxasignatura.ValueMember = "idasignatura";
        
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            txtfecha.Text = dtpfecha.Value.Date.ToShortDateString();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            int estudiante = int.Parse(cbxestudiantes.SelectedValue.ToString());
            int asignatura = int.Parse(cbxasignatura.SelectedValue.ToString());
            string fecha = txtfecha.Text;
            double nota = double.Parse(txtnota.Text);
            if (oCD_Matricula.RegistrarMatricula(estudiante, asignatura, fecha, nota))
            {
                MessageBox.Show("Registro de matricula realizado correctamente", "Registro");
            }
        }
    }
}
