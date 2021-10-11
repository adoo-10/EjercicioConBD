using Estudiante.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante.Services
{
    interface IEstudiante
    {
        //CRUD "crear, leer, actualizar, eliminar"

        //C
        void Create(estudiante estudiante );

        //D

        void Delete(estudiante estudiante);


    }
}
