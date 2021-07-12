using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Datos_BD;
using Negocio;
using Entidades;
namespace WCF_Primero
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IWCFAlumno
    {
        NegocioAlumno negocio = new NegocioAlumno();
        
        public void Actualizar(Alumnos alumnos)
        {
        
            throw new NotImplementedException();
        }

        public void Actualizar(DCAlumno alumnos)
        {
            Alumnos actu = new Alumnos()
            {
                id = alumnos.id,
                nombre = alumnos.nombre,
                primerApellido = alumnos.primerApellido,
                segundoApellido = alumnos.segundoApellido,
                correo = alumnos.correo,
                telefono = alumnos.telefono,
                fechaNacimiento = alumnos.fechaNacimiento,
                curp = alumnos.curp,
                idEstadoOrigen = alumnos.idEstadoOrigen,
                idEstatus = alumnos.idEstatus

            };
            negocio.Actualizar(actu);
           
        }

        public List<DCAlumno> Consultar()
        {
            List<DCAlumno> lista = new List<DCAlumno>();
            
            foreach (var li in negocio.Consultar().ToList())
            {
                DCAlumno alumnos = new DCAlumno()
                {
                    id = li.id,
                    nombre = li.nombre,
                    primerApellido = li.primerApellido,
                    segundoApellido = li.segundoApellido,
                    correo = li.correo,
                    telefono = li.telefono,
                    fechaNacimiento = li.fechaNacimiento,
                    curp = li.curp,
                    idEstadoOrigen = li.idEstadoOrigen,
                    idEstatus = li.idEstatus
                };
               lista.Add(alumnos);
            }
            
            return lista.ToList();
        
        }

        public void Create(DCAlumno alumnos)
        {
            Alumnos actu = new Alumnos()
            {
                id = alumnos.id,
                nombre = alumnos.nombre,
                primerApellido = alumnos.primerApellido,
                segundoApellido = alumnos.segundoApellido,
                correo = alumnos.correo,
                telefono = alumnos.telefono,
                fechaNacimiento = alumnos.fechaNacimiento,
                curp = alumnos.curp,
                idEstadoOrigen = alumnos.idEstadoOrigen,
                idEstatus = alumnos.idEstatus

            };
            negocio.Crear(actu);
        }

        public DCAlumno detail(int id)
        {

            Alumnos alumno = negocio.detail(id);

            DCAlumno otroGAto = new DCAlumno()
            {
                id = alumno.id,
                nombre = alumno.nombre,
                primerApellido = alumno.primerApellido,
                segundoApellido = alumno.segundoApellido,
                correo = alumno.correo,
                telefono = alumno.telefono,
                fechaNacimiento = alumno.fechaNacimiento,
                curp = alumno.curp,
                idEstadoOrigen = alumno.idEstadoOrigen,
                idEstatus = alumno.idEstatus

            };
            return otroGAto;
        }

        public void DoWork()
        {
        }

        public void Edit2(DCAlumno alumnos)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
