using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;

namespace Acme.MyService;
public class MyService : ITransientDependency
{
    public ILogger<MyService> Logger { get; set; }
    public MyService()
    {
        Logger = NullLogger<MyService>.Instance;
    }

    public Task SayHelloAsync()
    {
        Logger.LogInformation("Hello My World!");
        return Task.CompletedTask;
    }


}
