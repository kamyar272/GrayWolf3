﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayWolf.Logic
{
    class user
    {
        public string name;
        public int UID;
        public DateTime membershipDate;
        public user(string name, int UID, DateTime date)
        {
            this.UID = UID;
            this.name = name;
            this.membershipDate = date;
            return;
        }
        public user()
        {
            return;
        }

    }
}
