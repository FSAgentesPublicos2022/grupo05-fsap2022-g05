using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BACKcrypto.Models
{
    public class INGRESO
    {
        public int Id { get; set; }
        public int Id_Cuenta { get; set; }
        public decimal Monto { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}