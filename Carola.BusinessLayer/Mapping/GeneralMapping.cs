using AutoMapper;
using Carola.DtoLayer.Dtos.BrandDtos;
using Carola.DtoLayer.Dtos.CarDtos;
using Carola.DtoLayer.Dtos.CarImageDtos;
using Carola.DtoLayer.Dtos.CategoryDtos;
using Carola.DtoLayer.Dtos.CustomerDtos;
using Carola.DtoLayer.Dtos.FeatureDtos;
using Carola.DtoLayer.Dtos.LocationDtos;
using Carola.DtoLayer.Dtos.ReservationDtos;
using Carola.DtoLayer.Dtos.SliderDtos;
using Carola.DtoLayer.Dtos.UserDtos;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
		{
			// Customer
			CreateMap<Customer, ResultCustomerDto>().ReverseMap();
			CreateMap<Customer, CreateCustomerDto>().ReverseMap();
			CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
			CreateMap<Customer, GetCustomerByIdDto>().ReverseMap();
			CreateMap<Car, ResultCarDto>()
	.ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.BrandName))
	.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
	.ForMember(dest => dest.SeatCount, opt => opt.MapFrom(src => src.SeatCount))
	.ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
	.ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.LocationName))
	.ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Location.City))
	.ReverseMap();

			CreateMap<Car, CreateCarDto>().ReverseMap();
			CreateMap<Car, UpdateCarDto>().ReverseMap();
			CreateMap<Car, GetCarByIdDto>().ReverseMap();
			// Brand
			CreateMap<Brand, ResultBrandDto>().ReverseMap();
			CreateMap<Brand, CreateBrandDto>().ReverseMap();
			CreateMap<Brand, UpdateBrandDto>().ReverseMap();
			CreateMap<Brand, GetBrandByIdDto>().ReverseMap();

			// Category
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

			// Location
			CreateMap<Location, ResultLocationDto>()
	.ForMember(dest => dest.AuthorizedPersonName,
			   opt => opt.MapFrom(src => src.AuthorizedPerson.FirstName + " " + src.AuthorizedPerson.LastName))
	.ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
	.ReverseMap();
			CreateMap<Location, CreateLocationDto>().ReverseMap();
			CreateMap<Location, UpdateLocationDto>().ReverseMap();
			CreateMap<Location, GetLocationByIdDto>().ReverseMap();

			// Reservation
			CreateMap<Reservation, ResultReservationDto>().ReverseMap();
			CreateMap<Reservation, CreateReservationDto>().ReverseMap();
			CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
			CreateMap<Reservation, GetReservationByIdDto>().ReverseMap();

			// User
			CreateMap<User, ResultUserDto>().ReverseMap();
			CreateMap<User, CreateUserDto>().ReverseMap();
			CreateMap<User, UpdateUserDto>().ReverseMap();
			CreateMap<User, GetUserByIdDto>().ReverseMap();

			//Slider
			CreateMap<Slider, CreateSliderDto>().ReverseMap();
			CreateMap<Slider, UpdateSliderDto>().ReverseMap();
			CreateMap<Slider, ResultSliderDto>().ReverseMap();

			//Feature
			CreateMap<Feature, CreateFeatureDto>().ReverseMap();
			CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
			CreateMap<Feature, ResultFeatureDto>().ReverseMap();

			//CarImage
			CreateMap<CarImage, CreateCarImageDto>().ReverseMap();
			CreateMap<CarImage, UpdateCarImageDto>().ReverseMap();
			CreateMap<CarImage, ResultCarImageDto>().ReverseMap();
		}
	}
}
