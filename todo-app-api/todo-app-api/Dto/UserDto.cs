﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_app_api.Dto
{
    public class UserDto
    {
        public class Login
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
