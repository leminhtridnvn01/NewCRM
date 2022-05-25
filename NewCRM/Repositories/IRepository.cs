using NewCRM.Databases;
using System.Collections.Generic;
using System.Linq;

namespace NewCRM.Repositories
{
    public interface IRepository<T> where T : class
    {
        // 1. Get list all 
        public List<T> GetList()
        {
            Context db = new Context();
            var l = db.Set<T>().Select(p => p).ToList();
            return l;
        }

        // 2. Get detail
        public T GetDetails(int id)
        {
            Context db = new Context();
            var l = db.Set<T>().Find(id);
            return l;
        }

        // 3. Create
        public void Create(T entity)
        {
            Context db = new Context();
            var l = db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        // 4. Update
        public void Update(T entity)
        {
            using (Context db = new Context())
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
            }
        }

        // 5. Delete
        public void Delete(int id)
        {
            using (Context db = new Context())
            {
                var l = db.Set<T>().Find(id);
                db.Set<T>().Remove(l);
                db.SaveChanges();
            }         
        }
    }
}
