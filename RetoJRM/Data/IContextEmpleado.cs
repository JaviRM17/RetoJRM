

using RetoJRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoJRM.Data
{
    
    public interface IContextEmpleado
    {
        DbSet<Empleado> Empleados { get; set; }
    }
}
