using Carola.BusinessLayer.Abstract;
using Carola.BusinessLayer.Concrete;
using Carola.BusinessLayer.Mapping;
using Carola.BusinessLayer.ValidationRules;
using Carola.BusinessLayer.ValidationRules.BrandValidator;
using Carola.BusinessLayer.ValidationRules.CarValidator;
using Carola.BusinessLayer.ValidationRules.CategoryValidator;
using Carola.BusinessLayer.ValidationRules.CustomerValidator;
using Carola.BusinessLayer.ValidationRules.LocationValidator;
using Carola.BusinessLayer.ValidationRules.ReservationValidator;
using Carola.BusinessLayer.ValidationRules.UserValidator;
using Carola.DataAccesLayer.Abstract;
using Carola.DataAccesLayer.Concrete;
using Carola.DataAccesLayer.Entity_Framework;
using Carola.DtoLayer.Dtos.BrandDtos;
using Carola.DtoLayer.Dtos.CarDtos;
using Carola.DtoLayer.Dtos.CategoryDtos;
using Carola.DtoLayer.Dtos.CustomerDtos;
using Carola.DtoLayer.Dtos.LocationDtos;
using Carola.DtoLayer.Dtos.ReservationDtos;
using Carola.DtoLayer.Dtos.UserDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CarolaContext>();


// DAL
builder.Services.AddScoped<IBrandDal, EFBrandDal>();
builder.Services.AddScoped<ICarDal, EFCarDal>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ILocationDal, EFLocationDal>();
builder.Services.AddScoped<ICustomerDal, EFCustomerDAL>();
builder.Services.AddScoped<IUserDal, EFUserDal>();
builder.Services.AddScoped<IReservationDal, EFReservationDal>();
builder.Services.AddScoped<ISliderDal, EFSliderDal>();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();
builder.Services.AddScoped<ICarImageDal, EFCarImageDal>();

// Business
builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ILocationService, LocationManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IReservationService, ReservationManager>();
builder.Services.AddScoped<ISliderService, SliderManager>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<ICarImageService, CarImageManager>();

builder.Services.AddScoped<IValidator<CreateBrandDto>, CreateBrandValidator>();
builder.Services.AddScoped<IValidator<UpdateBrandDto>, UpdateBrandValidator>();

builder.Services.AddScoped<IValidator<CreateCarDto>, CreateCarValidator>();
builder.Services.AddScoped<IValidator<UpdateCarDto>, UpdateCarValidator>();

builder.Services.AddScoped<IValidator<CreateCategoryDto>, CreateCategoryValidator>();
builder.Services.AddScoped<IValidator<UpdateCategoryDto>, UpdateCategoryValidator>();

builder.Services.AddScoped<IValidator<CreateLocationDto>, CreateLocationValidator>();
builder.Services.AddScoped<IValidator<UpdateLocationDto>, UpdateLocationValidator>();

builder.Services.AddScoped<IValidator<CreateCustomerDto>, CreateCustomerValidator>();
builder.Services.AddScoped<IValidator<UpdateCustomerDto>, UpdateCustomerValidator>();

builder.Services.AddScoped<IValidator<CreateReservationDto>, CreateReservationValidator>();
builder.Services.AddScoped<IValidator<UpdateReservationDto>, UpdateReservationValidator>();

builder.Services.AddScoped<IValidator<CreateUserDto>, CreateUserValidator>();
builder.Services.AddScoped<IValidator<UpdateUserDto>, UpdateUserValidator>();


builder.Services.AddAutoMapper(typeof(GeneralMapping));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
});

app.Run();
