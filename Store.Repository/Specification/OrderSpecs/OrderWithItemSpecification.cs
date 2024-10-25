﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Entities.OrderEntities;
namespace Store.Repository.Specification.OrderSpecs
{
    public class OrderWithItemSpecification:BaseSpecificationcs<Order>
    {
        public OrderWithItemSpecification(string buyerEmail) :base(order=>order.BuyerEmail==buyerEmail)
        {
            AddInclude(order => order.DeliveryMethod);
            AddInclude(order => order.OrderItem);
            AddOrderByDescending(order => order.OrderDate);

        }

        public OrderWithItemSpecification(Guid id):base(order=>order.Id==id)
        {
            AddInclude(order => order.DeliveryMethod);
            AddInclude(order => order.OrderItem);
        }
    }
}
