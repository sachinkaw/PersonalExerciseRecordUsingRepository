using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExerciseRecordUsingRepository.Models.DAL
{
    public interface _IAllRepository<T> where T : class
    {
        IEnumerable<T> GetAllExercises();

        void InsertExerciseRecord(T model);

        IEnumerable<T> FindExerciseRecord(Expression<Func<T, bool>> predicate);

        void Save();
    }
}
