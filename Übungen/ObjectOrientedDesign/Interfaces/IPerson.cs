﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface IPerson
    {
        public string FirstName { get; set; } 
        public string SurName { get; set; }

        public string FullName { get; set; }
    }
}
