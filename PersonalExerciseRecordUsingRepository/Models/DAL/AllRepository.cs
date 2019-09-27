using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace PersonalExerciseRecordUsingRepository.Models.DAL
{
    public abstract class AllRepository<T> : _IAllRepository<T> where T : class
    {
        //private MyDBEntities _context;
        //private IDbSet<T> dbEntity;

        private List<T> _context;

        /*public AllRepository()
        {
            _context = new MyDBEntities();
            dbEntity = _context.Set<T>();
        }

        public IEnumerable<T> GetAllExercises()
        {
            return dbEntity.ToList();
        }*/

        public IEnumerable<T> GetAllExercises()
        {
            return _context.
        }

        public void InsertExerciseRecord(T model)
        {
            dbEntity.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> FindExerciseRecord(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
    }
}