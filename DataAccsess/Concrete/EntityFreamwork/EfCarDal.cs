using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using(ReCapContext contex = new ReCapContext())
            {
                // contex.Set ile Product'a bağlan, filter'a göre datayı getir.
                return contex.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext contex = new ReCapContext())
            {
                // contex.Set ile Product'a bağlan.
                // eğer filter null ise DbSet'deki prodcuta yerleş, oradaki (vt), tüm datayı listeye çevir.
                // Null değilse filter'a göre datayı getir.
                // arka planda select*product dönürür.
                return filter == null ? contex.Set<Car>().ToList() : contex.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity); // referansı yakalar. 
                updatedEntity.State = EntityState.Modified; // güncelle
                context.SaveChanges(); // işlemi yap.
            }
        }
    }
}
