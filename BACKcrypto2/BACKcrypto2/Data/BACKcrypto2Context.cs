using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BACKcrypto2.Data
{
    public class BACKcrypto2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BACKcrypto2Context() : base("name=BACKcrypto2Context")
        {
            Database.SetInitializer<BACKcrypto2Context>(null);
        }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.CLIENTE> CLIENTES { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.INGRESO> INGRESOS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.COMPRA> COMPRAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.VENTA> VENTAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.CUENTA> CUENTAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto2.Models.MONEDA> MONEDAS { get; set; }
    }
}
