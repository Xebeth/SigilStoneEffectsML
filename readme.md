# Description

Display the effects of sigil stones. I tried to use one term where it made sense:\
e.g. Damage Intelligence/Absorb Intelligence => Intelligence\
Inspired by [Visible Sigil Stone Effects](https://www.nexusmods.com/oblivionremastered/mods/1009).

## Install

- Manually download [MagicLoader](https://www.nexusmods.com/oblivionremastered/mods/1966?tab=description) **2.4+** and extract it to:
    - Steam: `~\Oblivion Remastered\MagicLoader\`
    - GamePass: `~\The Elder Scrolls IV- Oblivion Remastered\Content\MagicLoader\`
- Download and extract your flavour of the mod
- Run* MagicLoader.exe* (version 2 will now start the game unless you create a shortcut and add -c as a parameter).
- Launch the game, if necessary depending on the previous step.

## Uninstall

- Delete `SigilStoneEffects.json` from `~\OblivionRemastered_*\Content\Dev\ObvData\Data\MagicLoader\`
- Delete contents of: `\OblivionRemastered_*\Content\Paks\~mods\MagicLoader\`
- Run `MagicLoader.exe` if you have other mods that depend on it, skip this step if not.
- Launch the game, if necessary.

## Update
- Overwrite *SigilStoneEffects.json* in `\OblivionRemastered_*\Content\Dev\ObvData\Data\MagicLoader\`
- Run `MagicLoader.exe`.
- Launch the game, if necessary.

## Compatibility
- Compatible with [Tools First - Inventory Sorting](https://www.nexusmods.com/oblivionremastered/mods/964) 3.0 (use the standard version of this mod)
- A separate version of the mod that supports [Superior Sigil Stones](https://www.nexusmods.com/oblivionremastered/mods/3406) can be found in the optional files (with the same variants)
- Incompatible with any mod changes the name or doesn't correctly reference these same items using their LOC_FN names.

## Notes
- You must re-run [MagicLoader](https://www.nexusmods.com/oblivionremastered/mods/1966?tab=description) **2.4+** if I send out any updates to apply them!
- Safe mid-playthrough, but ALWAYS make backups when adding new mods!
- Vortex should be able to put my mod in the correct place for you with the `install` button, but you still need to manually install [MagicLoader](https://www.nexusmods.com/oblivionremastered/mods/1966?tab=description) and inject the files after installing it.

## Credits
- kpvw for the xEdit script used to retrieve the localization strings ([Visible Sigil Stone Effects](https://www.nexusmods.com/oblivionremastered/mods/1009)).
- RareMojo for the mod description I shamelessly copied from [Tools First - Inventory Sorting](https://www.nexusmods.com/oblivionremastered/mods/964) .

# Changelog
## Version 1.0.0
- First stable release
- Add support for Superior Sigil Stones
