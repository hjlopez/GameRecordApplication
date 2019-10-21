using GameRecordApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordApplication.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(long id);
        T Find(long id);
        void Insert(T t);
        void Update(T t);
        bool IsValid(long num);
    }
}
