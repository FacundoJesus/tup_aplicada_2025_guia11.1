using GeometriaModels.Models;
namespace GeometriaModels.DALs.Utilities;

public interface IFigurasDAL<T> : IBaseDAL<FiguraModel, int, T>
{
    Task ProcesarFiguras(ITransactionDAL<T>? transaccion = null);
}
