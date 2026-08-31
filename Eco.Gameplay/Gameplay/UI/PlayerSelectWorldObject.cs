// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.PlayerSelectWorldObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.UI;

/// <summary>Lets a player click a <see cref="T:Eco.Gameplay.Objects.WorldObject" /> in the world. Eligible objects are highlighted client-side;
/// the user can also click an optional overlay button or press ESC / move out of range to cancel.</summary>
public static class PlayerSelectWorldObject
{
  /// <summary>Open client-side selection mode for a <see cref="T:Eco.Gameplay.Objects.WorldObject" /> within <paramref name="maxDistance" /> that passes <paramref name="filter" />.
  /// When <paramref name="extraButtonLabel" /> is set, the overlay shows a button whose click resolves with <c>ClickedExtraButton = true</c>;
  /// <paramref name="extraButtonIcon" /> is resolved client-side via <c>Image.SetIcon</c>.
  /// <paramref name="attachVFXTo" />, when set, parents the range-circle VFX so it inherits the WorldObject's transform.</summary>
  public static 
  #nullable disable
  Task<WorldObjectSelectionResult> SelectWorldObjectInRange(
    this Player player,
    Func<WorldObject, bool> filter,
    float maxDistance,
    LocString helpText,
    LocString extraButtonLabel,
    string extraButtonIcon = "",
    WorldObject attachVFXTo = null);
}
