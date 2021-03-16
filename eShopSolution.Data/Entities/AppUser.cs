using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
       public string DisplayName { get; set; }
       public Gender Gender { get; set; }
       public string Adress { get; set; }
    
        public List<Cart> Carts { get; set; }

        public List<Order> Orders { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
