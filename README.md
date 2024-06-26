# BepInEx.Templates

A collection of .NET project templates for BepInEx 5 and 6 plugins

## Installation

You will need [.NET 6 or newer](https://dotnet.microsoft.com/download) to use the templates.

To install, use [dotnet](https://dotnet.microsoft.com/download) tool.

### Install stable templates

These templates are for **BepInEx 5** and **BepInEx 6.0.0-pre**:

```
dotnet new install BepInEx.Templates --nuget-source https://nuget.bepinex.dev/v3/index.json
```

This will install the following templates:

| Templates                                    | Short Name           | Language   | Tags                                   |
| -------------------------------------------- | -------------------- | ---------- | -------------------------------------- |
| BepInEx 5 Plugin Template                    | bepinex5plugin       | [C#]       | BepInEx/BepInEx 5/Plugin               |
| BepInEx 6 .NET Launcher Plugin Template      | bep6plugin_netfx     | [C#]       | BepInEx/BepInEx 6/Plugin/.NET Launcher |
| BepInEx 6 Il2Cpp Plugin Template             | bep6plugin_il2cpp    | [C#]       | BepInEx/BepInEx 6/Plugin/Il2Cpp        |
| BepInEx 6 Unity Mono Plugin Template         | bep6plugin_unitymono | [C#]       | BepInEx/BepInEx 6/Plugin/Unity Mono    |

### Install Bleeding Edge templates

These templates are for **BepInEx 5** and **BepInEx 6.0.0-be** builds:

```
dotnet new install BepInEx.Templates::2.0.0-be.4 --nuget-source https://nuget.bepinex.dev/v3/index.json
```

This will install the following project templates:

| Templates                         | Short Name              | Language | Tags                                       |
|-----------------------------------|-------------------------|----------|--------------------------------------------|
| BepInEx 5 Plugin                  | bepinex5plugin          | [C#]     | BepInEx/BepInEx 5/Plugin                   |
| BepInEx 6 .NET Core Plugin        | bep6plugin_coreclr      | [C#]     | BepInEx/BepInEx 6/Plugin/CoreCLR/.NET Core |
| BepInEx 6 .NET Framework Plugin   | bep6plugin_netfx        | [C#]     | BepInEx/BepInEx 6/Plugin/.NET Framework    |
| BepInEx 6 Unity Il2Cpp Plugin     | bep6plugin_unity_il2cpp | [C#]     | BepInEx/BepInEx 6/Plugin/Unity/Il2Cpp      |
| BepInEx 6 Unity Mono Plugin       | bep6plugin_unity_mono   | [C#]     | BepInEx/BepInEx 6/Plugin/Unity/Mono        |

## Using a template

To use a template, you can use `dotnet new` command.  
If you use Rider or Visual Studio 2022, you will be able to select the templates when creating a new solution.

For example, to create a BepInEx 5 plugin project:
```
dotnet new bepinex5plugin -n MyPluginName
```

This will create a folder name MyPluginName with an example plugin project.

All templates have additional options. To view them, use `--help` switch. For example:

```
dotnet new bepinex5plugin --help
```

will show additional options you can specify when creating a project:

```
Options:
  -T|--TargetFramework  The target framework for the project
                        text - Optional
                        Default: net35

  -D|--Description      Plugin description
                        text - Optional
                        Default: My first plugin

  -V|--Version          Plugin version
                        text - Optional
                        Default: 1.0.0
```

## Documentation, guides and more

For more guides, refer to [BepInEx Docs](https://docs.bepinex.dev).  
If you're writing a BepInEx plugin for the first time, [check out the plugin development walkthrough](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/index.html).
