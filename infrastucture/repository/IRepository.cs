using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastucture.repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);

        void Save(T entity);

        void Delete(T t);

        void Update(T entity);

    }


}
