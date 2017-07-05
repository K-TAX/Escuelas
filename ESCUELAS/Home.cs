using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCUELAS
{
    public partial class Home : Form
    { 

        public Home()
        {
            InitializeComponent();
        }

        private void ingresarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            GuardarAlumno fr = new GuardarAlumno();
            fr.MdiParent = this;

            fr.Show();
        }

        private void listarAlumnosSegunApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAlumnos listar = new ListarAlumnos();
            listar.MdiParent = this;

            listar.Show();
        }
    }
}
