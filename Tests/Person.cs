﻿using System;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkTriggers;

namespace Tests {
    public class Person : EntityWithTriggers<Person> {
        [Key]
        public Int64 Id { get; protected set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
