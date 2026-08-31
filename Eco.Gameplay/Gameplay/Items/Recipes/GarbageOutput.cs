// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.GarbageOutput
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Ecopedia;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

[Category("Hidden")]
public class GarbageOutput : IController, IViewController, IHasUniversalID, ICustomEcopediaPage
{
  [SyncToView(null, true)]
  public Type GarbageMaterialType { get; protected set; }

  [SyncToView(null, true)]
  public IDynamicValue Quantity { get; protected set; }

  /// <summary>Icon shown for this output in the crafting UI: the material's sorted output item's icon (the material classes have no sprites of their own).</summary>
  [SyncToView(null, true)]
  public string IconName { get; }

  /// <summary>Back-reference to the recipe that owns this output. Set by <see cref="T:Eco.Gameplay.Items.Recipes.Recipe" /> when building its garbage lists so tooltips can
  /// build a <see cref="T:Eco.Gameplay.Bonuses.BonusContext" /> to apply talent/module bonuses dynamically.</summary>
  public Recipe OwnerRecipe { get; internal set; }

  public string GetEcopediaPage();

  /// <summary>Flags the displayed quantity as an estimate when the owning recipe takes tag ingredients, since the salvage cost of the item actually contributed may differ from the previewed one.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Details, TTFlags.None, null, new Type[] {})]
  public LocString ApproximateQuantityTooltip();

  public ref int ControllerID { get; }

  public GarbageOutput();

  public GarbageOutput(Type garbageMaterialType, float quantity);

  public GarbageOutput(Type garbageMaterialType, IDynamicValue quantity);
}
