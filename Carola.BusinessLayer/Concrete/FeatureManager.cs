using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.FeatureDtos;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class FeatureManager : IFeatureService
	{
		private readonly IFeatureDal _featureDal;
		private readonly IMapper _mapper;

		public FeatureManager(IFeatureDal featureDal, IMapper mapper)
		{
			_featureDal = featureDal;
			_mapper = mapper;
		}

		public async Task CreateFeatureAsync(CreateFeatureDto createFeatureDto)
		{
			var feature = _mapper.Map<Feature>(createFeatureDto);
			await _featureDal.InsertAsync(feature);
		}

		public async Task DeleteFeatureAsync(int id)
		{
			
			await _featureDal.DeleteAsync(id);
		}

		public async Task<List<ResultFeatureDto>> GetAllFeatureAsync()
		{
			var features = await _featureDal.GetAllAsync();
			return _mapper.Map<List<ResultFeatureDto>>(features);
		}

		public async Task<UpdateFeatureDto> GetFeatureByIdAsync(int id)
		{
			var feature = await _featureDal.GetByIdAsync(id);
			return _mapper.Map<UpdateFeatureDto>(feature);
		}

		public async Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto)
		{
			var feature = _mapper.Map<Feature>(updateFeatureDto);
			await _featureDal.UpdateAsync(feature);
		}
	}
}
