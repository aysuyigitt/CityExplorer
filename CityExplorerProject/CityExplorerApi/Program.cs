using CityExplorer.BusinessLayer.Manager;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.DataAccessLayer.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CityExplorerContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IAboutService,AboutManager>();   
builder.Services.AddScoped<IAboutRepository,AboutRepository>();

builder.Services.AddScoped<IAttractionService, AttractionManager>();
builder.Services.AddScoped<IAttractionRepository, AttractionRepository>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryRepositoy, CategoryRepository>();

builder.Services.AddScoped<ICategoryDetailService, CategoryDetailManager>();
builder.Services.AddScoped<ICategoryDetailRepository, CategoryDetailRepository>();

builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ICityRepository, CityRepository>();

builder.Services.AddScoped<ICityDetailService, CityDetailManager>();
builder.Services.AddScoped<ICityDetailRepository, CityDetailRepository>();

builder.Services.AddScoped<IEventService, EventManager>();
builder.Services.AddScoped<IEventRepository, EventRepository>();

builder.Services.AddScoped<IEventDetailService, EventDetailManager>();
builder.Services.AddScoped<IEventDetailRepository, EventDetailRepository>();

builder.Services.AddScoped<ISliderService, SliderManager>();
builder.Services.AddScoped<ISliderRepository, SliderRepository>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialRepository, TestimnialRepository>();

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();

builder.Services.AddScoped<IBlogDetailService, BlogDetailManager>();
builder.Services.AddScoped<IBlogDetailRepository, BlogDetailRepository>();

builder.Services.AddScoped<ITicketService, TicketManager>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
