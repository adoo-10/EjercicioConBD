using Estudiante.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante.ServicesM
{
    interface IMateria
    {
        void Create(materia materia);

        void Delete(materia materia);
    }
}
