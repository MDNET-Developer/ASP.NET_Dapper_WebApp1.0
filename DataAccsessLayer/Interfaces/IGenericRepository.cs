using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Interfaces
{
    public interface IGenericRepository<Tentity> where Tentity : class,ITable,new()
    {
        List<Tentity> GetAll();
        Tentity GetbyId(int id);
        void Insert(Tentity entity);
        void Update(Tentity entity);
        void Delete(Tentity entity);
    }
}
