﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class ShopcartItems
    {
        public ShopcartItems()
        {
            OrdersLogin = new HashSet<OrdersLogin>();
        }

        public string ShopcartId { get; set; }
        public int ProductId { get; set; }
        public int? Quality { get; set; }

        public virtual Products Product { get; set; }
        public virtual Shopcarts Shopcart { get; set; }
        public virtual ICollection<OrdersLogin> OrdersLogin { get; set; }
    }
}