﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRecordApplication.Models
{
    public class User : BaseEntity
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string ProfilePic { get; set; }
        public string UserRole { get; set; }
    }
}