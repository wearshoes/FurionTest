using Furion.ConfigurableOptions;
using Microsoft.Extensions.Configuration;

namespace FurionTest.Application.Configurations;

public class SubAddressOptions : IConfigurableOptions
{
    public bool IsAutoUpdateSub { get; set; }
    public List<string> Address { get; set; }
}