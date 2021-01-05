using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.yry
{
    class CustomerDal
    {
         static JoolbwEntities entities = new JoolbwEntities();
        public static IQueryable selectCus(int pageIndex, int pageSize) 
        {
            PageList list = new PageList();
            var obj = from p in entities.Customer
                      orderby p.ID
                      select new
                      {
                          khName = p.CusName,
                          khType = p.CusType,
                          khPhone = p.Phone,
                          Fax = p.Fax,
                          cjTime =p.CreateTime,
                         // dingdanNum =

                      };
            return obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        public static PageList PageListStudent(int pageIndex, int pageSize)
        {
            PageList list = new PageList();
            var obj = from p in entities.Customer
                      orderby p.ID
                      select new
                      {
                          khName = p.CusName,
                          khType = p.CusType,
                          khPhone = p.Phone,
                          Fax = p.Fax,
                          cjTime = p.CreateTime,
                          // dingdanNum =

                      }; obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entities.Customer.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

    }
}
