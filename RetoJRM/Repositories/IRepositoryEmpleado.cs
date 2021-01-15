using RetoJRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoJRM.Repositories
{
    public interface IRepositoryEmpleado
    {
        List<Empleado> GetEmpleados();
    }
}
