using Estudiante.Data;
using Estudiante.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante.Negocio
{
    class ClsEstudiante : ClsREstudiante
    {

        public void Guardar( estudiante es )
        {
            Create(es);

        }
    }
}
