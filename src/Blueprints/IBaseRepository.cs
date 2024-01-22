using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Blueprints
{
     public interface IBaseRepository <TEntity> where TEntity : BaseEntity
    {
        TEntity GetByCondition (Expression<Func<bool>> conditionExpression);
        IEnumerable<TEntity> GetAll ();
        void Update(TEntity entity);
        void Delete (int id);
        
        void Create(TEntity entity);
    }
}
