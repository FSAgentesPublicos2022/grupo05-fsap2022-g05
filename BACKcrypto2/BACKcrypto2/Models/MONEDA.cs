using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BACKcrypto2.Models
{
    public class MONEDA
    {
        [Key]
        public int Id_Moneda { get; set; }
        public string NombreMoneda { get; set; }
        
    }
}