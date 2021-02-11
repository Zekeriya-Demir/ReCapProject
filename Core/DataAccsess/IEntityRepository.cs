using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccsess
{
    public interface IEntityRepository<T> where T : class,IEntity,  new()
    {
        //filter=null - filtre yapmasanda olur. filtre yapmazsak tüm veriler gelir. 
        //Filtre uygularsak, şu değerler arasındaki veriyi getir gibi uyugularız.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        // Filtre yapmak zorundayız. Bir ürünün detayını getir gibi.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
