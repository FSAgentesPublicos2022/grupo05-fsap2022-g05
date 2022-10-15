using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BACKcrypto.Models
{
    public class COMPRA
    {
        public int Id { get; set; }
        public int Id_Cuenta { get; set; }
        public decimal Monto { get; set; }
        public System.DateTime Fecha { get; set; }
    }
}