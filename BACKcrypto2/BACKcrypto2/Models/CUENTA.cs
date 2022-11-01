using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BACKcrypto2.Models
{
    public class CUENTA
    {
        [Key]
        public int Id_Cuenta { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Moneda { get; set; }
        public int CVU { get; set; }
        public int Saldo { get; set; }
    }
}