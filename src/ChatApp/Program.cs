namespace ChatApp;

using ChatApp.Components;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();

        builder.Services
            .AddRazorComponents()
            .AddInteractiveServerComponents();

        var app = builder.Build();

        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        app.UseStaticFiles();

        app.UseAntiforgery();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
