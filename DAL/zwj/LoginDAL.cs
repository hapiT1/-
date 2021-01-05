using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.zwj
{
    public class LoginDAL
    {
        JoolbwEntities context = new JoolbwEntities();
        //登录
        public int LoginYesOrNo(string username,string password)
        {
            var list = context.Admin.ToList();
            int i = list.Where(p => p.UserName.Contains(username)).Count();
            int j = list.Where(p => p.PassWord.Contains(password)).Count();
            if (i == 0 && j == 1)
            {
                return 1;
            }
            else if (i == 1 && j == 0)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
