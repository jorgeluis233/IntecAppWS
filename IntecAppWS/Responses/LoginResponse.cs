using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntecAppWS.Entidades;

namespace IntecAppWS.Responses
{
    public class LoginResponse
    {
        public bool LoginIndicator { get; set; }
        public string Sesion { get; set; }
        public Control control { get; set; }
    }
}