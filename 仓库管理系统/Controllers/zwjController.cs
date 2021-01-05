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

        public ActionResult Login()
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
    }
}