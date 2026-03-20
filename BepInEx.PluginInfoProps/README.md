## BepInEx PluginInfo generator

Generates a `MyPluginInfo.cs`, or `.fs`, based on project tags.

Supports C# & F# projects, and will read the `.csproj` or `.fsproj` to determine values.

## Basic usage

Define the following properties in your project file:

```xml
<GUID>Example.Plugin</GUID> <!--  Optional. If missing, <AssemblyName> is used as GUID instead. -->
<Product>My first plugin</Product>
<Version>1.0.0</Version>
```

this will generate the following class:

**C#**
```cs
internal static class MyPluginInfo
{
    public const string PLUGIN_GUID = "Example.Plugin";
    public const string PLUGIN_NAME = "My first plugin";
    public const string PLUGIN_VERSION = "1.0.0";
}
```

**F#**
```fsharp
module internal MyPluginInfo = 
    [<Literal>] 
    let PLUGIN_GUID: string = "Example.Plugin"
    [<Literal>] 
    let PLUGIN_NAME: string = "My first plugin"
    [<Literal>] 
    let PLUGIN_VERSION: string = "1.0.0"
```