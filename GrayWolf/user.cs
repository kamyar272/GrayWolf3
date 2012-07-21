using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayWolf
{
    class user
    {
        public string name;
        public int UID;
        public DateTime membershipDate;
        user(string name, int UID, DateTime date)
        {
            this.UID = UID;
            this.name = name;
            this.membershipDate = date;
        }

    }
}
