﻿using AutoMapper;
using FoodShop.Contract.DataTransferObjects.Request.V1;
using FoodShop.Contract.DataTransferObjects.Respone.V1;
using FoodShop.Contract.DataTransferObjects.Response.V1;
using FoodShop.Domain.Entities;
using FoodShop.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.Mapper
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Product, ProductResponseList>();
            CreateMap<Product, ProductResponse>();
            CreateMap<CreateProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();
            CreateMap<AppUser, AuthExternalRequest>().ReverseMap();
            CreateMap<AppUser, LoginRequest>().ReverseMap();
            CreateMap<AppUser, UserAuthResponse>().ReverseMap();
           
        }
    }
}
