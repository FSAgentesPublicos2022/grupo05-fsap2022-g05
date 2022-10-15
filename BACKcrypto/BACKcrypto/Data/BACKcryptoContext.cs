using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BACKcrypto.Data
{
    public class BACKcryptoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BACKcryptoContext() : base("name=BACKcryptoContext")
        {
        }

        public System.Data.Entity.DbSet<BACKcrypto.Models.CLIENTE> CLIENTES { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.COMPRA> COMPRAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.CUENTA> CUENTAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.EMAIL> EMAILS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.INGRESO> INGRESOS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.LOCALIDAD> LOCALIDADES { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.MONEDA> MONEDAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.PROVINCIA> PROVINCIAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.TRANSFERENCIA> TRANSFERENCIAS { get; set; }

        public System.Data.Entity.DbSet<BACKcrypto.Models.VENTA> VENTAS { get; set; }
    }
}
