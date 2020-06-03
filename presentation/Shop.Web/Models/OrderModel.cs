﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Shop.Web.Models
{
    public class OrderModel
    {
        public int  Id { get; set; }
        public OrderItemModel[]Items { get; set; } = new OrderItemModel[0];
        public int  TotalCount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}