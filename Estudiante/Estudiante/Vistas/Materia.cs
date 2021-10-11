using Estudiante.Data;
using Estudiante.NegocioM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante.Vistas
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            materia mat = new materia();
            mat.nombreMateria = TxtMateria.Text;

            ClsMateria clsMateria = new ClsMateria();
            clsMateria.Guardar(mat);
            TxtMateria.Clear();

        }
    }
}
