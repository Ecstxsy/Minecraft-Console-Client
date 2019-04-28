﻿namespace MinecraftClient.Mapping
{
    /// <summary>
    /// Represents Minecraft Materials
    /// </summary>
    /// <remarks>
    /// Generated from blocks.json using PaletteGenerator.cs.
    /// Typical steps to handle new blocks for newer Minecraft versions:
    /// 1. Generate blocks.json using data reporting on Vanilla Minecraft (https://wiki.vg/Data_Generators)
    /// 2. Generate temporary MaterialXXX.cs and PaletteXXX.cs using PaletteGenerator.cs
    /// 3. Perform a diff with existing versions, add missing entries in Material.cs and MaterialExtensions.cs
    /// 4. If existing state IDs were not randomized by Mojang, simply add missing state entries to Palette113.cs
    /// 5. If existing state IDs were randomized, add a new palette as PaletteXXX.cs into the codebase (worst case)
    /// </remarks>
    public enum Material
    {
        Air,
        Stone,
        Granite,
        PolishedGranite,
        Diorite,
        PolishedDiorite,
        Andesite,
        PolishedAndesite,
        GrassBlock,
        Dirt,
        CoarseDirt,
        Podzol,
        Cobblestone,
        OakPlanks,
        SprucePlanks,
        BirchPlanks,
        JunglePlanks,
        AcaciaPlanks,
        DarkOakPlanks,
        OakSapling,
        SpruceSapling,
        BirchSapling,
        JungleSapling,
        AcaciaSapling,
        DarkOakSapling,
        Bedrock,
        Water,
        Lava,
        Sand,
        RedSand,
        Gravel,
        GoldOre,
        IronOre,
        CoalOre,
        OakLog,
        SpruceLog,
        BirchLog,
        JungleLog,
        AcaciaLog,
        DarkOakLog,
        StrippedSpruceLog,
        StrippedBirchLog,
        StrippedJungleLog,
        StrippedAcaciaLog,
        StrippedDarkOakLog,
        StrippedOakLog,
        OakWood,
        SpruceWood,
        BirchWood,
        JungleWood,
        AcaciaWood,
        DarkOakWood,
        StrippedOakWood,
        StrippedSpruceWood,
        StrippedBirchWood,
        StrippedJungleWood,
        StrippedAcaciaWood,
        StrippedDarkOakWood,
        OakLeaves,
        SpruceLeaves,
        BirchLeaves,
        JungleLeaves,
        AcaciaLeaves,
        DarkOakLeaves,
        Sponge,
        WetSponge,
        Glass,
        LapisOre,
        LapisBlock,
        Dispenser,
        Sandstone,
        ChiseledSandstone,
        CutSandstone,
        NoteBlock,
        WhiteBed,
        OrangeBed,
        MagentaBed,
        LightBlueBed,
        YellowBed,
        LimeBed,
        PinkBed,
        GrayBed,
        LightGrayBed,
        CyanBed,
        PurpleBed,
        BlueBed,
        BrownBed,
        GreenBed,
        RedBed,
        BlackBed,
        PoweredRail,
        DetectorRail,
        StickyPiston,
        Cobweb,
        Grass,
        Fern,
        DeadBush,
        Seagrass,
        TallSeagrass,
        Piston,
        PistonHead,
        WhiteWool,
        OrangeWool,
        MagentaWool,
        LightBlueWool,
        YellowWool,
        LimeWool,
        PinkWool,
        GrayWool,
        LightGrayWool,
        CyanWool,
        PurpleWool,
        BlueWool,
        BrownWool,
        GreenWool,
        RedWool,
        BlackWool,
        MovingPiston,
        Dandelion,
        Poppy,
        BlueOrchid,
        Allium,
        AzureBluet,
        RedTulip,
        OrangeTulip,
        WhiteTulip,
        PinkTulip,
        OxeyeDaisy,
        BrownMushroom,
        RedMushroom,
        GoldBlock,
        IronBlock,
        Bricks,
        Tnt,
        Bookshelf,
        MossyCobblestone,
        Obsidian,
        Torch,
        WallTorch,
        Fire,
        Spawner,
        OakStairs,
        Chest,
        RedstoneWire,
        DiamondOre,
        DiamondBlock,
        CraftingTable,
        Wheat,
        Farmland,
        Furnace,
        Sign,
        OakDoor,
        Ladder,
        Rail,
        CobblestoneStairs,
        WallSign,
        Lever,
        StonePressurePlate,
        IronDoor,
        OakPressurePlate,
        SprucePressurePlate,
        BirchPressurePlate,
        JunglePressurePlate,
        AcaciaPressurePlate,
        DarkOakPressurePlate,
        RedstoneOre,
        RedstoneTorch,
        RedstoneWallTorch,
        StoneButton,
        Snow,
        Ice,
        SnowBlock,
        Cactus,
        Clay,
        SugarCane,
        Jukebox,
        OakFence,
        Pumpkin,
        Netherrack,
        SoulSand,
        Glowstone,
        NetherPortal,
        CarvedPumpkin,
        JackOLantern,
        Cake,
        Repeater,
        WhiteStainedGlass,
        OrangeStainedGlass,
        MagentaStainedGlass,
        LightBlueStainedGlass,
        YellowStainedGlass,
        LimeStainedGlass,
        PinkStainedGlass,
        GrayStainedGlass,
        LightGrayStainedGlass,
        CyanStainedGlass,
        PurpleStainedGlass,
        BlueStainedGlass,
        BrownStainedGlass,
        GreenStainedGlass,
        RedStainedGlass,
        BlackStainedGlass,
        OakTrapdoor,
        SpruceTrapdoor,
        BirchTrapdoor,
        JungleTrapdoor,
        AcaciaTrapdoor,
        DarkOakTrapdoor,
        InfestedStone,
        InfestedCobblestone,
        InfestedStoneBricks,
        InfestedMossyStoneBricks,
        InfestedCrackedStoneBricks,
        InfestedChiseledStoneBricks,
        StoneBricks,
        MossyStoneBricks,
        CrackedStoneBricks,
        ChiseledStoneBricks,
        BrownMushroomBlock,
        RedMushroomBlock,
        MushroomStem,
        IronBars,
        GlassPane,
        Melon,
        AttachedPumpkinStem,
        AttachedMelonStem,
        PumpkinStem,
        MelonStem,
        Vine,
        OakFenceGate,
        BrickStairs,
        StoneBrickStairs,
        Mycelium,
        LilyPad,
        NetherBricks,
        NetherBrickFence,
        NetherBrickStairs,
        NetherWart,
        EnchantingTable,
        BrewingStand,
        Cauldron,
        EndPortal,
        EndPortalFrame,
        EndStone,
        DragonEgg,
        RedstoneLamp,
        Cocoa,
        SandstoneStairs,
        EmeraldOre,
        EnderChest,
        TripwireHook,
        Tripwire,
        EmeraldBlock,
        SpruceStairs,
        BirchStairs,
        JungleStairs,
        CommandBlock,
        Beacon,
        CobblestoneWall,
        MossyCobblestoneWall,
        FlowerPot,
        PottedOakSapling,
        PottedSpruceSapling,
        PottedBirchSapling,
        PottedJungleSapling,
        PottedAcaciaSapling,
        PottedDarkOakSapling,
        PottedFern,
        PottedDandelion,
        PottedPoppy,
        PottedBlueOrchid,
        PottedAllium,
        PottedAzureBluet,
        PottedRedTulip,
        PottedOrangeTulip,
        PottedWhiteTulip,
        PottedPinkTulip,
        PottedOxeyeDaisy,
        PottedRedMushroom,
        PottedBrownMushroom,
        PottedDeadBush,
        PottedCactus,
        Carrots,
        Potatoes,
        OakButton,
        SpruceButton,
        BirchButton,
        JungleButton,
        AcaciaButton,
        DarkOakButton,
        SkeletonWallSkull,
        SkeletonSkull,
        WitherSkeletonWallSkull,
        WitherSkeletonSkull,
        ZombieWallHead,
        ZombieHead,
        PlayerWallHead,
        PlayerHead,
        CreeperWallHead,
        CreeperHead,
        DragonWallHead,
        DragonHead,
        Anvil,
        ChippedAnvil,
        DamagedAnvil,
        TrappedChest,
        LightWeightedPressurePlate,
        HeavyWeightedPressurePlate,
        Comparator,
        DaylightDetector,
        RedstoneBlock,
        NetherQuartzOre,
        Hopper,
        QuartzBlock,
        ChiseledQuartzBlock,
        QuartzPillar,
        QuartzStairs,
        ActivatorRail,
        Dropper,
        WhiteTerracotta,
        OrangeTerracotta,
        MagentaTerracotta,
        LightBlueTerracotta,
        YellowTerracotta,
        LimeTerracotta,
        PinkTerracotta,
        GrayTerracotta,
        LightGrayTerracotta,
        CyanTerracotta,
        PurpleTerracotta,
        BlueTerracotta,
        BrownTerracotta,
        GreenTerracotta,
        RedTerracotta,
        BlackTerracotta,
        WhiteStainedGlassPane,
        OrangeStainedGlassPane,
        MagentaStainedGlassPane,
        LightBlueStainedGlassPane,
        YellowStainedGlassPane,
        LimeStainedGlassPane,
        PinkStainedGlassPane,
        GrayStainedGlassPane,
        LightGrayStainedGlassPane,
        CyanStainedGlassPane,
        PurpleStainedGlassPane,
        BlueStainedGlassPane,
        BrownStainedGlassPane,
        GreenStainedGlassPane,
        RedStainedGlassPane,
        BlackStainedGlassPane,
        AcaciaStairs,
        DarkOakStairs,
        SlimeBlock,
        Barrier,
        IronTrapdoor,
        Prismarine,
        PrismarineBricks,
        DarkPrismarine,
        PrismarineStairs,
        PrismarineBrickStairs,
        DarkPrismarineStairs,
        PrismarineSlab,
        PrismarineBrickSlab,
        DarkPrismarineSlab,
        SeaLantern,
        HayBlock,
        WhiteCarpet,
        OrangeCarpet,
        MagentaCarpet,
        LightBlueCarpet,
        YellowCarpet,
        LimeCarpet,
        PinkCarpet,
        GrayCarpet,
        LightGrayCarpet,
        CyanCarpet,
        PurpleCarpet,
        BlueCarpet,
        BrownCarpet,
        GreenCarpet,
        RedCarpet,
        BlackCarpet,
        Terracotta,
        CoalBlock,
        PackedIce,
        Sunflower,
        Lilac,
        RoseBush,
        Peony,
        TallGrass,
        LargeFern,
        WhiteBanner,
        OrangeBanner,
        MagentaBanner,
        LightBlueBanner,
        YellowBanner,
        LimeBanner,
        PinkBanner,
        GrayBanner,
        LightGrayBanner,
        CyanBanner,
        PurpleBanner,
        BlueBanner,
        BrownBanner,
        GreenBanner,
        RedBanner,
        BlackBanner,
        WhiteWallBanner,
        OrangeWallBanner,
        MagentaWallBanner,
        LightBlueWallBanner,
        YellowWallBanner,
        LimeWallBanner,
        PinkWallBanner,
        GrayWallBanner,
        LightGrayWallBanner,
        CyanWallBanner,
        PurpleWallBanner,
        BlueWallBanner,
        BrownWallBanner,
        GreenWallBanner,
        RedWallBanner,
        BlackWallBanner,
        RedSandstone,
        ChiseledRedSandstone,
        CutRedSandstone,
        RedSandstoneStairs,
        OakSlab,
        SpruceSlab,
        BirchSlab,
        JungleSlab,
        AcaciaSlab,
        DarkOakSlab,
        StoneSlab,
        SandstoneSlab,
        PetrifiedOakSlab,
        CobblestoneSlab,
        BrickSlab,
        StoneBrickSlab,
        NetherBrickSlab,
        QuartzSlab,
        RedSandstoneSlab,
        PurpurSlab,
        SmoothStone,
        SmoothSandstone,
        SmoothQuartz,
        SmoothRedSandstone,
        SpruceFenceGate,
        BirchFenceGate,
        JungleFenceGate,
        AcaciaFenceGate,
        DarkOakFenceGate,
        SpruceFence,
        BirchFence,
        JungleFence,
        AcaciaFence,
        DarkOakFence,
        SpruceDoor,
        BirchDoor,
        JungleDoor,
        AcaciaDoor,
        DarkOakDoor,
        EndRod,
        ChorusPlant,
        ChorusFlower,
        PurpurBlock,
        PurpurPillar,
        PurpurStairs,
        EndStoneBricks,
        Beetroots,
        GrassPath,
        EndGateway,
        RepeatingCommandBlock,
        ChainCommandBlock,
        FrostedIce,
        MagmaBlock,
        NetherWartBlock,
        RedNetherBricks,
        BoneBlock,
        StructureVoid,
        Observer,
        ShulkerBox,
        WhiteShulkerBox,
        OrangeShulkerBox,
        MagentaShulkerBox,
        LightBlueShulkerBox,
        YellowShulkerBox,
        LimeShulkerBox,
        PinkShulkerBox,
        GrayShulkerBox,
        LightGrayShulkerBox,
        CyanShulkerBox,
        PurpleShulkerBox,
        BlueShulkerBox,
        BrownShulkerBox,
        GreenShulkerBox,
        RedShulkerBox,
        BlackShulkerBox,
        WhiteGlazedTerracotta,
        OrangeGlazedTerracotta,
        MagentaGlazedTerracotta,
        LightBlueGlazedTerracotta,
        YellowGlazedTerracotta,
        LimeGlazedTerracotta,
        PinkGlazedTerracotta,
        GrayGlazedTerracotta,
        LightGrayGlazedTerracotta,
        CyanGlazedTerracotta,
        PurpleGlazedTerracotta,
        BlueGlazedTerracotta,
        BrownGlazedTerracotta,
        GreenGlazedTerracotta,
        RedGlazedTerracotta,
        BlackGlazedTerracotta,
        WhiteConcrete,
        OrangeConcrete,
        MagentaConcrete,
        LightBlueConcrete,
        YellowConcrete,
        LimeConcrete,
        PinkConcrete,
        GrayConcrete,
        LightGrayConcrete,
        CyanConcrete,
        PurpleConcrete,
        BlueConcrete,
        BrownConcrete,
        GreenConcrete,
        RedConcrete,
        BlackConcrete,
        WhiteConcretePowder,
        OrangeConcretePowder,
        MagentaConcretePowder,
        LightBlueConcretePowder,
        YellowConcretePowder,
        LimeConcretePowder,
        PinkConcretePowder,
        GrayConcretePowder,
        LightGrayConcretePowder,
        CyanConcretePowder,
        PurpleConcretePowder,
        BlueConcretePowder,
        BrownConcretePowder,
        GreenConcretePowder,
        RedConcretePowder,
        BlackConcretePowder,
        Kelp,
        KelpPlant,
        DriedKelpBlock,
        TurtleEgg,
        DeadTubeCoralBlock,
        DeadBrainCoralBlock,
        DeadBubbleCoralBlock,
        DeadFireCoralBlock,
        DeadHornCoralBlock,
        TubeCoralBlock,
        BrainCoralBlock,
        BubbleCoralBlock,
        FireCoralBlock,
        HornCoralBlock,
        DeadTubeCoral,
        DeadBrainCoral,
        DeadBubbleCoral,
        DeadFireCoral,
        DeadHornCoral,
        TubeCoral,
        BrainCoral,
        BubbleCoral,
        FireCoral,
        HornCoral,
        DeadTubeCoralWallFan,
        DeadBrainCoralWallFan,
        DeadBubbleCoralWallFan,
        DeadFireCoralWallFan,
        DeadHornCoralWallFan,
        TubeCoralWallFan,
        BrainCoralWallFan,
        BubbleCoralWallFan,
        FireCoralWallFan,
        HornCoralWallFan,
        DeadTubeCoralFan,
        DeadBrainCoralFan,
        DeadBubbleCoralFan,
        DeadFireCoralFan,
        DeadHornCoralFan,
        TubeCoralFan,
        BrainCoralFan,
        BubbleCoralFan,
        FireCoralFan,
        HornCoralFan,
        SeaPickle,
        BlueIce,
        Conduit,
        VoidAir,
        CaveAir,
        BubbleColumn,
        StructureBlock,
    }
}
