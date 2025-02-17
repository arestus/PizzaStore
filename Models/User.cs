﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaStore.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public string PhoneNo { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
