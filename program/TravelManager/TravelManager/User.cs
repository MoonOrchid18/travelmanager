﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace TravelManager
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get;  set; }
        public string mail { get; private set; }
        public string password { get; private set; }
        public User() { }
        public User(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }
    }
}