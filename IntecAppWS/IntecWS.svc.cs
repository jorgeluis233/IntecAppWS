using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntecAppWS.Responses;
using IntecAppWS.Entidades;
using IntecAppWS.Database;

namespace IntecAppWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class IntecWS : IServiceAppIntec
    {
        DBConnection db;
        public LoginResponse Login(int ID, string PIN)
        {
            db = new DBConnection();
            bool result = db.Login(ID, PIN);
            db.CloseConnection();
            Control c = new Control();
            if (result)
            {
                c.errorCode = "000";
                c.message = "Inicio Sesion Exitoso";
                c.status = true;
            }
            else
            {
                c.errorCode = "100";
                c.message = "ID o PIN Incorrecto";
                c.status = false;
            }
            LoginResponse lr = new LoginResponse();
            lr.LoginIndicator = result;
            lr.control = c;
            lr.Sesion = Guid.NewGuid().ToString();


            return  lr;
        }

       /* public DatosGeneralesResponse DatosGenerales(string ID, string sesion)
        {
            DatosGeneralesResponse dgr = new DatosGeneralesResponse();
            Programa p = new Programa();
            p.Nombre = "Ingenieria de Software";
            p.Tipo = "Grado";
            p.CantidadDeAsignaturas = 98;
            List<Programa> programas = new List<Programa>();
            programas.Add(p);

            Estudiante e = new Estudiante();
            e.ID = "1059209";
            e.Name = "Jorge Santana";
            e.Programas = programas;
            e.CondicionAcademica = "Normal";
            e.TrimestreDeIngreso = "Agosto-Octubre 2013";
            e.CreditosConvalidados = 68;
            e.CreditosAprobados = 198;
            e.AsignaturasAprobadas = 60;
            e.AsignaturasFaltantes = 38;
            e.Imagen = new byte[255];
            e.IndiceGeneral = 3.80;
            e.IndiceTrimestral = 4.0;
            e.TrimestresCursados = 14;

            dgr.estudiante = e;

            return dgr;

        }

        public AsignaturasPreseleccionadasResponse AsignaturasPreseleccionadas(string id, Programa programa, Periodo periodo, string sesion)
        {
            AsignaturasPreseleccionadasResponse apr = new AsignaturasPreseleccionadasResponse();
            List<Asignatura> asignaturas = new List<Asignatura>();
            Asignatura a = new Asignatura();
            a.Aula = "FD404";
            a.CantidadCreditos = 5;
            a.CodigoAsignatura = "AH101";
            a.Estado = "Activa";
            a.NombreAsignatura = "Comunicacion y Baraje";

            asignaturas.Add(a);
            apr.Asignaturas = asignaturas;

            return apr;
        }

        public AsignaturasSeleccionadasResponse AsignaturasSeleccionadas(string id, Programa programa, Periodo periodo, string sesion)
        {
            AsignaturasSeleccionadasResponse ase = new AsignaturasSeleccionadasResponse();
            List<Asignatura> asignaturas = new List<Asignatura>();
            Asignatura a = new Asignatura();
            a.Aula = "FD404";
            a.CantidadCreditos = 5;
            a.CodigoAsignatura = "AH101";
            a.Estado = "Activa";
            a.NombreAsignatura = "Comunicacion y Baraje";

            asignaturas.Add(a);
            ase.Asignaturas = asignaturas;

            return ase;
        }
        */
        public AlertaResponse Alertas(int ID, string sesion)
        {
            AlertaResponse ar = new AlertaResponse();
            DBConnection db = new DBConnection();
            ar.Alertas = db.Alertas(ID);
            db.CloseConnection();
            return ar;
        }
        
    }
}
