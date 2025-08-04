using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<IServicesDal, EfServiceDal>();
builder.Services.AddScoped<IServicesService, ServiceManager>();

builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddScoped<IBookingService, BookingManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IGuestDal, EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestManager>();

builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService, SendMessageManager>();

builder.Services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
builder.Services.AddScoped<IMessageCategoryService, MessageCategoryManager>();

builder.Services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
builder.Services.AddScoped<IWorkLocationService, WorkLocationManager>();

builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();

builder.Services.AddControllers();

// CORS servisi ekle
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWebUI", policy =>
    {
        policy.WithOrigins("http://localhost:5195") // WebUI'nin çalýþtýðý adres
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS middleware'i pipeline'a ekle
app.UseCors("AllowWebUI");

app.UseAuthorization();

app.MapControllers();

app.Run();
