using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MVCTaskmanager.identity;
using MVCTaskmanager.serviceContracts;
using MVCTaskmanager.Services;
using MVCTaskmanager.Seed;
using MVCTaskmanager;
using System.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace MVCTaskmanager
{
    public static class startup
    {
        /*public static IConfiguration _Configuration { get; set; }
        public static WebApplication InitializeApp(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);
            var _builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _Configuration = _builder.Build();
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
            
        }

        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
           (_Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MVCTaskmanager")));

            builder.Services.AddTransient<IRoleStore<IdentityRole>, ApplicationRoleStore>();
            builder.Services.AddTransient<UserManager<ApplicationUser>, ApplicationUserManager>();
            builder.Services.AddTransient<SignInManager<ApplicationUser>, ApplicationSignInManager>();
            builder.Services.AddTransient<RoleManager<IdentityRole>, ApplicationRoleManager>();
            builder.Services.AddTransient<IUserStore<ApplicationUser>, ApplicationUserStore>();
            builder.Services.AddTransient<IUsersService, UsersService>();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddUserStore<ApplicationUserStore>()
                .AddUserManager<ApplicationUserManager>()
                .AddRoleManager<ApplicationRoleManager>()
                .AddSignInManager<ApplicationSignInManager>()
                .AddRoleStore<ApplicationRoleStore>()
                .AddDefaultTokenProviders();

            builder.Services.AddScoped<ApplicationRoleStore>();
            builder.Services.AddScoped<ApplicationUserStore>();

            //Configure JWT Authentication
            var appSettingsSection = _Configuration.GetSection("AppSettings");

            builder.Services.Configure<AppSettings>(appSettingsSection);

            var appSetings = appSettingsSection.Get<AppSettings>();

            var key = System.Text.Encoding.ASCII.GetBytes(appSetings.Secret);

            builder.Services.AddAuthentication(x =>
            {
                //x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                //x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; 
            }).AddCookie()
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // Antiforgery
            builder.Services.AddAntiforgery(options =>
            {
                options.Cookie.Name = "XSRF-Cookie-TOKEN";
                options.HeaderName = "X-XSRF-TOKEN";
                options.SuppressXFrameOptionsHeader = false;
            });
        }

        private async static void Configure(WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


           
            //IServiceScopeFactory serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
            using (IServiceScope scope = app.Services.CreateScope())
            {
                RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                UserManager<ApplicationUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                seedData.Seed(roleManager, userManager);
            }

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
          }
        */
    }
}
