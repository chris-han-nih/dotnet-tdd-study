namespace Orders.UnitTests;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestPlatform.TestHost;

public sealed class OrdersServer: TestServer
{
    public OrdersServer(IServiceProvider services, IOptions<TestServerOptions> optionsAccessor) :
        base(services, optionsAccessor)
    {
    }
    
    public OrdersServer Create()
    {
        var server = (OrdersServer)new Factory().Server;

        return server;
    }

    private sealed class Factory : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<IServer, OrdersServer>();
            });
            builder.ConfigureAppConfiguration(config =>
            {
                config.AddInMemoryCollection(new Dictionary<string, string>
                {
                    ["ConnectionStrings:OrdersConnection"] = "Server=localhost:5432;Database=Orders_UnitTests;User Id=postgres;Password=1234qwer;",
                }!);
            });
            return base.CreateHost(builder);
        }
    }
}
