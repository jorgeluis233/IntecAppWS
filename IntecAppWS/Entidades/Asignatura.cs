using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntecAppWS.Entidades
{
    public class Asignatura
    {
        public string CodigoAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public int CantidadCreditos { get; set; }
        public string Profesor { get; set; }
        public string Seccion { get; set; }
        public string Aula { get; set; }
        public List<string> Horario { get; set; }
        public int CalificacionNumerica { get; set; }
        public string CalificacionAlfa { get; set; }
        public double CalificacionBaseMedioTermino { get; set; }
        public double CalificacionObtenidaMedioTermino { get; set; }
        public int Puntos { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}