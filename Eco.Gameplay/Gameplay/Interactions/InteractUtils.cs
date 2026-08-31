// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.InteractUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Interactions;

public static class InteractUtils
{
  /// <summary>Return true if the player is too far for the interaction, and notify the player and server. Gives 1 meter of 'fudge'
  /// since this is primarily used to detect hacking.</summary>
  public static bool TooFarWithFudgeAndNotify(this Player player, Vector3i pos, float distance = 0.0f);

  /// <summary>Overload that measures to the object's nearest occupancy block rather than its pivot, so large world objects can be
  /// interacted with (picked up, moved...) from anywhere along their footprint instead of only when close to their pivot.</summary>
  public static bool TooFarWithFudgeAndNotify(this Player player, WorldObject wo, float distance = 0.0f);
}
