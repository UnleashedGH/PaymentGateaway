using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Blueprints
{
     public interface IBaseRepository <T> where T : BaseEntity
    {
        T GetById (int id);
        IEnumerable<T> GetAll ();

        void Update(T entity);

        void Delete (int id);


    }
}
