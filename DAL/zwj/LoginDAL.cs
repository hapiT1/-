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
            int i = list.Where(p => p.UserName == username).Count();
            int j = list.Where(p => p.PassWord == password).Count();
            if (i == 0 && j == 1)
            {
                return 1;
            }
            else if (i == 1 && j == 0)
            {
                return 2;
            }
            else if (i == 0 && j == 0)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        //登录查询账号角色 用来判断权限
        public List<Admin> RoleNum(string username, string password)
        {
            var list = context.Admin.ToList();
            return list;
        }

        #region 查询全部 分页
        public List<Admin> queryAll(int pageSize, int pageNum)
        {
            List<Admin> list = context.Admin.ToList();
            var alist = list.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
            return alist;
        }
        #endregion
    }
}
