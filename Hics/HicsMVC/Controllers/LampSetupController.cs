﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HicsBL;
using HicsMVC.Models;
using System.Diagnostics;

namespace HicsMVC.Controllers
{
    public class LampSetupController : Controller
    {
        // GET: LampSetup
        public ActionResult Index()
        {
            LampSetupModel lsm = new LampSetupModel();

            List<fn_show_lamps_Result> lamplist = HicsBL.DbAccess.GetAllLamps("Sepp", "123User!");

            lsm.Lamplist = lamplist;

            return View(lsm);
            //return View();
        }

        [HttpPost]
        public ActionResult AddLamp(LampSetupModel lsm)
        {                        
            Debug.WriteLine($"ID: {lsm.Id}\nDesc: {lsm.Description}");

            return RedirectToAction("index");
        }

        public ActionResult DeleteLamp(int id)
        {
            return RedirectToAction("index");
        }


    }
}