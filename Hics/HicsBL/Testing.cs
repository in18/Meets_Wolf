﻿using huedotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace HicsBL
{
    class Testing
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hallo Welt");
            //DbAccess.addUser("franzi", "123user!", "Pepi", "123");
            HueAccess.LoadConfig();
            HueAccess.getWebClient();
            HueAccess.getLampList();// lamps liste aktuallisieren


            //int i = HueAccess.GetLampId("Hue Lamp 1");
            //HelperClass.SetLampState(1, false);
            //HelperClass.SetLampBrightness(2, 254);
            ////DbAccess.addUser("admin", "123user!", "Walter", "123user!");
            ////Byte[] ha = HelperClass.GetHash("123user!");
            ////HelperClass.GetHash(HelperClass.ByteArrayToString(ha));
            ////List<fn_show_lamp_control_history_Result> l = new List<fn_show_lamp_control_history_Result>();
            //l = DbAccess.GetLogFile("admin", "123user!", new DateTime(1990, 1, 1), new DateTime(2016, 3, 22));
            //List<fn_show_lampgroups_Result> l = null;
            //l = DbAccess.GetAllLampGroups("admin", "123user!").ToList();
            //foreach (var item in l)
            //{
            //    Console.WriteLine($"{item.id} {item.roomgroupname}");
            //    Console.WriteLine((item.ToString()));
            //}
            //DbAccess.editLampName("admin", "123user!","Flur1","Flur99");
            //using (itin18_aktEntities cont = new itin18_aktEntities())
            //{
            //    cont.sp_add_lamp("admin", ha, "12345", "Flur3");
            //}

            //List<fn_show_lamps_Result> l = DbAccess.GetAllLamps("admin", "123user!").ToList();
            //foreach (var i in l)
            //{
            //    Console.WriteLine($"{i.id} {i.name} {i.address}");
            //}
            //List<fn_show_lamps_Result> lamplist = new List<fn_show_lamps_Result>();
            //lamplist = DbAccess.GetAllLamps("Sepp", "123user!");

            //foreach (var item in lamplist)
            //{
            //    Console.WriteLine(item.name);
            //}
            //Console.WriteLine(DbAccess.userLogin("admini","123user!"));

            Console.ReadKey();

        }
    }
}
