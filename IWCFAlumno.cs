using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Primero
{
    [ServiceContract]
    public interface IWCFAlumno
    {

        [OperationContract]
        List<DCAlumno> Consultar();
        [OperationContract]
        void Create(DCAlumno alumnos);
        [OperationContract]
        void Actualizar(DCAlumno alumnos);
        [OperationContract]
        DCAlumno detail(int id);
        [OperationContract]
        void Edit2(DCAlumno alumnos);
        [OperationContract]
        void Eliminar(int id);


    }
}
