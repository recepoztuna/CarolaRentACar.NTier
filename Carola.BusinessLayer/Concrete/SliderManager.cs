using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.SliderDtos;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class SliderManager:ISliderService
	{
		private readonly ISliderDal _sliderDal;
		private readonly IMapper _mapper;

		public SliderManager(ISliderDal sliderDal, IMapper mapper)
		{
			_sliderDal = sliderDal;
			_mapper = mapper;
		}

		public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
		{
			var slider = _mapper.Map<Slider>(createSliderDto);
			await _sliderDal.InsertAsync(slider);
		}

		public async Task DeleteSliderAsync(int id)
		{
			
			await _sliderDal.DeleteAsync(id);
		}

		public async Task<List<ResultSliderDto>> GetAllSliderAsync()
		{
			var sliders = await _sliderDal.GetAllAsync();
			return _mapper.Map<List<ResultSliderDto>>(sliders);
		}

		public async Task<UpdateSliderDto> GetSliderByIdAsync(int id)
		{
			var slider = await _sliderDal.GetByIdAsync(id);
			return _mapper.Map<UpdateSliderDto>(slider);
		}

		public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
		{
			var slider = _mapper.Map<Slider>(updateSliderDto);
			await _sliderDal.UpdateAsync(slider);
		}
	}
}
