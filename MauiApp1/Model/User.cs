﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
