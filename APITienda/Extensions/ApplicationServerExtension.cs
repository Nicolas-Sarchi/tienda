namespace APITienda.Extensions;

public static class ApplicationServerExtension
{
    public static void ConfigureCors(this IServiceCollection services)  =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
        
    });
}
