﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationMVCSample.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}