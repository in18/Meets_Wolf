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
            //HueAccess.LoadConfig();
            //HueAccess.getWebClient();
            //HueAccess.getLampList();// lamps liste aktuallisieren

            //HelperClass.SetLampState(1, true);
            //HelperClass.SetLampBrightness(2, 254);
            DbAccess.addUser("admin", "123user!", "Walter", "123user!");
            //Byte[] ha = HelperClass.GetHash("123user!");
            //HelperClass.GetHash(HelperClass.ByteArrayToString(ha));



            Console.ReadKey();

        }
    }
}
