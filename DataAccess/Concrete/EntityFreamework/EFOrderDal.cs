using Core.DataAccess.EntityFreamework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamework
{
    public class EFOrderDal:EFEntityRepositoryBase<Order,NorthWindContext> ,IOrderDal
    {
    }
}
