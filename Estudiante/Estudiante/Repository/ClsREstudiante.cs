using Estudiante.Data;
using Estudiante.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante.Repository
{
    class ClsREstudiante : IEstudiante
    {
        public void Create(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                try
                {
                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiante.nombresEstudiante;
                    est.apellidos = estudiante.apellidos;
                    est.usuario = estudiante.usuario;
                    est.contrasenia = estudiante.contrasenia;
                   

                    conexionBd.estudiante.Add(est);
                    conexionBd.SaveChanges();
                    MessageBox.Show("Save");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public void Delete(estudiante estudiante)
        {
            throw new NotImplementedException();
        }
    }


}
