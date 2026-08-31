// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.DifficultySettingsConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.Shared.States;
using Eco.Shared.Utils;
using Eco.Shared.View;
using JetBrains.Annotations;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Localized(true, false, "", false)]
public class DifficultySettingsConfig : 
  Singleton<DifficultySettingsConfig>,
  IController,
  IViewController,
  IHasUniversalID
{
  internal const string EndgameRecipesPresetSuffix = "Endgame Recipes - ";
  internal const string SkillbookRecipesPresetSuffix = "Skillbook Recipes - ";
  public static readonly string EndgameRecipesNormal;
  public static readonly string EndgameRecipesExpensive;
  public static readonly string SkillbookRecipesNormal;
  public static readonly string SkillbookRecipesExpensive;

  public static bool IsSinglePlayer { get; }

  public static GameSettings Vals { get; }

  public static AdvancedGameSettings Advanced { get; }

  [UsedImplicitly]
  public DifficultySettingsConfig();

  [SyncToView(null, true)]
  [Notify]
  public GameSettings GameSettings { get; set; }

  [LocDescription("Endgame crafting cost presets for Laser and Computer Lab. Does not affect work orders in progress.")]
  public CostPreset EndgameCraftCost { get; set; }

  [LocDescription("Skillbook crafting cost presets. Does not affect work orders in progress.")]
  public CostPreset SkillbookCraftCost { get; set; }

  [LocDescription("Multiplier applied to Player's swim speed when in a specific biome.")]
  public DifficultySettingsConfig.BiomeSpecificModifiers SwimSpeed { get; set; }

  [LocDescription("Multiplier applied to Player's calorie consumption when in a specific biome. (this is a percentage multiplier, meaning 10 = 10x = 1000%)")]
  public DifficultySettingsConfig.BiomeSpecificModifiers CalorieConsumptionRate { get; set; }

  [SyncToView(null, true)]
  [LocDescription("If this is enabled, player will be teleported to nearest land once calories run out while swimming.")]
  public bool PlayerCanDrownWhenSwimming { get; set; }

  public void SetGameSettings(GameSettings settings);

  public void OnParamChanged([ControllerPropertyName(null)] string param);

  public ref int ControllerID { get; }

  [TypeConverter(typeof (ExpandableObjectConverter))]
  [Serializable]
  public class BiomeSpecificModifiers
  {
    public float Ocean { get; set; }

    public float DeepOcean { get; set; }

    public BiomeSpecificModifiers(float ocean = 1f, float deepOcean = 1f);

    public bool TryGetValue(BiomeType type, out float value);
  }
}
