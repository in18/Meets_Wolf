﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HicsMVC.SampleClass
{
    public class UserName
    {

        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public UserName(string u)
        {
            this.User = u;
        }

    }
}