using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.yry;
namespace BLL.yry
{
    public static class CustomerBll
    {
        public static IQueryable selectCus(int pageIndex, int pageSize)
        {
            return CustomerDal.selectCus(pageIndex, pageSize);
        }
        public static PageList PageListStudent(int pageIndex, int pageSize)
        {
            return CustomerDal.PageListCus(pageIndex, pageSize);
        }
    }
}
