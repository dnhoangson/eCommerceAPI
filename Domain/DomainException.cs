﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage) : base(businessMessage)
        {

        }
    }
}
