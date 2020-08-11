﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstSQLite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
