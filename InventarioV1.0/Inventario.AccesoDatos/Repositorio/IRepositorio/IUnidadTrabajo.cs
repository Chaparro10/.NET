using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo :IDisposable
    {
        IRepositorioBodega Bodega { get; }
        Task Guardar();
    }
}
