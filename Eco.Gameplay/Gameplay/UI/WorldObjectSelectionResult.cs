// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldObjectSelectionResult
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;

#nullable disable
namespace Eco.Gameplay.UI;

/// <summary>Result of <see cref="M:Eco.Gameplay.UI.PlayerSelectWorldObject.SelectWorldObjectInRange(Eco.Gameplay.Players.Player,System.Func{Eco.Gameplay.Objects.WorldObject,System.Boolean},System.Single,Eco.Shared.Localization.LocString,Eco.Shared.Localization.LocString,System.String,Eco.Gameplay.Objects.WorldObject)" />: a picked WorldObject, the extra button click, or a cancel.</summary>
public readonly struct WorldObjectSelectionResult
{
  public WorldObject WorldObject { get; init; }

  public bool ClickedExtraButton { get; init; }

  public bool Cancelled { get; init; }

  public bool PickedWorldObject { get; }

  public static WorldObjectSelectionResult ForCancel();

  public static WorldObjectSelectionResult ForObject(WorldObject w);

  public static WorldObjectSelectionResult ForExtraButton();
}
