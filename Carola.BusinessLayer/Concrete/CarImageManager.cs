using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DataAccesLayer.Entity_Framework;
using Carola.DtoLayer.Dtos.BrandDtos;
using Carola.DtoLayer.Dtos.CarImageDtos;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class CarImageManager : ICarImageService
	{
		private readonly ICarImageDal _carImageDal;
		private readonly IMapper _mapper;

		public CarImageManager(ICarImageDal carImageDal, IMapper mapper)
		{
			_carImageDal = carImageDal;
			_mapper = mapper;
		}

		public async Task CreateCarImageAsync(CreateCarImageDto createCarImageDto)
		{
			var value = _mapper.Map<CarImage>(createCarImageDto);
			await _carImageDal.InsertAsync(value);
		}

		public async Task DeleteCarImageAsync(int id)
		{
			await _carImageDal.DeleteAsync(id);
		}

		public async Task<List<ResultCarImageDto>> GetAllCarImageAsync()
		{
			var values= await _carImageDal.GetAllAsync();
			return _mapper.Map<List<ResultCarImageDto>>(values);
		}

		public async Task<UpdateCarImageDto> GetCarImageByIdAsync(int id)
		{
			var value=await _carImageDal.GetByIdAsync(id);
			return _mapper.Map<UpdateCarImageDto>(value);
		}

		public async Task UpdateCarImageAsync(UpdateCarImageDto updateCarImageDto)
		{
			var value = _mapper.Map<CarImage>(updateCarImageDto);
			await _carImageDal.UpdateAsync(value);
		}
	}
}
