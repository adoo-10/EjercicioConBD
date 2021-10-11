using Estudiante.Data;
using Estudiante.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();
            es.nombresEstudiante = TxtNombre.Text;
            es.apellidos = TxtApellidos.Text;
            es.usuario = TxtUsuario.Text;
            es.contrasenia = TxtContraseña.Text;
            ClsEstudiante clsEstudiante = new ClsEstudiante();
            clsEstudiante.Guardar(es);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
