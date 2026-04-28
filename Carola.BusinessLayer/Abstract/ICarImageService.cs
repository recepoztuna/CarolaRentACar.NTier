using Carola.DtoLayer.Dtos.CarImageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
	public interface ICarImageService
	{
		Task<List<ResultCarImageDto>> GetAllCarImageAsync();
		Task<UpdateCarImageDto> GetCarImageByIdAsync(int id);
		Task CreateCarImageAsync(CreateCarImageDto createCarImageDto);
		Task UpdateCarImageAsync(UpdateCarImageDto updateCarImageDto);
		Task DeleteCarImageAsync(int id);
	}
}
