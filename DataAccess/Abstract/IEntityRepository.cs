using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic Constraint
    // T = Referans tip olmalı
    // IEntity = IEntity veya IEntity den implament olmalı
    // New() = New lenebilir olan bir nesne olmalı (Bu IEntity interfaceini dışarı atıyor)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Expression, Bizim filtre kullanmamıza olanak sağlar.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
