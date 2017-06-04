using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }

        //[Min18YearsOfAMember]
        public DateTime? Birthday { get; set; }
    }
}