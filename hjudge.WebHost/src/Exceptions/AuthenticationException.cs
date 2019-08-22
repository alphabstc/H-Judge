﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hjudge.WebHost.Exceptions
{
    public class AuthenticationException : InterfaceException
    {
        public AuthenticationException(string errorMessage = "") : base(System.Net.HttpStatusCode.Unauthorized, errorMessage) { }
    }
}
