﻿namespace MinimapPlugin
{
    public enum MinimapPosition
    {
        LeftBottom,
        RightBottom
    }

    public enum TileType
    {
        Dirt = 0,
        Stone,
        Grass,
        Plants,
        Torches,
        Trees,
        Iron,
        Copper,
        Gold,
        Silver,
        Door1,
        Door2,
        Heart,
        Bottles,
        Table,
        Chair,
        Anvil,
        Furnance,
        CraftingTable,
        WoodenPlatform,
        PlantsDecorative,
        Chest,
        CorruptionStone1,
        CorruptionGrass,
        CorruptionPlants,
        CorruptionStone2,
        Altar,
        Sunflower,
        Pot,
        PiggyBank,
        BlockWood,
        ShadowOrb,
        CorruptionVines,
        Candle,
        ChandlerCopper,
        ChandlerSilver,
        ChandlerGold,
        Meterorite,
        BlockStone,
        BlockRedStone,
        Clay,
        BlockBlueStone,
        LightGlobe,
        BlockGreenStone,
        BlockPinkStone,
        BlockGold,
        BlockSilver,
        BlockCopper,
        Spikes,
        CandleBlue,
        Books,
        Web,
        Vines,
        Sand,
        Glass,
        Signs,
        Obsidian,
        Ash,
        Hellstone,
        Mud,
        UndergroundJungleGrass,
        UndergroundJunglePlants,
        UndergroundJungleVines,
        Sapphire,
        Ruby,
        Emerald,
        Topaz,
        Amethyst,
        Diamond,
        UndergroundJungleThorns,
        UndergroundMushroomGrass,
        UndergroundMushroomPlants,
        UndergroundMushroomTrees,
        Plants2,
        Plants3,
        BlockObsidian,
        BlockHellstone,
        UnderworldFurnance,
        DecorativePot,
        Bed,
        Cactus,
        Coral,
        HerbSprout,
        HerbStalk,
        Herb,
        Tombstone,
        Unknown = 86
    }

    public enum WallType
    {
        Sky = TerrariaColors.WallOffset,
        WallStone,
        WallDirt,
        WallCorruption,
        WallWood,
        WallBrick,
        WallRed,
        WallBlue,
        WallGreen,
        WallPink,
        WallGold,
        WallSilver,
        WallCopper,
        WallHellstone,
        WallUnknown
    }

    public enum LiquidType
    {
        Water = TerrariaColors.LiquidOffset,
        Lava
    }
}