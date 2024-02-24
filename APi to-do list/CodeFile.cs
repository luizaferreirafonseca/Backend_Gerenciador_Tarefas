using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder => builder.WithOrigins("http://localhost:3000") // Substitua pela origem do seu frontend
                                  .AllowAnyMethod()
                                  .AllowAnyHeader());
        });

        // Resto da configuração de serviços...
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseCors("AllowSpecificOrigin");

        // Resto da configuração de middleware...

        app.UseMvc();
    }


}
