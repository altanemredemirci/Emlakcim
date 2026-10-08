using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.Concrete;
using Emlakcim.DAL.Abstract;
using Emlakcim.DAL.Concrete.EfCore;
using Emlakcim.UI.Mapping;

namespace Emlakcim.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<MapProfile>();
            });

            #region LifeCycle: AddTransient,AddScoped,AddSingleton
            /*
             Dependency Injection Lifecycle Tanımları
ASP.NET Core'da AddTransient, AddScoped ve AddSingleton, bir servisin ne kadar süre yaşayacağını (lifecycle) belirler.

1. AddTransient
Her istendiğinde yeni bir nesne (instance) oluşturulur.

services.AddTransient<IMailService, MailService>();

Örneğin aynı request içerisinde servis 3 kez istenirse 3 farklı instance oluşturulur.

Kullanım alanı:

Stateless (durum tutmayan) servisler

Hafif ve kısa ömürlü servisler

Her kullanımda yeni nesne oluşturulmasının sorun olmadığı durumlar

2. AddScoped
Her scope için bir instance oluşturulur. ASP.NET Core Web API'de genellikle bir HTTP request bir scope'tur.

services.AddScoped<IUserService, UserService>();

Aynı HTTP request içerisinde servis kaç kez istenirse istensin aynı instance kullanılır.

Request 1 → UserService A
Request 1 → UserService A
Request 1 → UserService A

Request 2 → UserService B
Request 2 → UserService B

Kullanım alanı:

Request boyunca aynı instance'ın kullanılmasının istendiği servisler

DbContext gibi request bazlı çalışan servisler

Unit of Work benzeri yapılar

3. AddSingleton
Uygulama çalıştığı sürece tek bir instance oluşturulur ve tüm isteklerde aynı instance kullanılır.

services.AddSingleton<ICacheService, CacheService>();

Request 1 → CacheService A
Request 2 → CacheService A
Request 3 → CacheService A

Kullanım alanı:

Uygulama genelinde ortak kullanılacak servisler

Cache

Thread-safe configuration/helper servisleri

Oluşturulması maliyetli ve paylaşılması uygun nesneler

Singleton servislerin thread-safe olması önemlidir; aynı instance'a eş zamanlı olarak birden fazla request erişebilir.

Temel fark
Lifetime	Instance sayısı	Yaşam süresi
AddTransient	Her injection'da yeni	Çok kısa
AddScoped	Scope/request başına 1	Request/scope süresi
AddSingleton	Uygulama başına 1	Uygulama süresi

Akılda tutmak için
Transient  → Her kullanımda yeni
Scoped     → Her Request'te bir tane
Singleton  → Tüm uygulamada bir tane

Örneğin DbContext için genellikle Scoped, basit stateless servisler için Transient, uygulama genelinde paylaşılması gereken ve thread-safe servisler için Singleton tercih edilir.
             
             */

            #endregion

            //Dependency Injection : Bağımlılık Yönetimi
            builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
            builder.Services.AddScoped<IProductTypeDal, EfCoreProductTypeDal>();

            builder.Services.AddScoped<ISliderService, SliderService>();
            builder.Services.AddScoped<ISliderDal, EfCoreSliderDal>();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductDal, EfCoreProductDal>();


            builder.Services.AddScoped<IWhoWeAreService, WhoWeAreService>();
            builder.Services.AddScoped<IWhoWeAreDal, EfCoreWhoWeAreDal>();

            builder.Services.AddScoped<IAgencyService, AgencyService>();
            builder.Services.AddScoped<IAgencyDal, EfCoreAgencyDal>();

            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IClientDal, EfCoreClientDal>();

            ///<summary>
            ///Kullanıcı Index sayfasını açarken HomePropertyList Componentini çalıştırır.
            ///Component kendi içerisinde IProductService.GetAll() metodunu çağırır.
            ///Yukarıda yazdığımız AddScope sayesinde IProductService interface'i ProductService.GetAll metodunu tetikler.
            ///ProductService içerisinde IProductDal.GetAll() metodu çağrılır.
            ///Yukarıda yazdığımız AddScope sayesinde IProductDal interface'i EfCoreProductDal.GetAll metodunu tetikler.
            /// </summary>




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
