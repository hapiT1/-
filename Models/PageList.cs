using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PageList
    {
        //总页数
        public int PageCount { get; set; }
        //分页数据
        public IQueryable DataList { get; set; }
    }
}
