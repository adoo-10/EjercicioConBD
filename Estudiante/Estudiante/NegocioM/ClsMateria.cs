using Estudiante.Data;
using Estudiante.RepositorioM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante.NegocioM
{
    class ClsMateria : ClsRMateria 
    {
        public void Guardar(materia mat)
        {
            Create(mat);

        }
    }
}
