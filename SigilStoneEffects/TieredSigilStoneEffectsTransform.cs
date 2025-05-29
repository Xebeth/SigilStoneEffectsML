namespace SigilStoneEffects;

public class TieredSigilStoneEffectsTransform(SigilStoneEffectsConfig config, string prefix, bool roman)
    : SigilStoneEffectsTransform(config, prefix)
{
    /// <inheritdoc/>
    protected override string FormatLine(string key)
    {
        var sigilKey = "LOC_AD_Inventory_Description_SigilStone";
        var tier = string.Empty;

        if (key.EndsWith('5'))
            tier = roman ? " V" : " 5";
        else if (key.EndsWith('4'))
            tier = roman ? " IV" : " 4";
        else if (key.EndsWith('3'))
            tier = roman ? " III" : " 3";
        else if (key.EndsWith('2'))
            tier = roman ? " II" : " 2";
        else if (key.EndsWith('1'))
            tier = roman ? " I" : " 1";

        return $"{Prefix}{Placeholder(sigilKey)}{tier}{GetEffects(key)}";
    }
}
