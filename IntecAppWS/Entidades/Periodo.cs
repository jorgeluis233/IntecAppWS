using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntecAppWS.Entidades
{
    public class Periodo
    {
        public Periodos periodo { get; set; }
        public int Ano { get; set; }

    }

    public enum Periodos{
        AgostoOctubre,
        NoviembreEnero,
        FebreroAbril,
        MayoJulio
    }
}