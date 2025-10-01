using GeometriaListDALsImpl.Utilities;
using GeometriaModels.DALs.Utilities;
using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaListDALsImpl
{
    public class FigurasListDAL: IFigurasDAL<ListTransaction>
    {
        private int _id = 1;
        private readonly List<FiguraModel> _figuras = new List<FiguraModel>();

        public async Task<List<FiguraModel>> GetAll(ITransactionDAL<ListTransaction>? transaccion = null)
        {
            if (transaccion?.GetInternalTransaction() is ListTransaction trans)
            {
                var lista = from copy in trans.GetWorkingCopy() where copy is FiguraModel select (FiguraModel)copy;
                return await Task.FromResult(lista.ToList());
            }
            return await Task.FromResult(_figuras);
        }

        public async Task<FiguraModel?> GetByKey(int idFigura, ITransactionDAL<ListTransaction>? transaccion = null)
        {
            List<FiguraModel> lista = new List<FiguraModel>();
            if (transaccion?.GetInternalTransaction() is ListTransaction trans)
            {
                var list = from copy in trans.GetWorkingCopy() where copy is FiguraModel select (FiguraModel)copy;
                lista = list.ToList();
            }
            else
            {
                lista = _figuras;
            }

            var figura = lista.FirstOrDefault(f => f.Id == idFigura);
            return await Task.FromResult(figura);
        }

        public async Task<FiguraModel?> Add(FiguraModel nuevo, ITransactionDAL<ListTransaction>? transaccion = null)
        {
            List<FiguraModel> lista = new List<FiguraModel>();
            if (transaccion?.GetInternalTransaction() is ListTransaction trans)
            {
                var list = from copy in trans.GetWorkingCopy() where copy is FiguraModel select (FiguraModel)copy;
                lista = list.ToList();
            }
            else
            {
                lista = _figuras;
            }

            var f = lista.FirstOrDefault(f => f.Id == nuevo.Id);

            if (f == null)
            {
                nuevo.Id = _id++;
                lista.Add(nuevo);
                return nuevo;
            }
            return null;
        }

        public async Task<bool> Save(FiguraModel entidad, ITransactionDAL<ListTransaction>? transaccion = null)
        {
            List<FiguraModel> lista = new List<FiguraModel>();
            if (transaccion?.GetInternalTransaction() is ListTransaction trans)
            {
                var list = from copy in trans.GetWorkingCopy() where copy is FiguraModel select (FiguraModel)copy;
                lista = list.ToList();
            }
            else
            {
                lista = _figuras;
            }

            var f = lista.FirstOrDefault(f => f.Id == entidad.Id);

            if (f == null)
            {
                lista.Add(entidad);
                return true;
            }
            return false;
        }

        public async Task<bool> Remove(int idEntidad, ITransactionDAL<ListTransaction>? transaccion = null)
        {
            List<FiguraModel> lista = new List<FiguraModel>();
            if (transaccion?.GetInternalTransaction() is ListTransaction trans)
            {
                var list = from copy in trans.GetWorkingCopy() where copy is FiguraModel select (FiguraModel)copy;
                lista = list.ToList();
            }
            else
            {
                lista = _figuras;
            }

            var f = lista.FirstOrDefault(f => f.Id == idEntidad);

            if (f != null)
            {
                lista.Remove(f);
                return true;
            }

            return false;
        }

        async public Task ProcesarFiguras(ITransactionDAL<ListTransaction>? transaccion = null)
        {
            //implementar...

        }
    }
}
