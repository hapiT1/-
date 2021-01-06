using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.zwj;

namespace BLL.zwj
{
    public class LoginBLL
    {
        JoolbwEntities context = new JoolbwEntities();
        //登录
        public int LoginYesOrNo(string username, string password)
        {
            return new LoginDAL().LoginYesOrNo(username,password);
        }

        //登录查询账号角色 用来判断权限
        public List<Admin> RoleNum(string username, string password)
        {
            return new LoginDAL().RoleNum(username, password);
        }

        #region 查询全部
        public List<Admin> queryAll(int pageSize, int pageNum)
        {
            return new LoginDAL().queryAll(pageSize, pageNum);
        }
        #endregion
    }
}
