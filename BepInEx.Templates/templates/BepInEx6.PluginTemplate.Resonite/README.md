<p align="center">
    <img src="icon.png">
</p>

# ProjectName
[![Thunderstore Version](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fthunderstore.io%2Fapi%2Fexperimental%2Fpackage%2F{firstAuthor}%2FProjectName%2F&query=%24.latest.version_number&label=Thunderstore&style=flat&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/resonite/p/{firstAuthor}/ProjectName/)
[![Thunderstore Downloads](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fthunderstore.io%2Fapi%2Fv1%2Fpackage-metrics%2F{firstAuthor}%2FProjectName%2F&query=%24.downloads&label=downloads&style=flat&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/resonite/p/{firstAuthor}/ProjectName/)
<!--#if (ci == "github") -->
[![Build](https://img.shields.io/github/actions/workflow/status/{firstAuthor}/ProjectName/build.yml?style=flat&logo=github)](https://github.com/{firstAuthor}/ProjectName/actions/workflows/build.yml)
<!--#endif -->
[![License](https://img.shields.io/badge/license-MIT-blue?style=flat)](#license)

A [Resonite](https://resonite.com/) mod that [TODO: describe what your mod does here].

## Installation (Manual)
1. Install [BepisLoader](https://github.com/ResoniteModding/BepisLoader) for Resonite.
2. Download the latest release ZIP file (e.g., `{firstAuthor}-ProjectName-{version}.zip`) from the [Releases](https://github.com/{firstAuthor}/ProjectName/releases) page.
3. Extract the ZIP and copy the `plugins` folder to your BepInEx folder in your Resonite installation directory:
   - **Default location:** `C:\Program Files (x86)\Steam\steamapps\common\Resonite\BepInEx\`
4. Start the game. If you want to verify that the mod is working you can check your BepInEx logs.

## Development

Requires the .NET 11 SDK (see `global.json`).

```sh
# build + Thunderstore package into ./build
dotnet build -c Release -t:PackTS -v d

# build + copy the plugin into your BepInEx/plugins folder
dotnet build
```

The game and BepInEx folders are detected from Steam, r2modman and Gale. If detection gets it wrong, copy `Config.Build.user.props.template` to `Config.Build.user.props` and set `GamePath` / `BepInExPath` there. Set `<CopyToPlugins>false</CopyToPlugins>` there to stop the plugin being copied into the BepInEx folder on every build.

<!--#if (ci == "github") -->
The included GitHub Actions workflows build every push, create Thunderstore packages from the Publish workflow, and create a draft GitHub release plus NuGet package on `v*` tags. Add `TCLI_AUTH_TOKEN` and `NUGET_API_KEY` repository secrets before using the publish and release workflows.
<!--#endif -->

**TODO: Remove this section after setting up your project**

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
