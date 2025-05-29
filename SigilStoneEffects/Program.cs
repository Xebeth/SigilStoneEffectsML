using MagicLoaderGenerator.Filesystem.Abstractions;
using MagicLoaderGenerator.Filesystem.Generators;
using Microsoft.Extensions.Configuration;
using MagicLoaderGenerator;
using SigilStoneEffects;

// generate base game version
GenerateFile("config.json");
// generate Superior Sigil Stones version
var outputDir = GenerateFile("superiorsigil.json");

System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
    FileName = Directory.GetParent(outputDir)?.FullName ?? outputDir,
    UseShellExecute = true,
    Verb = "open"
});

return;

string GenerateFile(string configName)
{
    var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile(configName, optional: false);
    var appConfig = new SigilStoneEffectsConfig(builder.Build());
    var mod = new MagicLoaderMod(appConfig);

    var variants = new Dictionary<string, IMagicLoaderFileTransform?>();

    foreach (var (variant, prefix) in appConfig.Prefixes)
    {
        variants.Add($"tiered_roman_{variant}", new TieredSigilStoneEffectsTransform(appConfig, prefix, true));
        variants.Add($"tiered_{variant}", new TieredSigilStoneEffectsTransform(appConfig, prefix, false));
        variants.Add(variant, new SigilStoneEffectsTransform(appConfig, prefix));
    }

    return mod.Generate(new ZipOutputGenerator(appConfig), variants);
}
