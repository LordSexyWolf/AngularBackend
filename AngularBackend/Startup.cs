using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AngularBackend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(op => op.UseSqlServer(Configuration.GetConnectionString("CardConnection")));
            services.AddControllers();
        }
    }
}
