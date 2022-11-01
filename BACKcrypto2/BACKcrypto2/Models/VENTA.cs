using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BACKcrypto2.Models
{
    public class VENTA
    {
        [Key]
        public int Id_Venta { get; set; }
        public int Id_Cuenta { get; set; }
        public int Monto { get; set; }
        public string Fecha { get; set; }
    }
}