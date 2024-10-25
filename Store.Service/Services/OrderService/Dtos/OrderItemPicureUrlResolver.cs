﻿using AutoMapper;
using AutoMapper.Execution;
using Microsoft.Extensions.Configuration;
using Store.Data.Entities.OrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.OrderService.Dtos
{
    public class OrderItemPicureUrlResolver : IValueResolver<OrderItem, OrderItemDto,string>
    {

        private readonly IConfiguration _configuration;
        public OrderItemPicureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ProductItem.PictureUrl))
                    return $"{_configuration["BaseUrl"]}/{source.ProductItem.PictureUrl}";
            return null ;
        }
    }
}