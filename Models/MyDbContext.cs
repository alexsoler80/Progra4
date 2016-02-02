using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext():base("Miconexion")
        {
            
        }
        //Region para DB sets
        #region

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleadoes { get; set; }

        #endregion
    }
}