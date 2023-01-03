using FilmDukkani.Infrastructure.Context;
using FilmDukkani.Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FilmDukkani.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        //Repository içerisinde neden ApplicationDbContext.cs sınıfına ihtiyacımız var? 
        private readonly AppDbContext _dbContext; //ApplicationDbContext.cs sınıfı bizim uygulama tarafındaki veri tabanımızın karşılığıdır.
        protected readonly DbSet<T> _table; // DbSet ise hatırlarsanız ApplicationDbContext sınıf içerisinde tanımladığımız bir yapı idi. O da uygulama tarafında veri tabanınında ki tabloların karşılığıdır.

        //Biz veri tabanı üzerinde herhangi bir CRUD operasyonu yapacağımız zaman teorik olarak düşünürsek veri tabanına  ve onun üzerinden ilgili tabloya erişmemiz gerekmektedir. ORM gereği burada muhakak onların bir karşılığı olmak zorunda.
        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _table.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression) => await _table.AnyAsync(expression);

        public async Task Delete(T entity)
        {
            entity.Status = Status.Passive;
            entity.DeleteDate = DateTime.Now;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<T> GetByDefault(Expression<Func<T, bool>> expression) => await _table.FirstOrDefaultAsync(expression);

        public async Task<List<T>> GetByDefaults(Expression<Func<T, bool>> expression) => await _table.Where(expression).ToListAsync();

        public async Task<T> GetById(int id) => await _table.FindAsync(id);


        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public List<T> Where(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                                    Expression<Func<T, bool>> where = null,
                                                                    Func<IQueryable<T>, IOrderedQueryable<T>> orderyBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _table;

            if (join != null) query = join(query);

            if (where != null) query = query.Where(where);

            if (orderyBy != null) return await orderyBy(query).Select(select).ToListAsync();

            else return await query.Select(select).ToListAsync();
        }

       
    }
}
