# BepInEx.Templates

A collection of .NET project templates for BepInEx 6 plugins for developing Resonite mods.

## Installation

You will need [.NET 11 or newer](https://dotnet.microsoft.com/download) to use the templates.

To install, use [dotnet](https://dotnet.microsoft.com/download) tool.

### Install Bleeding Edge templates

These templates are for **BepInEx 6.0.0-be** builds:

```
dotnet new install BepInEx.Templates::2.0.0-be.* --nuget-source https://nuget-modding.resonite.net/v3/index.json
```

This will install the following project templates:

| Template                                                                 | Short Name            | Language | Tags                                                          |
|--------------------------------------------------------------------------|-----------------------|----------|---------------------------------------------------------------|
| BepInEx 6 Resonite Plugin (.NET 11, Thunderstore Ready)                  | bep6resonite          | [C#]     | BepInEx/BepInEx 6/Plugin/CoreCLR/.NET 11/Resonite/Thunderstore |
| BepInEx 6 Resonite Plugin (.NET 11, GitHub Actions, Thunderstore Ready)  | bep6resonite-github   | [C#]     | BepInEx/BepInEx 6/Plugin/CoreCLR/.NET 11/GitHub/Resonite/Thunderstore |

## Using a template

To use a template, use the `dotnet new` command.
If you use Rider or Visual Studio, you can also select the templates when creating a new solution; the arguments below are shown in the new-project wizard.

Create a minimal BepInEx 6 plugin project with no CI configuration:

```
dotnet new bep6resonite -n MyPluginName
```

This creates a `MyPluginName` folder with an example plugin project.

Create the same project with GitHub Actions and Dependabot included:

```
dotnet new bep6resonite-github -n MyPluginName
```

`bep6resonite-github` is the base template with `--ci github` already applied. Both templates share the same project content, so this produces the same project:

```
dotnet new bep6resonite -n MyPluginName --ci github
```

### Arguments

Both templates accept the same arguments. `bep6resonite-github` fixes `--ci` to `github`, so it does not expose that argument.

| Argument                                | Type   | Default                                      | Description                                                                                                                   |
|-----------------------------------------|--------|----------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| `-c`, `--ci <github\|none>`             | choice | `none`                                       | CI configuration to include. `github` adds the `.github` workflows and CI-specific build settings. Only on `bep6resonite`.     |
| `-ve`, `--version <version>`            | text   | `1.0.0`                                      | Plugin version.                                                                                                               |
| `-au`, `--authors <authors>`            | text   | `YourName`                                   | Comma-separated list of plugin authors. The first author is used for the default package ID and repository URL.               |
| `-r`, `--repositoryUrl <repositoryUrl>` | text   | empty                                        | Repository URL for the plugin. Defaults to `https://github.com/[FirstAuthor]/[ProjectName]`.                                  |
| `-p`, `--packageId <packageId>`         | text   | empty                                        | NuGet package ID. Defaults to `[FirstAuthor].[ProjectName]`.                                                                  |
| `-g`, `--gitInit`                       | bool   | `true`                                       | Initialize a git repository in the new project.                                                                               |

Run `dotnet new <short-name> --help` to see the arguments for a specific template:

```
dotnet new bep6resonite --help
dotnet new bep6resonite-github --help
```

### GitHub CI

The `github` CI option adds:

- `.github/workflows/build.yml` - builds every push and uploads the plugin DLL, NuGet package and Thunderstore ZIP.
- `.github/workflows/publish.yml` - publishes a Thunderstore package (needs a `TCLI_AUTH_TOKEN` repository secret).
- `.github/workflows/release.yml` - creates a draft GitHub release and publishes the NuGet package on `v*` tags (needs `NUGET_API_KEY`).
- `.github/dependabot.yml` - daily GitHub Actions and NuGet updates.
- Continuous-integration build settings in `Directory.Build.props` and version hand-off in `Directory.Build.targets`.

## Documentation, guides and more

For more guides, refer to [Resonite Modding Docs](https://modding.resonite.net).
