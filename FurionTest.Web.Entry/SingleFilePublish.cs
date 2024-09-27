﻿using Furion;
using System.Reflection;

namespace FurionTest.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "FurionTest.Application",
            "FurionTest.Core",
            "FurionTest.Web.Core"
        };
    }
}