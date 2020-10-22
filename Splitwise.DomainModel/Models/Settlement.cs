﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Splitwise.DomainModel.Models
{
    public class Settlement
    {
        [Key]
        public long Id { get; set; }

        public long Amount { get; set; }

        public DateTime TimeStamp { get; set; }

        [ForeignKey("User")]
        public long PayUserId { get; set; }

        [ForeignKey("User")]
        public long PayeeUserId { get; set; }

        [ForeignKey("Group")]
        public long GroupId { get; set; }
    }
}