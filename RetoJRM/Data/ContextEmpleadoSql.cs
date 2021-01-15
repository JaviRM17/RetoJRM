using RetoJRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetoJRM.Data
{
    public class ContextEmpleadoSql : DbContext, IContextEmpleado
    {
        public ContextEmpleadoSql() : base("name=conexionempleadosql") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}