using AutoMapper;
using MedicalExpress.CORE.DTOs;
using MedicalExpress.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Mappings
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Pharmacy, PharmacyDto>();
            CreateMap<PharmacyDto, Pharmacy>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<Alarm, AlarmDto>();
            CreateMap<AlarmDto, Alarm>();
            CreateMap<Detailord, DetailordDto>();
            CreateMap<DetailordDto, Detailord>();
            CreateMap<MethodPayment, MethodPaymentDto>();
            CreateMap<MethodPaymentDto, MethodPayment>();
            CreateMap<PhotoUser, PhotoUserDto>();
            CreateMap<PhotoUserDto, PhotoUser>();
            CreateMap<CORE.Entity.Profile, ProfileDto>();
            CreateMap<ProfileDto, CORE.Entity.Profile>();
            CreateMap<Status, StatusDto>();
            CreateMap<StatusDto, Status>();
        }
    }
}
