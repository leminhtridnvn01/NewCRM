using Microsoft.EntityFrameworkCore;
using NewCRM.Databases;
using NewCRM.Databases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCRM.Repositories
{
    public interface IRepository<T> where T : class
    {
        public List<T> GetList()
        {
            Context db = new Context();
            var l = db.Set<T>().Select(p => p).ToList();
            return l;
        }
        public T GetDetails(int id)
        {
            Context db = new Context();
            var l = db.Set<T>().Find(id);
            return l;
        }
        public void Create(T entity)
        {
            Context db = new Context();
            var l = db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            using (Context db = new Context())
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
            }
        }
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
