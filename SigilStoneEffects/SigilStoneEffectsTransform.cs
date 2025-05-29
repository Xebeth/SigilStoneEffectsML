using MagicLoaderGenerator.Localization.Transforms;

namespace SigilStoneEffects;

public class SigilStoneEffectsTransform(SigilStoneEffectsConfig config, string prefix):
    BaseMagicLoaderFileTransform
{
    protected Dictionary<string, List<string>> Effects => config.Effects;

    protected readonly string Prefix = prefix;

    protected string Placeholder(string key)
    {
        return base.FormatLine(key);
    }

    /// <inheritdoc/>
    protected override string FormatLine(string key)
    {
        return $"{Prefix}{Placeholder(key)}{GetEffects(key)}";
    }

    protected string GetEffects(string key)
    {
        return Effects.TryGetValue(key, out var list) ? $" ({FormatList(list)})" : string.Empty;
    }

    private static string FormatList(List<string> list)
    {
        return $"{MarkerStart}{string.Join($"{MarkerEnd} / {MarkerStart}", list)}{MarkerEnd}";
    }
}
