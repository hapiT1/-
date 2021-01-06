using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.zwj;

namespace 仓库管理系统.Controllers
{
    public class zwjController : Controller
    {
        // GET: zwj
        public ActionResult Index()
        {
            return View();
        }
        //登录
        public ActionResult Login()
        {
            return View();
        }
        //员工管理
        public ActionResult SysRole()
        {
            return View();
        }
        //判断登录
        public ActionResult LoginYesOrNo()
        {
            string username = Request.Params["username"];
            string password = Request.Params["password"];
            int i = new LoginBLL().LoginYesOrNo(username, password);
            return Json(i, JsonRequestBehavior.AllowGet);
        }
        //session储存角色编号
        public ActionResult AddSession()
        {
            string username = Request.Params["username"];
            string password = Request.Params["password"];
            List<Admin> list = new LoginBLL().RoleNum(username, password);
            var i = list.Select(p => new { RoleNum = p.RoleNum, p.UserName, p.PassWord }).Where(p => p.UserName == username && p.PassWord == password);
            return Json(i, JsonRequestBehavior.AllowGet);
        }
        //分页查询
        public ActionResult queryAll()
        {
            string pageSize = Request.Params["pageSize"];
            string pageNum = Request.Params["pageNum"];
            List<Admin> list = new LoginBLL().queryAll(Convert.ToInt32(pageSize), Convert.ToInt32(pageNum));
            var alist = list.Select(p => new
            {
                UserName = p.UserName,  //账户名称
                UserCode = p.UserCode,  //账户编号
                RealName = p.RealName,  //真实名称
                Email = p.Email,        //邮箱
                Mobile = p.Mobile,      //电话
                Phone = p.Phone,        //手机
                LoginCount = p.LoginCount,//登录次数
                DepartNum = p.SysDepart.DepartName,//部门名称
                RoleNum = p.SysRole.RoleName     //角色名称
            }).ToList();
            return Json(alist, JsonRequestBehavior.AllowGet);
        }
    }
}