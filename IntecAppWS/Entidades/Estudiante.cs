using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntecAppWS.Entidades
{
    public class Estudiante
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public List<Programa> Programas { get; set; }
        public string CondicionAcademica { get; set; }
        public string TrimestreDeIngreso { get; set; }
        public double IndiceTrimestral { get; set; }
        public double IndiceGeneral { get; set; }
        public int CreditosConvalidados { get; set; }
        public int CreditosAprobados { get; set; }
        public int TrimestresCursados { get; set; }
        public byte[] Imagen { get; set; }
        public int AsignaturasAprobadas { get; set; }
        public int AsignaturasFaltantes { get; set; }
    }
}