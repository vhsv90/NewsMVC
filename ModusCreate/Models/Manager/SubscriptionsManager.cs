using ModusCreate.Models.DB;
using ModusCreate.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreate.Models.Manager
{
    public class SubscriptionsManager : IDataRepository<Subscription>
    {

        public readonly NewsContext _newsContext;

        public SubscriptionsManager(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public void Add(Subscription entity)
        {
            _newsContext.Subscriptions.Add(entity);
            _newsContext.SaveChanges();
        }

        public void Delete(Subscription entity)
        {
            _newsContext.Subscriptions.Remove(entity);
            _newsContext.SaveChanges();
        }

        public Subscription Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subscription> GetAll()
        {
            return _newsContext.Subscriptions.ToList();
        }

        public IEnumerable<Subscription> GetAllByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subscription> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public void Update(Subscription dbEntity, Subscription entity)
        {
            throw new NotImplementedException();
        }
    }
}
