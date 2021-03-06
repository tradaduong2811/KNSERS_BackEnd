﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Handle_KNSER.Entities
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public int LetterId { get; set; }
        public int MemberId { get; set; }
        public virtual Letter Letter { get; set; }
        public virtual Member Member { get; set; }
        public string Reason { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Boolean Approval { get; set; }
    }
}