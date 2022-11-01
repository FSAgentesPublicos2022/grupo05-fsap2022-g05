using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BACKcrypto2.Models
{
    public class CLIENTE
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }


}