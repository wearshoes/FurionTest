using FurionTest.Application.Configurations;
using Microsoft.Extensions.Options;

namespace FurionTest.Application;

public class SystemService : ISystemService,ISingleton,IDisposable
{
    private readonly IDisposable _optionsReloadToken;
    
    private SubAddressOptions _options;
    
    public SystemService(IOptionsMonitor<SubAddressOptions> options)
    {
        Log.Information("Initializing system service");
        (_optionsReloadToken, _options) = (options.OnChange(ReloadOptions), options.CurrentValue);
    }

    private void ReloadOptions(SubAddressOptions options)
    {
        _options = options;
        Log.Information($"配置被reload了,当前订阅地址有{_options.Address.Count}条");
    }
    public string GetDescription()
    {
        return "让 .NET 开发更简单，更通用，更流行。";
    }

    public void Dispose()
    {
        _optionsReloadToken?.Dispose();
    }
}
