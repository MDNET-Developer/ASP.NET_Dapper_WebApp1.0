using DataAccsessLayer.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Dapper
{
    public class AppUserDal : DpGenericRepository<AppUser>, IAppUserDal
    {
        public AppUserDal(IDbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
