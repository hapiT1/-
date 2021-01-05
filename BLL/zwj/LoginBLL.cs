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
    }
}
