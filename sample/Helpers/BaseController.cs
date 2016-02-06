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
        where T : class
        where TDTO : class, IDTO<TDTO, T>, new()
    {
        public static TDTO Insert(TDTO n)
        {
            using (var repo = new EFRepository())
            {
                var tdto = Map(n);
                repo.Create(tdto);
                return Map(tdto);
            }
        }

        public static TDTO Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.Find(predicate, includeProperties));
            }
        }

        public static IEnumerable<TDTO> All()
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.All<T>());
            }
        }

        public static IEnumerable<TDTO> Get(Expression<Func<T, bool>> filter = null,
            params Expression<Func<T, object>>[] includeProperties)
        {
            return Get(filter, null, includeProperties);
        }

        public static IEnumerable<TDTO> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.FilterSort(filter, orderBy, includeProperties));
            }
        }

        public static TDTO GetById(object id)
        {
            using (var repo = new EFRepository())
            {
                return Map(repo.GetById<T>(id));
            }
        }

        public static TDTO Update(TDTO n)
        {
            using (var repo = new EFRepository())
            {
                repo.Update(Map(n));
                return n;
            }
        }

        public static TDTO Update(object id, params Func<T, object>[] properties)
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

        private static T Map(TDTO item)
        {
            return new TDTO().MapTo(item);
        }
    }
}
