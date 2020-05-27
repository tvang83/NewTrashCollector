using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewTrashCol.Models
{
    public class Customer
    {
        //customer model class for db 

        [Key]

        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string PickupDay { get; set; }
        public string SuspendPickup { get; set; }

        public string OneTimePickup { get; set; }

        public string Balance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
