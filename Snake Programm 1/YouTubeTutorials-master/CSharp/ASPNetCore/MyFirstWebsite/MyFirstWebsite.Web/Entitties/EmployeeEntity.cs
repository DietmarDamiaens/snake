﻿using System;

namespace MyFirstWebsite.Web.Entitties
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public DateTime Birthday { get; set; }
        public string UserName { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
    }
}
