using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BACKcrypto.Models
{
    public class TRANSFERENCIA
    {
        public int Id { get; set; }
        public int Id_Cuenta { get; set; }
        public string CVUdestino { get; set; }
        public decimal Monto { get; set; }
    }
}