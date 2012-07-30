﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayWolf.Logic
{

    class Status
    {
        public bool acceptance;
        public string detail;

        public Status(bool acceptance, string detail)
        {
            this.acceptance = acceptance;
            this.detail = detail;
            return;
        }
        public Status()
        {
            return;
        }
    }
}
