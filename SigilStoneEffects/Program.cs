using MagicLoaderGenerator.Filesystem.Abstractions;
using MagicLoaderGenerator.Filesystem.Generators;
using Microsoft.Extensions.Configuration;
using MagicLoaderGenerator;
using SigilStoneEffects;

var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("config.json", optional: false);
var variants = new Dictionary<string, IMagicLoaderFileTransform?>();
var appConfig = new SigilStoneEffectsConfig(builder.Build());
var mod = new MagicLoaderMod(appConfig);

foreach (var (variant, prefix) in appConfig.Prefixes)
{
    variants.Add(variant, new SigilStoneEffectsTransform(appConfig, prefix));
}

var outputDir = mod.Generate(new ZipOutputGenerator(appConfig), variants);

System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
    UseShellExecute = true,
    FileName = outputDir,
    Verb = "open"
});
