using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorioBodega :IRepositorio<Bodega>
    {
        void Actualizar(Bodega bodega);
    }
}
