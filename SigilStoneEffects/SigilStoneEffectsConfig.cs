using Microsoft.Extensions.Configuration;
using MagicLoaderGenerator.Filesystem;

namespace SigilStoneEffects;

public record SigilStoneEffectsConfig: AppConfig
{
    private static Dictionary<string, string> DefaultPrefixes => new() {
        { "sorted",  " µ" },
        { "default", ""  }
    };

    public SigilStoneEffectsConfig(IConfiguration config) : base(config) {}

    public Dictionary<string, string> Prefixes { get; } = DefaultPrefixes;

    public Dictionary<string, List<string>> Effects { get; } = [];
}
