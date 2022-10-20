using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BACKcrypto.Models
{
    public class CLIENTE
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id_LOCALIDAD { get; set; }
    }
}