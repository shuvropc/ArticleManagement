﻿using System;

namespace AM.DM.DAL
{
    public class User
    {
        public class UserModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string Phone { get; set; }
            public string Country { get; set; }
            public string Address { get; set; }
        }
    }
}

