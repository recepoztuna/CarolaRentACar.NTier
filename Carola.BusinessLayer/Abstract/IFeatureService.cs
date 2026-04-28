using Carola.DtoLayer.Dtos.FeatureDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
	public interface IFeatureService
	{
		Task<List<ResultFeatureDto>> GetAllFeatureAsync();
		Task<UpdateFeatureDto> GetFeatureByIdAsync(int id);
		Task CreateFeatureAsync(CreateFeatureDto createFeatureDto);
		Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto);
		Task DeleteFeatureAsync(int id);
	}
}
