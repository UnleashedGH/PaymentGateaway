using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blueprints;
using Entities.Models;
using Infrastructure;

namespace Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {

        private readonly PaymentGateawayDBContext _paymentGateawayDBContext;
        public BaseRepository(PaymentGateawayDBContext paymentGateawayDBContext)
        {
            _paymentGateawayDBContext = paymentGateawayDBContext;
        }
        public void Create(TEntity entity) =>
              _paymentGateawayDBContext.Set<TEntity>().Add(entity);
   
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByCondition(Expression<Func<bool>> conditionExpression)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }


    }
}
