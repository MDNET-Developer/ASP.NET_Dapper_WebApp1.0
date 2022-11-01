using Dapper;
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
        private readonly IDbConnection _dbConnection;
        public AppUserDal(IDbConnection dbConnection) : base(dbConnection)
        {
            dbConnection = _dbConnection;
        }

        public bool CheckUser(string username, string password)
        {
          var user=  _dbConnection.Query<AppUser>("Select * from AppUser where UserName=@username and Password=@password", new
          {
              username=username, password=password
          });
            return user != null;
        }
    }
}
