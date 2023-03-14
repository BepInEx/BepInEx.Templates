## BepInEx PluginInfo generator

Generates `MyPluginInfo.cs` based on csproj tags.

## Basic usage

Define the following properties in your `csproj`:

```xml
<AssemblyName>Example.Plugin</AssemblyName>
<Product>My first plugin</Product>
<Version>1.0.0</Version>
```

this will generate the following class:

```cs
using System;

internal static class MyPluginInfo
{
    public const string PLUGIN_GUID = "Example.Plugin";
    public const string PLUGIN_NAME = "My first plugin";
    public const string PLUGIN_VERSION = "1.0.0";
}
```
