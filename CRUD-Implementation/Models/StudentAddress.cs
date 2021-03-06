﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Implementation.Models
{
    class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public  int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
