using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carola.EntityLayer.Entities;
using Carola.DtoLayer.Dtos.CustomerDtos;

namespace Carola.BusinessLayer.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
		{
			CreateMap<Customer,ResultCustomerDto>().ReverseMap();
			CreateMap<Customer,CreateCustomerDto>().ReverseMap();
			CreateMap<Customer,UpdateCustomerDto>().ReverseMap();
			CreateMap<Customer,GetCustomerByIdDto>().ReverseMap();
		}
	}
}
