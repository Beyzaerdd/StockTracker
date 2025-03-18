using AutoMapper;
using StockTracker.Entity.Concrete;

using StockTracker.Shared.DTOs.AccountTransactionDTOs;
using StockTracker.Shared.DTOs.CustomerDTOs;
using StockTracker.Shared.DTOs.DeliveredItemDTOs;
using StockTracker.Shared.DTOs.EmployeeDTOs;

using StockTracker.Shared.DTOs.ProductDTOs;
using StockTracker.Shared.DTOs.RemainingItemDTOs;
using StockTracker.Shared.DTOs.RemainingProductDTOs;
using StockTracker.Shared.DTOs.RentalDTOs;
using StockTracker.Shared.DTOs.RentalItemDTOs;
using StockTracker.Shared.DTOs.ReturnedProductDTOs;
using StockTracker.Shared.DTOs.StockDTOs;
using StockTracker.Shared.DTOs.WarehouseAccountDTOs;

namespace StockTracker.Business.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile() {

            CreateMap<Customer, CustomerDTO>().ReverseMap();

            CreateMap<Customer, CreateCustomerDTO>().ReverseMap();

            CreateMap<Customer, UpdateCustomerDTO>().ReverseMap();


            CreateMap<CreateCustomerAccountDTO, Customer>().ReverseMap();
            CreateMap<UpdateCustomerAccountDTO, Customer>().ReverseMap();

            // Product Mapping
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<UpdateProductDTO, Product>();

            // Rental Mapping
            CreateMap<Rental, RentalDTO>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
                .ReverseMap();
            CreateMap<CreateRentalDTO, Rental>();
            CreateMap<UpdateRentalDTO, Rental>();

            // RentalItem Mapping
            CreateMap<RentalItem, RentalItemDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                .ReverseMap();
            CreateMap<CreateRentalItemDTO, RentalItem>();
            CreateMap<UpdateRentalItemDTO, RentalItem>();

            // RemainingProduct Mapping
            CreateMap<RemainingProduct, RemainingProductDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.RentalItem.Product.Name))
                .ReverseMap();
            CreateMap<CreateRemainingProductDTO, RemainingProduct>();

            // ReturnedProduct Mapping
            CreateMap<ReturnedProduct, ReturnedProductDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.RentalItem.Product.Name))
                .ReverseMap();
            CreateMap<CreateReturnedProductDTO, ReturnedProduct>();

            // CustomerAccount Mapping
            CreateMap<CustomerAccount, CustomerAccountDTO>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
                .ReverseMap();
            CreateMap<CreateCustomerAccountDTO, CustomerAccount>();
            CreateMap<UpdateCustomerAccountDTO, CustomerAccount>();

            CreateMap<WarehouseAccount, WarehouseAccountDTO>()
           .ForMember(dest => dest.IncomingAmount, opt => opt.MapFrom(src => src.IncomingTransactions.Sum(i => i.Amount)))
           .ForMember(dest => dest.OutgoingAmount, opt => opt.MapFrom(src => src.OutgoingTransactions.Sum(o => o.Amount)))
           .ForMember(dest => dest.NetAmount, opt => opt.MapFrom(src => src.NetProfit));

            // WarehouseAccountDTO -> WarehouseAccount
            CreateMap<CreateWarehouseAccountDTO, WarehouseAccount>()
                .ForMember(dest => dest.IncomingTransactions, opt => opt.MapFrom(src => src.IncomingTransactions))
                .ForMember(dest => dest.OutgoingTransactions, opt => opt.MapFrom(src => src.OutgoingTransactions));

            // IncomingTransactionDTO -> IncomingTransaction
            CreateMap<CreateIncomingTransactionDTO, IncomingTransaction>();
            CreateMap<UpdateIncomingTransactionDTO, IncomingTransaction>();

            // OutgoingTransactionDTO -> OutgoingTransaction
            CreateMap<CreateOutgoingTransactionDTO, OutgoingTransaction>();
            CreateMap<UpdateOutgoingTransactionDTO, OutgoingTransaction>();

            // Employee Mapping
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<CreateEmployeeDTO, Employee>();
         















        }


    }
}
