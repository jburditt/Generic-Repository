using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Sample.Models.Data;
using Sample.Models.Interfaces;

namespace Sample.DAL
{
    public class BaseController<T, TDTO>
        where T : class, IIdentifier
        where TDTO : class, IDTO<TDTO, T>, new()
    {
        public static TDTO Insert(T n)
        {
            using (var repo = new EFRepository())
            {
                repo.Create(n);
                return Map(n);
            }
        }

        public static TDTO Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.Find(predicate, includeProperties));
            }
        }

        public static TDTO Upsert(T n)
        {
            return n.id <= 0 ? Insert(n) : Update(n);
        }

        public static IEnumerable<TDTO> All()
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.All<T>());
            }
        }

        public static IEnumerable<TDTO> Get(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.FilterSort(filter, null, includeProperties));
            }
        }

        //TODO: Improve on OrderBy e.g. it should look like Get(p => p.id = 1, o => o.name, i => i.company)
        public static IEnumerable<TDTO> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.FilterSort(filter, orderBy, includeProperties));
            }
        }

        //TODO: Change int id to object id and use Find(id)
        public static TDTO GetById(int id)
        {
            using (var repo = new EFRepository())
            {
                //return Map(repo.Find(id));
                return Map(repo.Find<T>(q => q.id == id));
            }
        }

        public static TDTO GetById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.Find(q => q.id == id, includeProperties));
            }
        }

        public static TDTO Update(T n)
        {
            using (var repo = new EFRepository())
            {
                repo.Update(n);
                return Map(n);
            }
        }

        public static TDTO Update(int id, params Func<T, object>[] properties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.Update(id, properties));
            }
        }

        public static TDTO Update(Expression<Func<T, bool>> predicate, params Func<T, object>[] properties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.Update(predicate, properties));
            }
        }

        public static void Delete(int id)
        {
            using (var repo = new EFRepository())
            {
                repo.Delete<T>(id);
            }
        }

        public static int Count(Expression<Func<T, bool>> predicate)
        {
            using (var repo = new EFRepository())
            {
                return repo.Count(predicate);
            }
        }

        private static IEnumerable<TDTO> Map(IEnumerable<T> collection)
        {
            var retval = new Collection<TDTO>();
            foreach (var item in collection)
                retval.Add(new TDTO().MapFrom(item));
            return retval;
        }

        private static TDTO Map(T item)
        {
            return new TDTO().MapFrom(item);
        }

        [Obsolete("No more static context, so no static SaveChanges", true)]
        public static void SaveChanges()
        {
            using (var repo = new EFRepository())
            {
                repo.SaveChanges();
            }
        }
    }
}