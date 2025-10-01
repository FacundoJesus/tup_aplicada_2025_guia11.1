using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaServices
{
    public interface IFigurasService
    {
        Task<List<FiguraModel?>?> GetAll();
        Task<FiguraModel?> GetById(int id);
        Task CrearNuevo(FiguraModel objeto);
        Task Actualizar(FiguraModel objeto);
        Task Eliminar(int id);

        Task ProcesarFiguras();
    }
}
