﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Handle_KNSER.Entities
{
    public class MemberUser : IdentityUser
    {
        [Required]
        public int KNSId { get; set; }

        public string Fullname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }

        public string University { get; set; }

        public int? Year { get; set; }
        public string Description { get; set; }
        public int? Term { get; set; }

        public string KNSRole { get; set; }

        public Boolean isActive { get; set; }
    }
}