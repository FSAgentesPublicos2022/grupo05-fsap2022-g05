using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BACKcrypto.Models
{
    public class CUENTA
    {
        public int Id { get; set; }
        public int CVUcliente { get; set; }
        public int Id_CLIENTE { get; set; }
        public int ID_Moneda { get; set; }
        public decimal Saldo { get; set; }
    }
}