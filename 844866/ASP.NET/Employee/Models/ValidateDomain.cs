﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class ValidateDomain:ValidationAttribute
    {
        //custom validation code
        public readonly string allowDomain;
        public ValidateDomain(string allowdomain)
        {
            this.allowDomain = allowdomain;
        }
        public override bool IsValid(object value)
        {
            string[] email=value.ToString().Split('@');
            if (email[1] == this.allowDomain)
                return true;
            else
                return false;
            //return base.IsValid(value);
        }
    }
}
