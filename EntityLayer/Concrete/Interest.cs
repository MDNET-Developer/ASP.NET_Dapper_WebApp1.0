using EntityLayer.BaseClasses;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Dapper.Contrib.Extensions.Table("Interests")]
    public class Interest:BaseEntityII,ITable
    {
    }
}
