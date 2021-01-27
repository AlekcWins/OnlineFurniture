using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFurniture.Domain.Model;

namespace OnlineFurniture.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Customer> Customers { get; set; }
    }
}