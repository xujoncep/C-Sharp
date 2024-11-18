
public class Program
{ 
    public static void Main(string[] args)
    {

        
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        var app = builder.Build();

        app.UseRouting();
        //app.MapDefaultControllerRoute();
        //app.MapGet("/", () => "Hello World!");
        app.MapControllerRoute(
                name: "default", // Name of the route
                pattern: "{controller=Home}/{action=Index}/{id?}" // URL pattern for the route
            );

        app.Run();

    }
}
