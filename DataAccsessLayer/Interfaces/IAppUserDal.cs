using DataAccsessLayer.Concrete.Dapper;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Interfaces
{
    public interface IAppUserDal: IGenericRepository<AppUser>
    {
        bool CheckUser(string username, string password);
    }
}
