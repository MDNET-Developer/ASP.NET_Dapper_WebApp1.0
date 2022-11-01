using BusinessLayer.Interfaces;
using DataAccsessLayer.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : GenericManager<AppUser> ,IAppUserService
    {
        private readonly IGenericRepository<AppUser> _appuserrepository;
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IGenericRepository<AppUser> appuserrepository, IAppUserDal appUserDal) : base(appuserrepository)
        {
            _appuserrepository = appuserrepository;
            _appUserDal = appUserDal;
        }

        public bool CheckUser(string username, string password)
        {
            return _appUserDal.CheckUser(username, password);
        }
    }
}
