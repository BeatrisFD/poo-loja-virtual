using System.Collections.Generic;
using LiteDB;

namespace PooLojaVirtual.Data
{
    public class RepositorioLiteDB<T> : IRepositorio<T>
    {
        private LiteRepository _db;

        public RepositorioLiteDB()
        {
            _db = new LiteRepository("loja.db");
        }
        
        public IEnumerable<T> GetAll()
        {
            return _db.Query<T>().ToEnumerable();
        }

        public void Inserir(T entidade)
        {
            _db.Insert<T>(entidade);
        }

        public T RecuperarPorId(int id)
        {
            return _db.SingleById<T>(id);
        }

        public void Salvar(T entidade)
        {
            _db.Update<T>(entidade);
        }
    }
}