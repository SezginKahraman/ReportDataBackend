
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.Business.Concrete;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.DataAccess.Concrete.EntityFramework;
using System.Text.Json.Serialization;

namespace ReportDataBackend.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.WriteIndented = true; 
                options.JsonSerializerOptions.MaxDepth = 10;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull; // do not serialize null values
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region business

            builder.Services.AddScoped<IEntraGroupService, EntraGroupManager>();
            builder.Services.AddScoped<IEntraGroupAssignmentService, EntraGroupAssignmentManager>();
            builder.Services.AddScoped<IEntraGroupModificationService, EntraGroupModificationManager>();
            builder.Services.AddScoped<IEntraPimactivationService, EntraPimactivationManager>();
            builder.Services.AddScoped<IEntraRoleService, EntraRoleManager>();
            builder.Services.AddScoped<IEntraServicePrincipalService, EntraServicePrincipalManager>();
            builder.Services.AddScoped<IEntraUserAccountService, EntraUserAccountManager>();

            #endregion

            #region DataAccess

            builder.Services.AddScoped<IEntraGroupAssignmentDal, EntraGroupAssignmentDal>();
            builder.Services.AddScoped<IEntraGroupDal, EntraGroupDal>();
            builder.Services.AddScoped<IEntraGroupModificationDal, EntraGroupModificationDal>();
            builder.Services.AddScoped<IEntraPimactivationDal, EntraPimactivationDal>();
            builder.Services.AddScoped<IEntraRoleDal, EntraRoleDal>();
            builder.Services.AddScoped<IEntraServicePrincipalDal, EntraServicePrincipalDal>();
            builder.Services.AddScoped<IEntraUserAccountDal, EntraUserAccountDal>();

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
