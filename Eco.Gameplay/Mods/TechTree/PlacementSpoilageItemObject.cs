// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PlacementSpoilageItemObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// Separate generic spoilage world object when it's placed on surfaces.
/// all custom spoilage props and actions should be defined here instead of PlacementItemObject
/// </summary>
[Serialized]
public class PlacementSpoilageItemObject : PlacementItemObject, IHasInteractions, IHasEnvVars
{
  [SyncToView(null, true)]
  [Notify]
  [Serialized]
  [EnvVar]
  public bool IsSpoiled { get; set; }

  public override Item TakingItem { get; }

  protected SpoilageItem SpoilageItem { get; }

  protected override void ComponentsInitialized();

  public override void OnPostPlace();

  protected override void OnBeforeTake();

  protected override void OnDestroy();
}
