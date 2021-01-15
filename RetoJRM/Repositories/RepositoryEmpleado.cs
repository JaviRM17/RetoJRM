using RetoJRM.Data;
using RetoJRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetoJRM.Repositories
{
    public class RepositoryEmpleado : IRepositoryEmpleado
    {
        IContextEmpleado context;
        public RepositoryEmpleado(IContextEmpleado context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }
    }
}