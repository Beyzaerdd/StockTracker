using AutoMapper;
using StockTracker.Entity.Concrete;
using StockTracker.Shared.DTOs;
using StockTracker.Shared.DTOs.AccountSummaryDTOs;
using StockTracker.Shared.DTOs.AccountTransactionDTOs;
using StockTracker.Shared.DTOs.CustomerDTOs;
using StockTracker.Shared.DTOs.DeliveredItemDTOs;
using StockTracker.Shared.DTOs.EmployeeDTOs;
using StockTracker.Shared.DTOs.ExpenseDTOs;
using StockTracker.Shared.DTOs.PaymentDTOs;
using StockTracker.Shared.DTOs.ProductDTOs;
using StockTracker.Shared.DTOs.RemainingItemDTOs;
using StockTracker.Shared.DTOs.RentalDTOs;
using StockTracker.Shared.DTOs.RentalItemDTOs;
using StockTracker.Shared.DTOs.StockDTOs;

namespace StockTracker.Business.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile() { 
        
         CreateMap<AccountSummary, AccountSummaryDTO>().ReverseMap();
         CreateMap<AccountTransaction, AccountTransactionDTO>().ReverseMap();
         CreateMap<AccountTransaction, CreateAccountTransactionDTO>().ReverseMap();
         CreateMap<AccountTransaction, UpdateAccountTransactionDTO>().ReverseMap();
        CreateMap<Customer, CustomerDTO>().ReverseMap();
         CreateMap<Customer, CreateCustomerDTO>().ReverseMap();
         CreateMap<Customer, UpdateCustomerDTO>().ReverseMap();
        CreateMap<DeliveredItem , DeliveredItemDTO>().ReverseMap();
        CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee, LoginEmployeeDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
            CreateMap<Expense , ExpenseDTO>().ReverseMap();
            CreateMap<Expense, CreateExpenseDTO>().ReverseMap();
            CreateMap<Payment, PaymentDTO>().ReverseMap();
            CreateMap<Payment, UpdatePaymentDTO>().ReverseMap();
            CreateMap<Payment, CreatePaymentDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();

            CreateMap<RemainingItem, RemainingItemDTO>().ReverseMap();
            CreateMap<CreateRentalDTO, Rental>()
             .ForMember(dest => dest.RentalItems, opt => opt.MapFrom(src => src.RentalItems)).ReverseMap();


            CreateMap<Rental, RentalDTO>();
            CreateMap<Rental, CreateRentalDTO>().ReverseMap();
           

            CreateMap<RentalItem, RentalItemDTO>().ReverseMap();
            CreateMap<RentalItem, CreateRentalItemDTO>().ReverseMap();
            CreateMap<RentalItem, UpdateRentalItemDTO>().ReverseMap();
            CreateMap<Stock, StockDTO>().ReverseMap();
            CreateMap<Stock, CreateStockDTO>().ReverseMap();
            CreateMap<Stock, UpdateStockDTO>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();















        }


    }
}
