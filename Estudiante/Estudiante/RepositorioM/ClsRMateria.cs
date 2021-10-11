using Estudiante.Data;
using Estudiante.ServicesM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante.RepositorioM
{
    class ClsRMateria : IMateria
    {
        public void Create(materia materia)
        {
            using (EstudiantesEntities conexionBD = new EstudiantesEntities())
            {
                try
                {
                    materia ma = new materia();
                    ma.nombreMateria = materia.nombreMateria;

                    conexionBD.materia.Add(ma);
                    conexionBD.SaveChanges();
                    MessageBox.Show("Materia agregada");
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        public void Delete(materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
