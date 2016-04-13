﻿using HicsMVC.SampleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HicsMVC.Models;
using HicsBL;

namespace HicsMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangePassword(int id)
        {
            AdminChangePasswordModel acpm = new AdminChangePasswordModel();
            UserSession us = (UserSession)Session["UserSession"];
            ViewBag.Adminstatus = us.name.ToLower();
            List<fn_show_users_Result> users = HicsBL.DbAccess.GetAllUser(us.name, us.pw);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name.ToLower() == us.name.ToLower())
                {
                    ViewBag.SessionId = users[i].id;
                    break;
                }
            }
            acpm.id = id;

            ViewBag.UserId = id;
            return View(acpm);
        }

        [HttpPost]
        public ActionResult ChangePassword(AdminChangePasswordModel acpm)
        {            
            UserSession us = (UserSession)Session["UserSession"];

            if (acpm.NewPassword == acpm.RetypeNewPassword)
            {
                if (acpm.RecentPassword == null)
                {
                    DbAccess.ChangePasswordByAdmin(us.name, us.pw, acpm.id, acpm.NewPassword);
                }
                else if (acpm.RecentPassword == us.pw)
                {
                    DbAccess.EditUserPassword(us.name, acpm.RecentPassword, acpm.NewPassword);
                }
            }
            else
            {
                return RedirectToAction("index", "useradd");
            }

            return RedirectToAction("index", "useradd");
        }
    }
}