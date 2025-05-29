using MagicLoaderGenerator.Localization.Transforms;

namespace SigilStoneEffects;

public class SigilStoneEffectsTransform(SigilStoneEffectsConfig config, string prefix):
    BaseMagicLoaderFileTransform
{
    private Dictionary<string, List<string>> Effects => config.Effects;


    /// <inheritdoc/>
    protected override string FormatLine(string key)
    {
        return $"{prefix}{base.FormatLine(key)}{GetEffects(key)}";
    }

    private string GetEffects(string key)
    {
        return Effects.TryGetValue(key, out var list) ? $" ({FormatList(list)})" : string.Empty;
    }

    private static string FormatList(List<string> list)
    {
        return $"{MarkerStart}{string.Join($"{MarkerEnd} / {MarkerStart}", list)}{MarkerEnd}";
    }
}
