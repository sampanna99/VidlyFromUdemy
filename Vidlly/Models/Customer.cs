﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidlly.ViewModels;

namespace Vidlly.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }

        [Min18YearsOfAMember]
        public DateTime? Birthday { get; set; }
    }
}