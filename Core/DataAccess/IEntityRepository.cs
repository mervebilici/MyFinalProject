
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //Class yazdığımız için sadece referans tip koyabiliriz.
    //Herhangi bir referans tip olmasını engellemek için IEntity ve onu implement eden nesneler olabilir.
    //new() : new'lenebilir olmalı. Yani artık soyut nesne olan IEntity kullanılamaz.
   public interface IEntityRepository<T> where T : class, IEntity, new() //standart oluşturduk
    {
        //generic constraint - genel kısıtlama
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
